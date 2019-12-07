using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;


namespace Scanner
{
    public partial class Scanner : Form
    {
        /// <summary>
        /// Menager urządzeń
        /// </summary>
        private DeviceManager deviceManager = new DeviceManager();

        /// <summary>
        /// Podłączone urządzenie
        /// </summary>
        private DeviceInfo firstScannerAvailable;

        /// <summary>
        /// Zeskanowany dokument
        /// </summary>
        private ImageFile scannedDocument;

        /// <summary>
        /// Ścieżka do zapisania zeskanowanego pliku
        /// </summary>
        private string filePath;

        /// <summary>
        /// Kontrast
        /// </summary>
        private int contrast;

        /// <summary>
        /// Rozdzielczość
        /// </summary>
        private int resolution;

        /// <summary>
        /// Id wybranego skanera
        /// </summary>
        private int chosenDeviceId;

        /// <summary>
        /// Tryb skanowania
        /// 1 - RGB
        /// 2 - Grey
        /// 4 - BW
        /// </summary>
        private int colorMode;

        /// <summary>
        /// Jasność skanowanego dokumentu
        /// </summary>
        private int brightness;

        /// <summary>
        /// Wysokość dokumentu
        /// </summary>
        private int documentHeight;

        /// <summary>
        /// Szerokość dokumentu
        /// </summary>
        private int documentWidth;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public Scanner()
        {
            InitializeComponent();

            // Dodanie opcji skanowania
            comboBoxScanningMode.Items.Add("Kolorowe");
            comboBoxScanningMode.Items.Add("Czarno białe");
            comboBoxScanningMode.Items.Add("Szare");

        }

