namespace HBBK_Scanner
{
    partial class BildBearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BildBearbeiten));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxEdit = new System.Windows.Forms.PictureBox();
            this.ButtonBestätigen = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(402, 527);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 44);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEdit
            // 
            this.pictureBoxEdit.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxEdit.Name = "pictureBoxEdit";
            this.pictureBoxEdit.Size = new System.Drawing.Size(382, 558);
            this.pictureBoxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdit.TabIndex = 2;
            this.pictureBoxEdit.TabStop = false;
            // 
            // ButtonBestätigen
            // 
            this.ButtonBestätigen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonBestätigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonBestätigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBestätigen.BorderRadius = 0;
            this.ButtonBestätigen.ButtonText = "Bestätigen";
            this.ButtonBestätigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBestätigen.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonBestätigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBestätigen.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonBestätigen.Iconimage = ((System.Drawing.Image)(resources.GetObject("ButtonBestätigen.Iconimage")));
            this.ButtonBestätigen.Iconimage_right = null;
            this.ButtonBestätigen.Iconimage_right_Selected = null;
            this.ButtonBestätigen.Iconimage_Selected = null;
            this.ButtonBestätigen.IconMarginLeft = 0;
            this.ButtonBestätigen.IconMarginRight = 0;
            this.ButtonBestätigen.IconRightVisible = true;
            this.ButtonBestätigen.IconRightZoom = 0D;
            this.ButtonBestätigen.IconVisible = true;
            this.ButtonBestätigen.IconZoom = 90D;
            this.ButtonBestätigen.IsTab = false;
            this.ButtonBestätigen.Location = new System.Drawing.Point(544, 527);
            this.ButtonBestätigen.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBestätigen.Name = "ButtonBestätigen";
            this.ButtonBestätigen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ButtonBestätigen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ButtonBestätigen.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonBestätigen.selected = false;
            this.ButtonBestätigen.Size = new System.Drawing.Size(136, 44);
            this.ButtonBestätigen.TabIndex = 3;
            this.ButtonBestätigen.Text = "Bestätigen";
            this.ButtonBestätigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBestätigen.Textcolor = System.Drawing.Color.White;
            this.ButtonBestätigen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BildBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 583);
            this.Controls.Add(this.ButtonBestätigen);
            this.Controls.Add(this.pictureBoxEdit);
            this.Controls.Add(this.buttonCancel);
            this.Name = "BildBearbeiten";
            this.Text = "HBBK | Bildeditor";
            this.Load += new System.EventHandler(this.BildBearbeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxEdit;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonBestätigen;
    }
}