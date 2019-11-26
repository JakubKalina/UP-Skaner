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
            this.buttonSetScannerOptions = new System.Windows.Forms.Button();
            this.labelScanningMode = new System.Windows.Forms.Label();
            this.labelScanningContrast = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.comboBoxScanningMode = new System.Windows.Forms.ComboBox();
            this.textBoxScanningContrast = new System.Windows.Forms.TextBox();
            this.textBoxScanningResolution = new System.Windows.Forms.TextBox();
            this.trackBarScanningContrast = new System.Windows.Forms.TrackBar();
            this.trackBarSetScanningResolution = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScannedDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetScanningResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScannedDocument
            // 
            this.pictureBoxScannedDocument.Location = new System.Drawing.Point(761, 12);
            this.pictureBoxScannedDocument.Name = "pictureBoxScannedDocument";
            this.pictureBoxScannedDocument.Size = new System.Drawing.Size(630, 891);
            this.pictureBoxScannedDocument.TabIndex = 0;
            this.pictureBoxScannedDocument.TabStop = false;
            // 
            // comboBoxAvailableScanners
            // 
            this.comboBoxAvailableScanners.FormattingEnabled = true;
            this.comboBoxAvailableScanners.Location = new System.Drawing.Point(12, 67);
            this.comboBoxAvailableScanners.Name = "comboBoxAvailableScanners";
            this.comboBoxAvailableScanners.Size = new System.Drawing.Size(301, 28);
            this.comboBoxAvailableScanners.TabIndex = 1;
            this.comboBoxAvailableScanners.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailableScanners_SelectedIndexChanged);
            // 
            // buttonCheckForAvailableScanners
            // 
            this.buttonCheckForAvailableScanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCheckForAvailableScanners.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonCheckForAvailableScanners.Location = new System.Drawing.Point(12, 12);
            this.buttonCheckForAvailableScanners.Name = "buttonCheckForAvailableScanners";
            this.buttonCheckForAvailableScanners.Size = new System.Drawing.Size(301, 39);
            this.buttonCheckForAvailableScanners.TabIndex = 2;
            this.buttonCheckForAvailableScanners.Text = "Wyszukaj skanery";
            this.buttonCheckForAvailableScanners.UseVisualStyleBackColor = true;
            this.buttonCheckForAvailableScanners.Click += new System.EventHandler(this.buttonCheckForAvailableScanners_Click);
            // 
            // buttonStartScanning
            // 
            this.buttonStartScanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartScanning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonStartScanning.Location = new System.Drawing.Point(16, 886);
            this.buttonStartScanning.Name = "buttonStartScanning";
            this.buttonStartScanning.Size = new System.Drawing.Size(722, 87);
            this.buttonStartScanning.TabIndex = 3;
            this.buttonStartScanning.Text = "Rozpocznij skanowanie";
            this.buttonStartScanning.UseVisualStyleBackColor = true;
            this.buttonStartScanning.Click += new System.EventHandler(this.buttonStartScanning_Click);
            // 
            // buttonSelectFileDirectory
            // 
            this.buttonSelectFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSelectFileDirectory.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSelectFileDirectory.Location = new System.Drawing.Point(940, 934);
            this.buttonSelectFileDirectory.Name = "buttonSelectFileDirectory";
            this.buttonSelectFileDirectory.Size = new System.Drawing.Size(301, 39);
            this.buttonSelectFileDirectory.TabIndex = 4;
            this.buttonSelectFileDirectory.Text = "Zapisz jako";
            this.buttonSelectFileDirectory.UseVisualStyleBackColor = true;
            // 
            // buttonSetScannerOptions
            // 
            this.buttonSetScannerOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSetScannerOptions.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSetScannerOptions.Location = new System.Drawing.Point(204, 171);
            this.buttonSetScannerOptions.Name = "buttonSetScannerOptions";
            this.buttonSetScannerOptions.Size = new System.Drawing.Size(301, 39);
            this.buttonSetScannerOptions.TabIndex = 6;
            this.buttonSetScannerOptions.Text = "Ustawienia skanera";
            this.buttonSetScannerOptions.UseVisualStyleBackColor = true;
            this.buttonSetScannerOptions.Click += new System.EventHandler(this.buttonSetScannerOptions_Click);
            // 
            // labelScanningMode
            // 
            this.labelScanningMode.AutoSize = true;
            this.labelScanningMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningMode.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelScanningMode.Location = new System.Drawing.Point(198, 279);
            this.labelScanningMode.Name = "labelScanningMode";
            this.labelScanningMode.Size = new System.Drawing.Size(329, 32);
            this.labelScanningMode.TabIndex = 7;
            this.labelScanningMode.Text = "Wybierz tryb skanowania";
            // 
            // labelScanningContrast
            // 
            this.labelScanningContrast.AutoSize = true;
            this.labelScanningContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScanningContrast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelScanningContrast.Location = new System.Drawing.Point(176, 467);
            this.labelScanningContrast.Name = "labelScanningContrast";
            this.labelScanningContrast.Size = new System.Drawing.Size(121, 32);
            this.labelScanningContrast.TabIndex = 8;
            this.labelScanningContrast.Text = "Kontrast";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResolution.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelResolution.Location = new System.Drawing.Point(180, 695);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(197, 32);
            this.labelResolution.TabIndex = 9;
            this.labelResolution.Text = "Rozdzielczość";
            // 
            // comboBoxScanningMode
            // 
            this.comboBoxScanningMode.FormattingEnabled = true;
            this.comboBoxScanningMode.Location = new System.Drawing.Point(204, 341);
            this.comboBoxScanningMode.Name = "comboBoxScanningMode";
            this.comboBoxScanningMode.Size = new System.Drawing.Size(323, 28);
            this.comboBoxScanningMode.TabIndex = 10;
            // 
            // textBoxScanningContrast
            // 
            this.textBoxScanningContrast.Location = new System.Drawing.Point(383, 474);
            this.textBoxScanningContrast.Name = "textBoxScanningContrast";
            this.textBoxScanningContrast.Size = new System.Drawing.Size(163, 26);
            this.textBoxScanningContrast.TabIndex = 11;
            this.textBoxScanningContrast.TextChanged += new System.EventHandler(this.textBoxScanningContrast_TextChanged);
            // 
            // textBoxScanningResolution
            // 
            this.textBoxScanningResolution.Location = new System.Drawing.Point(383, 695);
            this.textBoxScanningResolution.Name = "textBoxScanningResolution";
            this.textBoxScanningResolution.Size = new System.Drawing.Size(163, 26);
            this.textBoxScanningResolution.TabIndex = 12;
            this.textBoxScanningResolution.TextChanged += new System.EventHandler(this.textBoxScanningResolution_TextChanged);
            // 
            // trackBarScanningContrast
            // 
            this.trackBarScanningContrast.LargeChange = 1;
            this.trackBarScanningContrast.Location = new System.Drawing.Point(180, 523);
            this.trackBarScanningContrast.Name = "trackBarScanningContrast";
            this.trackBarScanningContrast.Size = new System.Drawing.Size(366, 69);
            this.trackBarScanningContrast.TabIndex = 13;
            this.trackBarScanningContrast.Scroll += new System.EventHandler(this.trackBarScanningContrast_Scroll);
            // 
            // trackBarSetScanningResolution
            // 
            this.trackBarSetScanningResolution.LargeChange = 10;
            this.trackBarSetScanningResolution.Location = new System.Drawing.Point(184, 745);
            this.trackBarSetScanningResolution.Maximum = 2400;
            this.trackBarSetScanningResolution.Name = "trackBarSetScanningResolution";
            this.trackBarSetScanningResolution.Size = new System.Drawing.Size(362, 69);
            this.trackBarSetScanningResolution.TabIndex = 14;
            this.trackBarSetScanningResolution.Scroll += new System.EventHandler(this.trackBarSetScanningResolution_Scroll);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1442, 1014);
            this.Controls.Add(this.trackBarSetScanningResolution);
            this.Controls.Add(this.trackBarScanningContrast);
            this.Controls.Add(this.textBoxScanningResolution);
            this.Controls.Add(this.textBoxScanningContrast);
            this.Controls.Add(this.comboBoxScanningMode);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelScanningContrast);
            this.Controls.Add(this.labelScanningMode);
            this.Controls.Add(this.buttonSetScannerOptions);
            this.Controls.Add(this.buttonSelectFileDirectory);
            this.Controls.Add(this.buttonStartScanning);
            this.Controls.Add(this.buttonCheckForAvailableScanners);
            this.Controls.Add(this.comboBoxAvailableScanners);
            this.Controls.Add(this.pictureBoxScannedDocument);
            this.Name = "Scanner";
            this.Text = "Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScannedDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScanningContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSetScanningResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScannedDocument;
        private System.Windows.Forms.ComboBox comboBoxAvailableScanners;
        private System.Windows.Forms.Button buttonCheckForAvailableScanners;
        private System.Windows.Forms.Button buttonStartScanning;
        private System.Windows.Forms.Button buttonSelectFileDirectory;
        private System.Windows.Forms.Button buttonSetScannerOptions;
        private System.Windows.Forms.Label labelScanningMode;
        private System.Windows.Forms.Label labelScanningContrast;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.ComboBox comboBoxScanningMode;
        private System.Windows.Forms.TextBox textBoxScanningContrast;
        private System.Windows.Forms.TextBox textBoxScanningResolution;
        private System.Windows.Forms.TrackBar trackBarScanningContrast;
        private System.Windows.Forms.TrackBar trackBarSetScanningResolution;
    }
}