        /// <summary>
        /// Wyszukanie wszystkich dostępnych skanerów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckForAvailableScanners_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                {
                    comboBoxAvailableScanners.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                    firstScannerAvailable = deviceManager.DeviceInfos[i];
                }
            }
        }

        /// <summary>
        /// Zmiana kontrastu przez użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScanningContrast_TextChanged(object sender, EventArgs e)
        {
            if(!Int32.TryParse(textBoxScanningContrast.Text, out contrast))
            {
                MessageBox.Show("Wprowadzono nieprawidłowy kontrast, spróbuj ponownie!");
            }
            else
            {
                try
                {
                    trackBarScanningContrast.Value = contrast;
                    trackBarScanningContrast.Update();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wprowadzono wartość poza zakresem, spróbuj ponownie!");
                    contrast = 0;
                    trackBarScanningContrast.Value = contrast;
                    trackBarScanningContrast.Update();
                    textBoxScanningContrast.Text = contrast.ToString();
                }
            }
        }

        /// <summary>
        /// Zmiana rozdzielczości przez użytkownika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScanningResolution_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxScanningResolution.Text, out resolution))
            {
                MessageBox.Show("Wprowadzono nieprawidłową rozdzielczość, spróbuj ponownie!");
            }
            else
            {
                try
                {
                    trackBarSetScanningResolution.Value = resolution;
                    trackBarSetScanningResolution.Update();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wprowadzono wartość poza zakresem, spróbuj ponownie!");
                    resolution = 0;
                    trackBarSetScanningResolution.Value = resolution;
                    trackBarSetScanningResolution.Update();
                    textBoxScanningResolution.Text = resolution.ToString();
                }
            }
        }


        /// <summary>
        /// Zmiana kontrastu suwakiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarScanningContrast_Scroll(object sender, EventArgs e)
        {
            contrast = trackBarScanningContrast.Value;
            textBoxScanningContrast.Text = contrast.ToString();
            textBoxScanningContrast.Update();
        }

        /// <summary>
        /// Zmiana rozdzielczości suwakiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarSetScanningResolution_Scroll(object sender, EventArgs e)
        {
            resolution = trackBarSetScanningResolution.Value;
            textBoxScanningResolution.Text = resolution.ToString();
            textBoxScanningResolution.Update();
        }


        /// <summary>
        /// Dostosowanie ustawień skanera bazując na danych ustawionych przez użytkownika
        /// </summary>
        /// <param name="scannnerItem"></param>
        /// <param name="scanResolutionDPI"></param>
        /// <param name="scanStartLeftPixel"></param>
        /// <param name="scanStartTopPixel"></param>
        /// <param name="scanWidthPixels"></param>
        /// <param name="scanHeightPixels"></param>
        /// <param name="brightnessPercents"></param>
        /// <param name="contrastPercents"></param>
        /// <param name="colorMode"></param>
        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        /// <summary>
        /// Funkcja umożliwiająca modyfikację property z biblioteki WIA
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="propName"></param>
        /// <param name="propValue"></param>
        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        /// <summary>
        /// Rozpoczęcie skanowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartScanning_Click(object sender, EventArgs e)
        {
            try
            {
                // Połączenie z wybranym skanerem
                var connectedDevice = firstScannerAvailable.Connect();

                // Wybranie obiektu skanowania
                var scannerItem = connectedDevice.Items[1];

                // Ustawienie opcji skanera
                AdjustScannerSettings(scannerItem, resolution, 0, 0, documentWidth, documentHeight, brightness, contrast, colorMode);

                // Wykonanie skanowania
                scannedDocument = (ImageFile)scannerItem.Transfer("{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}");


                filePath += "\\scan.jpeg";

                // Sprawdzenie czy ścieżka jest wolna
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                // Zapis do pliku
                scannedDocument.SaveFile(filePath);

                MessageBox.Show("Zeskanowany dokument został zapisany do pliku");


                // Wyświetlenie zeskanowanego dokumentu w formie
                pictureBoxScannedDocument.ImageLocation = filePath;
            }
            catch(Exception)
            {
                MessageBox.Show("Wystąpił błąd podczas skanowania, upewnij się że odpowiedni skaner jest wybrany oraz podłączony");
            }
        }


        /// <summary>
        /// Wybranie urządzenia z listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxAvailableScanners_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenDeviceId = comboBoxAvailableScanners.SelectedIndex + 1;
            firstScannerAvailable = deviceManager.DeviceInfos[chosenDeviceId];
        }

        /// <summary>
        /// Zmiana trybu skanowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxScanningMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chosenScanningMode = comboBoxScanningMode.Text;
            if (chosenScanningMode.Equals("Kolorowe")) colorMode = 1;
            if (chosenScanningMode.Equals("Czarno białe")) colorMode = 2;
            if (chosenScanningMode.Equals("Szare")) colorMode = 4;
            
        }

        /// <summary>
        /// Zmiana szerokości skanu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScanningWidth_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxScanningWidth.Text, out documentWidth))
            {
                MessageBox.Show("Wprowadzono nieprawidłową szerokość, spróbuj ponownie!");
            }
            else
            {
                try
                {
                    trackBarScanningWidth.Value = documentWidth;
                    trackBarScanningWidth.Update();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wprowadzono wartość poza zakresem, spróbuj ponownie!");
                    documentWidth = 0;
                    trackBarScanningWidth.Value = documentWidth;
                    trackBarScanningWidth.Update();
                    textBoxScanningWidth.Text = documentWidth.ToString();
                }
            }
        }

        /// <summary>
        /// Zmiana wysokości skanu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScanningHeight_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxScanningHeight.Text, out documentHeight))
            {
                MessageBox.Show("Wprowadzono nieprawidłową wysokość, spróbuj ponownie!");
            }
            else
            {
                try
                {
                    trackBarScanningHeight.Value = documentHeight;
                    trackBarScanningHeight.Update();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wprowadzono wartość poza zakresem, spróbuj ponownie!");
                    documentHeight = 0;
                    trackBarScanningHeight.Value = documentHeight;
                    trackBarScanningHeight.Update();
                    textBoxScanningHeight.Text = documentHeight.ToString();
                }
            }
        }

        /// <summary>
        /// Zmiana szerokości skanu suwakiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarScanningWidth_Scroll(object sender, EventArgs e)
        {
            documentWidth = trackBarScanningWidth.Value;
            textBoxScanningWidth.Text = documentWidth.ToString();
            textBoxScanningWidth.Update();
        }

        /// <summary>
        /// Zmiana wysokości skanu suwakiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarScanningHeight_Scroll(object sender, EventArgs e)
        {
            documentHeight = trackBarScanningHeight.Value;
            textBoxScanningHeight.Text = documentHeight.ToString();
            textBoxScanningHeight.Update();
        }

        /// <summary>
        /// Zmiana jasności skanu suwakiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarScanningBrightness_Scroll(object sender, EventArgs e)
        {
            brightness = trackBarScanningBrightness.Value;
            textBoxScanningBrightness.Text = brightness.ToString();
            textBoxScanningBrightness.Update();
        }

        /// <summary>
        /// Zmiana jasności skanu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScanningBrightness_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(textBoxScanningBrightness.Text, out brightness))
            {
                MessageBox.Show("Wprowadzono nieprawidłową jasność, spróbuj ponownie!");
            }
            else
            {
                try
                {
                    trackBarScanningBrightness.Value = brightness;
                    trackBarScanningBrightness.Update();
                }
                catch(Exception)
                {
                    MessageBox.Show("Wprowadzono wartość poza zakresem, spróbuj ponownie!");
                    brightness = 0;
                    trackBarScanningBrightness.Value = brightness;
                    trackBarScanningBrightness.Update();
                    textBoxScanningBrightness.Text = brightness.ToString();
                }
            }
        }

        private void Scanner_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Wybór ścieżki do zapisu skanowanego dokumentu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFileDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    filePath = fbd.SelectedPath;
                }
            }
        }
    }
}
