namespace HBBK_Scanner
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Label_Willkommen = new MonoFlat.Class1.MonoFlat_Label();
            this.Image_Directionary = new System.Windows.Forms.FolderBrowserDialog();
            this.monoFlat_Label1 = new MonoFlat.Class1.MonoFlat_Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Directory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Label_Verzeichnis = new MonoFlat.Class1.MonoFlat_Label();
            this.Bilder_Anzeige = new System.Windows.Forms.FlowLayoutPanel();
            this.Tool_Panel = new System.Windows.Forms.Panel();
            this.TB_Hidden = new System.Windows.Forms.TextBox();
            this.monoFlat_Label2 = new MonoFlat.Class1.MonoFlat_Label();
            this.Button_Bearbeiten = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Label_BHöhe = new System.Windows.Forms.Label();
            this.Label_BBreite = new System.Windows.Forms.Label();
            this.Label_BPfad = new System.Windows.Forms.Label();
            this.Label_DName = new System.Windows.Forms.Label();
            this.Image_Preview = new System.Windows.Forms.PictureBox();
            this.timer_focus = new System.Windows.Forms.Timer(this.components);
            this.Button_Löschen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Label_Speicherort = new MonoFlat.Class1.MonoFlat_Label();
            this.buttonChooseDirectory = new System.Windows.Forms.Button();
            this.buttonChooseSaveDirectory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Tool_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Willkommen
            // 
            this.Label_Willkommen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Willkommen.AutoSize = true;
            this.Label_Willkommen.BackColor = System.Drawing.Color.Transparent;
            this.Label_Willkommen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Willkommen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Label_Willkommen.Location = new System.Drawing.Point(400, 307);
            this.Label_Willkommen.Name = "Label_Willkommen";
            this.Label_Willkommen.Size = new System.Drawing.Size(303, 50);
            this.Label_Willkommen.TabIndex = 1;
            this.Label_Willkommen.Text = "      Willkommen, bitte wähle \r\nein Verzeichnis mit deinen Bildern.\r\n";
            // 
            // Image_Directionary
            // 
            this.Image_Directionary.Description = "Wählen Sie das Verzeichnis mit den Bildern.";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.Gray;
            this.monoFlat_Label1.Location = new System.Drawing.Point(79, 24);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(373, 45);
            this.monoFlat_Label1.TabIndex = 5;
            this.monoFlat_Label1.Text = "HBBK | Schüler Scanner";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HBBK_Scanner.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Directory
            // 
            this.Button_Directory.ActiveBorderThickness = 1;
            this.Button_Directory.ActiveCornerRadius = 20;
            this.Button_Directory.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.Button_Directory.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Directory.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Directory.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Directory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Directory.BackgroundImage")));
            this.Button_Directory.ButtonText = "Verzeichnis wählen";
            this.Button_Directory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Directory.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Directory.IdleBorderThickness = 1;
            this.Button_Directory.IdleCornerRadius = 20;
            this.Button_Directory.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Directory.IdleForecolor = System.Drawing.Color.Honeydew;
            this.Button_Directory.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Directory.Location = new System.Drawing.Point(437, 362);
            this.Button_Directory.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Directory.Name = "Button_Directory";
            this.Button_Directory.Size = new System.Drawing.Size(227, 66);
            this.Button_Directory.TabIndex = 4;
            this.Button_Directory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Directory.Click += new System.EventHandler(this.Button_Directory_Click);
            // 
            // Label_Verzeichnis
            // 
            this.Label_Verzeichnis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Verzeichnis.AutoSize = true;
            this.Label_Verzeichnis.BackColor = System.Drawing.Color.Transparent;
            this.Label_Verzeichnis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Verzeichnis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Label_Verzeichnis.Location = new System.Drawing.Point(1466, 7);
            this.Label_Verzeichnis.Name = "Label_Verzeichnis";
            this.Label_Verzeichnis.Size = new System.Drawing.Size(91, 21);
            this.Label_Verzeichnis.TabIndex = 7;
            this.Label_Verzeichnis.Text = "Verzeichnis:";
            this.Label_Verzeichnis.Visible = false;
            // 
            // Bilder_Anzeige
            // 
            this.Bilder_Anzeige.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Bilder_Anzeige.AutoScroll = true;
            this.Bilder_Anzeige.Location = new System.Drawing.Point(12, 91);
            this.Bilder_Anzeige.Name = "Bilder_Anzeige";
            this.Bilder_Anzeige.Size = new System.Drawing.Size(542, 775);
            this.Bilder_Anzeige.TabIndex = 8;
            this.Bilder_Anzeige.Visible = false;
            // 
            // Tool_Panel
            // 
            this.Tool_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tool_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tool_Panel.Controls.Add(this.Button_Löschen);
            this.Tool_Panel.Controls.Add(this.TB_Hidden);
            this.Tool_Panel.Controls.Add(this.monoFlat_Label2);
            this.Tool_Panel.Controls.Add(this.Button_Bearbeiten);
            this.Tool_Panel.Controls.Add(this.Label_BHöhe);
            this.Tool_Panel.Controls.Add(this.Label_BBreite);
            this.Tool_Panel.Controls.Add(this.Label_BPfad);
            this.Tool_Panel.Controls.Add(this.Label_DName);
            this.Tool_Panel.Controls.Add(this.Image_Preview);
            this.Tool_Panel.Location = new System.Drawing.Point(560, 91);
            this.Tool_Panel.Name = "Tool_Panel";
            this.Tool_Panel.Size = new System.Drawing.Size(901, 775);
            this.Tool_Panel.TabIndex = 9;
            this.Tool_Panel.Visible = false;
            // 
            // TB_Hidden
            // 
            this.TB_Hidden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TB_Hidden.Location = new System.Drawing.Point(10, 688);
            this.TB_Hidden.Name = "TB_Hidden";
            this.TB_Hidden.Size = new System.Drawing.Size(286, 20);
            this.TB_Hidden.TabIndex = 11;
            this.TB_Hidden.TextChanged += new System.EventHandler(this.TB_Hidden_TextChanged);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(534, 474);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(351, 50);
            this.monoFlat_Label2.TabIndex = 10;
            this.monoFlat_Label2.Text = "       Scannen Sie jetzt den Barcode,\r\num das Bild unter seiner ID zu speichern";
            // 
            // Button_Bearbeiten
            // 
            this.Button_Bearbeiten.ActiveBorderThickness = 1;
            this.Button_Bearbeiten.ActiveCornerRadius = 20;
            this.Button_Bearbeiten.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.Button_Bearbeiten.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Bearbeiten.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Bearbeiten.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Bearbeiten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Bearbeiten.BackgroundImage")));
            this.Button_Bearbeiten.ButtonText = "Bild bearbeiten";
            this.Button_Bearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Bearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Bearbeiten.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Bearbeiten.IdleBorderThickness = 1;
            this.Button_Bearbeiten.IdleCornerRadius = 20;
            this.Button_Bearbeiten.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Bearbeiten.IdleForecolor = System.Drawing.Color.Honeydew;
            this.Button_Bearbeiten.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Bearbeiten.Location = new System.Drawing.Point(508, 316);
            this.Button_Bearbeiten.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Bearbeiten.Name = "Button_Bearbeiten";
            this.Button_Bearbeiten.Size = new System.Drawing.Size(227, 66);
            this.Button_Bearbeiten.TabIndex = 10;
            this.Button_Bearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Bearbeiten.Click += new System.EventHandler(this.Button_Bearbeiten_Click);
            // 
            // Label_BHöhe
            // 
            this.Label_BHöhe.AutoSize = true;
            this.Label_BHöhe.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BHöhe.Location = new System.Drawing.Point(501, 234);
            this.Label_BHöhe.Name = "Label_BHöhe";
            this.Label_BHöhe.Size = new System.Drawing.Size(137, 37);
            this.Label_BHöhe.TabIndex = 4;
            this.Label_BHöhe.Text = "Bild-Höhe:";
            // 
            // Label_BBreite
            // 
            this.Label_BBreite.AutoSize = true;
            this.Label_BBreite.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BBreite.Location = new System.Drawing.Point(501, 169);
            this.Label_BBreite.Name = "Label_BBreite";
            this.Label_BBreite.Size = new System.Drawing.Size(141, 37);
            this.Label_BBreite.TabIndex = 3;
            this.Label_BBreite.Text = "Bild-Breite:";
            // 
            // Label_BPfad
            // 
            this.Label_BPfad.AutoSize = true;
            this.Label_BPfad.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BPfad.Location = new System.Drawing.Point(3, 711);
            this.Label_BPfad.Name = "Label_BPfad";
            this.Label_BPfad.Size = new System.Drawing.Size(73, 37);
            this.Label_BPfad.TabIndex = 2;
            this.Label_BPfad.Text = "Pfad:";
            // 
            // Label_DName
            // 
            this.Label_DName.AutoSize = true;
            this.Label_DName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DName.Location = new System.Drawing.Point(501, 14);
            this.Label_DName.Name = "Label_DName";
            this.Label_DName.Size = new System.Drawing.Size(161, 37);
            this.Label_DName.TabIndex = 1;
            this.Label_DName.Text = "Datei-Name:";
            // 
            // Image_Preview
            // 
            this.Image_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image_Preview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Image_Preview.Location = new System.Drawing.Point(-1, -1);
            this.Image_Preview.Name = "Image_Preview";
            this.Image_Preview.Size = new System.Drawing.Size(495, 681);
            this.Image_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_Preview.TabIndex = 0;
            this.Image_Preview.TabStop = false;
            this.Image_Preview.Visible = false;
            // 
            // timer_focus
            // 
            this.timer_focus.Enabled = true;
            this.timer_focus.Interval = 10;
            this.timer_focus.Tick += new System.EventHandler(this.timer_focus_Tick);
            // 
            // Button_Löschen
            // 
            this.Button_Löschen.ActiveBorderThickness = 1;
            this.Button_Löschen.ActiveCornerRadius = 20;
            this.Button_Löschen.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.Button_Löschen.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.Button_Löschen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Löschen.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Löschen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Löschen.BackgroundImage")));
            this.Button_Löschen.ButtonText = "Bild aus dem Verzeichnis löschen";
            this.Button_Löschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Löschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Löschen.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_Löschen.IdleBorderThickness = 1;
            this.Button_Löschen.IdleCornerRadius = 20;
            this.Button_Löschen.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.Button_Löschen.IdleForecolor = System.Drawing.Color.Honeydew;
            this.Button_Löschen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_Löschen.Location = new System.Drawing.Point(508, 380);
            this.Button_Löschen.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Löschen.Name = "Button_Löschen";
            this.Button_Löschen.Size = new System.Drawing.Size(227, 66);
            this.Button_Löschen.TabIndex = 12;
            this.Button_Löschen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Speicherort
            // 
            this.Label_Speicherort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Speicherort.AutoSize = true;
            this.Label_Speicherort.BackColor = System.Drawing.Color.Transparent;
            this.Label_Speicherort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Speicherort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.Label_Speicherort.Location = new System.Drawing.Point(1466, 33);
            this.Label_Speicherort.Name = "Label_Speicherort";
            this.Label_Speicherort.Size = new System.Drawing.Size(93, 21);
            this.Label_Speicherort.TabIndex = 10;
            this.Label_Speicherort.Text = "Speicherort:";
            this.Label_Speicherort.Visible = false;
            // 
            // buttonChooseDirectory
            // 
            this.buttonChooseDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseDirectory.Location = new System.Drawing.Point(1335, 8);
            this.buttonChooseDirectory.Name = "buttonChooseDirectory";
            this.buttonChooseDirectory.Size = new System.Drawing.Size(126, 23);
            this.buttonChooseDirectory.TabIndex = 11;
            this.buttonChooseDirectory.Text = "Verzeichnis wählen";
            this.buttonChooseDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseDirectory.Visible = false;
            this.buttonChooseDirectory.Click += new System.EventHandler(this.buttonChooseDirectory_Click);
            // 
            // buttonChooseSaveDirectory
            // 
            this.buttonChooseSaveDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseSaveDirectory.Location = new System.Drawing.Point(1335, 34);
            this.buttonChooseSaveDirectory.Name = "buttonChooseSaveDirectory";
            this.buttonChooseSaveDirectory.Size = new System.Drawing.Size(126, 23);
            this.buttonChooseSaveDirectory.TabIndex = 12;
            this.buttonChooseSaveDirectory.Text = "Speicherort wählen";
            this.buttonChooseSaveDirectory.UseVisualStyleBackColor = true;
            this.buttonChooseSaveDirectory.Visible = false;
            this.buttonChooseSaveDirectory.Click += new System.EventHandler(this.buttonChooseSaveDirectory_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 878);
            this.Controls.Add(this.buttonChooseSaveDirectory);
            this.Controls.Add(this.buttonChooseDirectory);
            this.Controls.Add(this.Label_Speicherort);
            this.Controls.Add(this.Tool_Panel);
            this.Controls.Add(this.Bilder_Anzeige);
            this.Controls.Add(this.Label_Verzeichnis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.Button_Directory);
            this.Controls.Add(this.Label_Willkommen);
            this.Name = "Main";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Tool_Panel.ResumeLayout(false);
            this.Tool_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonoFlat.Class1.MonoFlat_Label Label_Willkommen;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Directory;
        private System.Windows.Forms.FolderBrowserDialog Image_Directionary;
        private MonoFlat.Class1.MonoFlat_Label monoFlat_Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MonoFlat.Class1.MonoFlat_Label Label_Verzeichnis;
        private System.Windows.Forms.FlowLayoutPanel Bilder_Anzeige;
        private System.Windows.Forms.Panel Tool_Panel;
        private System.Windows.Forms.PictureBox Image_Preview;
        private System.Windows.Forms.Label Label_DName;
        private System.Windows.Forms.Label Label_BHöhe;
        private System.Windows.Forms.Label Label_BBreite;
        private System.Windows.Forms.Label Label_BPfad;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Bearbeiten;
        private MonoFlat.Class1.MonoFlat_Label monoFlat_Label2;
        private System.Windows.Forms.TextBox TB_Hidden;
        private System.Windows.Forms.Timer timer_focus;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_Löschen;
        private MonoFlat.Class1.MonoFlat_Label Label_Speicherort;
        private System.Windows.Forms.Button buttonChooseDirectory;
        private System.Windows.Forms.Button buttonChooseSaveDirectory;
    }
}

