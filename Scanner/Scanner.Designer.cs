namespace Scanner
{
    partial class Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxScannedDocument = new System.Windows.Forms.PictureBox();
            this.comboBoxAvailableScanners = new System.Windows.Forms.ComboBox();
            this.buttonCheckForAvailableScanners = new System.Windows.Forms.Button();
            this.buttonStartScanning = new System.Windows.Forms.Button();
            this.buttonSelectFileDirectory = new System.Windows.Forms.Button();
            this.labelScanningMode = new System.Windows.Forms.Label();
            this.labelScanningContrast = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.comboBoxScanningMode = new System.Windows.Forms.ComboBox();
            this.textBoxScanningContrast = new System.Windows.Forms.TextBox();
            this.textBoxScanningResolution = new System.Windows.Forms.TextBox();
            this.trackBarScanningContrast = new System.Windows.Forms.TrackBar();
            this.trackBarSetScanningResolution = new System.Windows.Forms.TrackBar();
            this.labelScanningBrightness = new System.Windows.Forms.Label();
            this.textBoxScanningBrightness = new System.Windows.Forms.TextBox();
            this.trackBarScanningBrightness = new System.Windows.Forms.TrackBar();
            this.trackBarScanningWidth = new System.Windows.Forms.TrackBar();
            this.textBoxScanningWidth = new System.Windows.Forms.TextBox();
            this.labelScanningWidth = new System.Windows.Forms.Label();
            this.trackBarScanningHeight = new System.Windows.Forms.TrackBar();
            this.textBoxScanningHeight = new System.Windows.Forms.TextBox();
            this.labelScanningHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScannedDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetScanningResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScannedDocument
            // 
            this.pictureBoxScannedDocument.Location = new System.Drawing.Point(856, 10);
            this.pictureBoxScannedDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxScannedDocument.Name = "pictureBoxScannedDocument";
            this.pictureBoxScannedDocument.Size = new System.Drawing.Size(560, 713);
            this.pictureBoxScannedDocument.TabIndex = 0;
            this.pictureBoxScannedDocument.TabStop = false;
            // 
            // comboBoxAvailableScanners
            // 
            this.comboBoxAvailableScanners.FormattingEnabled = true;
            this.comboBoxAvailableScanners.Location = new System.Drawing.Point(11, 54);
            this.comboBoxAvailableScanners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAvailableScanners.Name = "comboBoxAvailableScanners";
            this.comboBoxAvailableScanners.Size = new System.Drawing.Size(268, 24);
            this.comboBoxAvailableScanners.TabIndex = 1;
            this.comboBoxAvailableScanners.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailableScanners_SelectedIndexChanged);
            // 
            // buttonCheckForAvailableScanners
            // 
            this.buttonCheckForAvailableScanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckForAvailableScanners.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonCheckForAvailableScanners.Location = new System.Drawing.Point(11, 10);
            this.buttonCheckForAvailableScanners.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckForAvailableScanners.Name = "buttonCheckForAvailableScanners";
            this.buttonCheckForAvailableScanners.Size = new System.Drawing.Size(268, 31);
            this.buttonCheckForAvailableScanners.TabIndex = 2;
            this.buttonCheckForAvailableScanners.Text = "Wyszukaj skanery";
            this.buttonCheckForAvailableScanners.UseVisualStyleBackColor = true;
            this.buttonCheckForAvailableScanners.Click += new System.EventHandler(this.buttonCheckForAvailableScanners_Click);
            // 
            // buttonStartScanning
            // 
            this.buttonStartScanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartScanning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonStartScanning.Location = new System.Drawing.Point(14, 709);
            this.buttonStartScanning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartScanning.Name = "buttonStartScanning";
            this.buttonStartScanning.Size = new System.Drawing.Size(642, 70);
            this.buttonStartScanning.TabIndex = 3;
            this.buttonStartScanning.Text = "Rozpocznij skanowanie";
            this.buttonStartScanning.UseVisualStyleBackColor = true;
            this.buttonStartScanning.Click += new System.EventHandler(this.buttonStartScanning_Click);
            // 
            // buttonSelectFileDirectory
            // 
            this.buttonSelectFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSelectFileDirectory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSelectFileDirectory.Location = new System.Drawing.Point(836, 747);
            this.buttonSelectFileDirectory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelectFileDirectory.Name = "buttonSelectFileDirectory";
            this.buttonSelectFileDirectory.Size = new System.Drawing.Size(268, 31);
            this.buttonSelectFileDirectory.TabIndex = 4;
            this.buttonSelectFileDirectory.Text = "Zapisz jako";
            this.buttonSelectFileDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectFileDirectory.Click += new System.EventHandler(this.buttonSelectFileDirectory_Click);
            // 
            // labelScanningMode
            // 
            this.labelScanningMode.AutoSize = true;
            this.labelScanningMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningMode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelScanningMode.Location = new System.Drawing.Point(42, 153);
            this.labelScanningMode.Name = "labelScanningMode";
            this.labelScanningMode.Size = new System.Drawing.Size(277, 29);
            this.labelScanningMode.TabIndex = 7;
            this.labelScanningMode.Text = "Wybierz tryb skanowania";
            // 
            // labelScanningContrast
            // 
            this.labelScanningContrast.AutoSize = true;
            this.labelScanningContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningContrast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelScanningContrast.Location = new System.Drawing.Point(26, 425);
            this.labelScanningContrast.Name = "labelScanningContrast";
            this.labelScanningContrast.Size = new System.Drawing.Size(101, 29);
            this.labelScanningContrast.TabIndex = 8;
            this.labelScanningContrast.Text = "Kontrast";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResolution.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelResolution.Location = new System.Drawing.Point(27, 558);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(167, 29);
            this.labelResolution.TabIndex = 9;
            this.labelResolution.Text = "Rozdzielczość";
            // 
            // comboBoxScanningMode
            // 
            this.comboBoxScanningMode.FormattingEnabled = true;
            this.comboBoxScanningMode.Location = new System.Drawing.Point(31, 203);
            this.comboBoxScanningMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxScanningMode.Name = "comboBoxScanningMode";
            this.comboBoxScanningMode.Size = new System.Drawing.Size(288, 24);
            this.comboBoxScanningMode.TabIndex = 10;
            this.comboBoxScanningMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxScanningMode_SelectedIndexChanged);
            // 
            // textBoxScanningContrast
            // 
            this.textBoxScanningContrast.Location = new System.Drawing.Point(210, 430);
            this.textBoxScanningContrast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScanningContrast.Name = "textBoxScanningContrast";
            this.textBoxScanningContrast.Size = new System.Drawing.Size(145, 22);
            this.textBoxScanningContrast.TabIndex = 11;
            this.textBoxScanningContrast.TextChanged += new System.EventHandler(this.textBoxScanningContrast_TextChanged);
            // 
            // textBoxScanningResolution
            // 
            this.textBoxScanningResolution.Location = new System.Drawing.Point(207, 558);
            this.textBoxScanningResolution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScanningResolution.Name = "textBoxScanningResolution";
            this.textBoxScanningResolution.Size = new System.Drawing.Size(145, 22);
            this.textBoxScanningResolution.TabIndex = 12;
            this.textBoxScanningResolution.TextChanged += new System.EventHandler(this.textBoxScanningResolution_TextChanged);
            // 
            // trackBarScanningContrast
            // 
            this.trackBarScanningContrast.LargeChange = 1;
            this.trackBarScanningContrast.Location = new System.Drawing.Point(30, 469);
            this.trackBarScanningContrast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarScanningContrast.Name = "trackBarScanningContrast";
            this.trackBarScanningContrast.Size = new System.Drawing.Size(325, 56);
            this.trackBarScanningContrast.TabIndex = 13;
            this.trackBarScanningContrast.Scroll += new System.EventHandler(this.trackBarScanningContrast_Scroll);
            // 
            // trackBarSetScanningResolution
            // 
            this.trackBarSetScanningResolution.LargeChange = 10;
            this.trackBarSetScanningResolution.Location = new System.Drawing.Point(31, 598);
            this.trackBarSetScanningResolution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarSetScanningResolution.Maximum = 2400;
            this.trackBarSetScanningResolution.Name = "trackBarSetScanningResolution";
            this.trackBarSetScanningResolution.Size = new System.Drawing.Size(322, 56);
            this.trackBarSetScanningResolution.TabIndex = 14;
            this.trackBarSetScanningResolution.Scroll += new System.EventHandler(this.trackBarSetScanningResolution_Scroll);
            // 
            // labelScanningBrightness
            // 
            this.labelScanningBrightness.AutoSize = true;
            this.labelScanningBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningBrightness.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScanningBrightness.Location = new System.Drawing.Point(25, 290);
            this.labelScanningBrightness.Name = "labelScanningBrightness";
            this.labelScanningBrightness.Size = new System.Drawing.Size(101, 29);
            this.labelScanningBrightness.TabIndex = 15;
            this.labelScanningBrightness.Text = "Jasność";
            // 
            // textBoxScanningBrightness
            // 
            this.textBoxScanningBrightness.Location = new System.Drawing.Point(207, 290);
            this.textBoxScanningBrightness.Name = "textBoxScanningBrightness";
            this.textBoxScanningBrightness.Size = new System.Drawing.Size(148, 22);
            this.textBoxScanningBrightness.TabIndex = 16;
            this.textBoxScanningBrightness.TextChanged += new System.EventHandler(this.textBoxScanningBrightness_TextChanged);
            // 
            // trackBarScanningBrightness
            // 
            this.trackBarScanningBrightness.LargeChange = 1;
            this.trackBarScanningBrightness.Location = new System.Drawing.Point(30, 344);
            this.trackBarScanningBrightness.Name = "trackBarScanningBrightness";
            this.trackBarScanningBrightness.Size = new System.Drawing.Size(322, 56);
            this.trackBarScanningBrightness.TabIndex = 17;
            this.trackBarScanningBrightness.Scroll += new System.EventHandler(this.trackBarScanningBrightness_Scroll);
            // 
            // trackBarScanningWidth
            // 
            this.trackBarScanningWidth.LargeChange = 1;
            this.trackBarScanningWidth.Location = new System.Drawing.Point(472, 344);
            this.trackBarScanningWidth.Name = "trackBarScanningWidth";
            this.trackBarScanningWidth.Size = new System.Drawing.Size(322, 56);
            this.trackBarScanningWidth.TabIndex = 23;
            this.trackBarScanningWidth.Scroll += new System.EventHandler(this.trackBarScanningWidth_Scroll);
            // 
            // textBoxScanningWidth
            // 
            this.textBoxScanningWidth.Location = new System.Drawing.Point(649, 290);
            this.textBoxScanningWidth.Name = "textBoxScanningWidth";
            this.textBoxScanningWidth.Size = new System.Drawing.Size(148, 22);
            this.textBoxScanningWidth.TabIndex = 22;
            this.textBoxScanningWidth.TextChanged += new System.EventHandler(this.textBoxScanningWidth_TextChanged);
            // 
            // labelScanningWidth
            // 
            this.labelScanningWidth.AutoSize = true;
            this.labelScanningWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningWidth.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScanningWidth.Location = new System.Drawing.Point(467, 290);
            this.labelScanningWidth.Name = "labelScanningWidth";
            this.labelScanningWidth.Size = new System.Drawing.Size(126, 29);
            this.labelScanningWidth.TabIndex = 21;
            this.labelScanningWidth.Text = "Szerokość";
            // 
            // trackBarScanningHeight
            // 
            this.trackBarScanningHeight.LargeChange = 1;
            this.trackBarScanningHeight.Location = new System.Drawing.Point(472, 469);
            this.trackBarScanningHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarScanningHeight.Name = "trackBarScanningHeight";
            this.trackBarScanningHeight.Size = new System.Drawing.Size(325, 56);
            this.trackBarScanningHeight.TabIndex = 20;
            this.trackBarScanningHeight.Scroll += new System.EventHandler(this.trackBarScanningHeight_Scroll);
            // 
            // textBoxScanningHeight
            // 
            this.textBoxScanningHeight.Location = new System.Drawing.Point(652, 430);
            this.textBoxScanningHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScanningHeight.Name = "textBoxScanningHeight";
            this.textBoxScanningHeight.Size = new System.Drawing.Size(145, 22);
            this.textBoxScanningHeight.TabIndex = 19;
            this.textBoxScanningHeight.TextChanged += new System.EventHandler(this.textBoxScanningHeight_TextChanged);
            // 
            // labelScanningHeight
            // 
            this.labelScanningHeight.AutoSize = true;
            this.labelScanningHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningHeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelScanningHeight.Location = new System.Drawing.Point(468, 425);
            this.labelScanningHeight.Name = "labelScanningHeight";
            this.labelScanningHeight.Size = new System.Drawing.Size(122, 29);
            this.labelScanningHeight.TabIndex = 18;
            this.labelScanningHeight.Text = "Wysokość";
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1428, 811);
            this.Controls.Add(this.trackBarScanningWidth);
            this.Controls.Add(this.textBoxScanningWidth);
            this.Controls.Add(this.labelScanningWidth);
            this.Controls.Add(this.trackBarScanningHeight);
            this.Controls.Add(this.textBoxScanningHeight);
            this.Controls.Add(this.labelScanningHeight);
            this.Controls.Add(this.trackBarScanningBrightness);
            this.Controls.Add(this.textBoxScanningBrightness);
            this.Controls.Add(this.labelScanningBrightness);
            this.Controls.Add(this.trackBarSetScanningResolution);
            this.Controls.Add(this.trackBarScanningContrast);
            this.Controls.Add(this.textBoxScanningResolution);
            this.Controls.Add(this.textBoxScanningContrast);
            this.Controls.Add(this.comboBoxScanningMode);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelScanningContrast);
            this.Controls.Add(this.labelScanningMode);
            this.Controls.Add(this.buttonSelectFileDirectory);
            this.Controls.Add(this.buttonStartScanning);
            this.Controls.Add(this.buttonCheckForAvailableScanners);
            this.Controls.Add(this.comboBoxAvailableScanners);
            this.Controls.Add(this.pictureBoxScannedDocument);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScannedDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetScanningResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScannedDocument;
        private System.Windows.Forms.ComboBox comboBoxAvailableScanners;
        private System.Windows.Forms.Button buttonCheckForAvailableScanners;
        private System.Windows.Forms.Button buttonStartScanning;
        private System.Windows.Forms.Button buttonSelectFileDirectory;
        private System.Windows.Forms.Label labelScanningMode;
        private System.Windows.Forms.Label labelScanningContrast;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.ComboBox comboBoxScanningMode;
        private System.Windows.Forms.TextBox textBoxScanningContrast;
        private System.Windows.Forms.TextBox textBoxScanningResolution;
        private System.Windows.Forms.TrackBar trackBarScanningContrast;
        private System.Windows.Forms.TrackBar trackBarSetScanningResolution;
        private System.Windows.Forms.Label labelScanningBrightness;
        private System.Windows.Forms.TextBox textBoxScanningBrightness;
        private System.Windows.Forms.TrackBar trackBarScanningBrightness;
        private System.Windows.Forms.TrackBar trackBarScanningWidth;
        private System.Windows.Forms.TextBox textBoxScanningWidth;
        private System.Windows.Forms.Label labelScanningWidth;
        private System.Windows.Forms.TrackBar trackBarScanningHeight;
        private System.Windows.Forms.TextBox textBoxScanningHeight;
        private System.Windows.Forms.Label labelScanningHeight;
    }
}

