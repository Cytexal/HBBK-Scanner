using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBBK_Scanner
{
    public partial class Main : System.Windows.Forms.Form
    {

        List<string> imagepaths = new List<string>();
        Dictionary<string, string> nametopath = new Dictionary<string, string>();
        Point path_Label;


        //Image.FromFile(nametopath[listBox1.SelectedItem.ToString()]);

        public Main()
        {
            InitializeComponent();
            Variablen.input = true;
        }

        public void RefreshImages()
        {
            imagepaths.Clear();
            try
            {
                imagepaths = ImageUtils.getImagesinFolder(@"" + Variablen.path);


            String firstpath = "";

            foreach (String path in imagepaths)
            {
                if (!nametopath.ContainsKey(ImageUtils.getImageName(path)))
                {
                    if (Image.FromFile(path).Width >= Image.FromFile(path).Height)
                    {

                    }
                    else
                    {
                        if(firstpath == "")
                        {
                            firstpath = path;
                        }
                        nametopath.Add(ImageUtils.getImageName(path), path);
                        PictureBox image = new PictureBox();
                        image.Width = 125;
                        image.Height = 175;
                        image.SizeMode = PictureBoxSizeMode.StretchImage;
                        image.Name = "" + ImageUtils.getImageName(path);
                        image.Visible = true;
                        image.Image = Image.FromFile(path);
                        image.Click += Image_Click;

                        Bilder_Anzeige.Controls.Add(image);
                    }
                }
            }


            Variablen.preview_image_path = firstpath;
            Double factor = Convert.ToDouble(Image.FromFile(Variablen.preview_image_path).Width) / Image.FromFile(Variablen.preview_image_path).Height;
            Image_Preview.Size = new Size(Convert.ToInt32(Image_Preview.Height * factor), Image_Preview.Height);
            Image_Preview.Image = Image.FromFile(Variablen.preview_image_path);
            Label_DName.Location = new Point(Image_Preview.Size.Width, Label_DName.Location.Y);
            Label_BBreite.Location = new Point(Image_Preview.Size.Width, Label_BBreite.Location.Y);
            Label_BHöhe.Location = new Point(Image_Preview.Size.Width, Label_BHöhe.Location.Y);
            Button_Bearbeiten.Location = new Point(Image_Preview.Size.Width + 8,Button_Bearbeiten.Location.Y);
            Button_Löschen.Location = new Point(Image_Preview.Size.Width + 8, Button_Löschen.Location.Y);
            Label_DName.Text = "Datei-Name: " + ImageUtils.getImageName(firstpath);
            Label_BBreite.Text = "Bild-Breite: " + Image_Preview.Image.Width + " px";
            Label_BHöhe.Text = "Bild-Höhe: " + Image_Preview.Image.Height + " px";
            Label_BPfad.Text = "Pfad: " + firstpath;
            }
            catch
            {
                MessageBox.Show("Fehler: Dialog geschlossen"); //MUSS NOCH NE ALTERNATIVE PROGRAMIERT WERDEN 
            }

        }

        private void Image_Click(object sender, EventArgs e)
        {
            Variablen.preview_image_path = nametopath[((PictureBox)sender).Name];
            Double factor = Convert.ToDouble(Image.FromFile(Variablen.preview_image_path).Width) / Image.FromFile(Variablen.preview_image_path).Height;
            Image_Preview.Size = new Size(Convert.ToInt32(Image_Preview.Height * factor), Image_Preview.Height);
            Image_Preview.Image = Image.FromFile(Variablen.preview_image_path);
            Label_DName.Location = new Point(Image_Preview.Size.Width, Label_DName.Location.Y);
            Label_BBreite.Location = new Point(Image_Preview.Size.Width, Label_BBreite.Location.Y);
            Label_BHöhe.Location = new Point(Image_Preview.Size.Width, Label_BHöhe.Location.Y);
            Label_DName.Text = "Datei-Name: " + ((PictureBox)sender).Name;
            Button_Bearbeiten.Location = new Point(Image_Preview.Size.Width + 8, Button_Bearbeiten.Location.Y);
            Button_Löschen.Location = new Point(Image_Preview.Size.Width + 8, Button_Löschen.Location.Y);
            Label_BBreite.Text = "Bild-Breite: " + Image_Preview.Image.Width + " px";
            Label_BHöhe.Text = "Bild-Höhe: "+ Image_Preview.Image.Height + " px";
            Label_BPfad.Text = "Pfad: " + nametopath[((PictureBox)sender).Name];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Label_Willkommen.Location = new Point(this.Width/2 - Label_Willkommen.Width/2,this.Height/2 - 100);
            Button_Directory.Location = new Point(this.Width / 2 - Button_Directory.Width/2, this.Height / 2);
            path_Label = Label_Verzeichnis.Location;
        }

        private void Button_Directory_Click(object sender, EventArgs e)
        {
            Image_Directionary.ShowDialog();
            Variablen.path = Image_Directionary.SelectedPath;
            Label_Willkommen.Hide();

            Label_Verzeichnis.Text = "Verzeichnis: " + Variablen.path;
            Label_Verzeichnis.Location = new Point(path_Label.X - Label_Verzeichnis.Size.Width, Label_Verzeichnis.Location.Y);
            Label_Verzeichnis.Show();

            Label_Speicherort.Text = "Speicherort: Kein Verzeichnis ausgewählt";
            Label_Speicherort.Location = new Point(path_Label.X - Label_Speicherort.Size.Width, Label_Speicherort.Location.Y);
            Label_Speicherort.Show();

            buttonChooseDirectory.Location = new Point(Label_Verzeichnis.Location.X - buttonChooseDirectory.Size.Width - 5,buttonChooseDirectory.Location.Y);
            buttonChooseDirectory.Show();

            buttonChooseSaveDirectory.Location = new Point(Label_Speicherort.Location.X - buttonChooseSaveDirectory.Size.Width - 5, buttonChooseSaveDirectory.Location.Y);
            buttonChooseSaveDirectory.Show();

            Label_noDirectory.Location = new Point(path_Label.X - Label_noDirectory.Size.Width, Label_noDirectory.Location.Y);
            Label_noDirectory.Show();


            Bilder_Anzeige.Show();
            Button_Directory.Hide();
            RefreshImages();
            Tool_Panel.Show();
            Image_Preview.Show();
            

        }

        private void timer_focus_Tick(object sender, EventArgs e)
        {
            TextBoxID.Select();
        }

        private void TB_Hidden_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button_Bearbeiten_Click(object sender, EventArgs e)
        {
        }

        private void buttonChooseSaveDirectory_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSaveDirectory.ShowDialog();
            Variablen.SavePath = folderBrowserDialogSaveDirectory.SelectedPath;
            Label_Speicherort.Text = "Verzeichnis: " + Variablen.SavePath + @"\";
            Label_Speicherort.Location = new Point(path_Label.X - Label_Speicherort.Size.Width, Label_Speicherort.Location.Y);
            buttonChooseSaveDirectory.Location = new Point(Label_Speicherort.Location.X - buttonChooseSaveDirectory.Width - 10, buttonChooseSaveDirectory.Location.Y);
            Label_noDirectory.Hide();
        }

        private void buttonChooseDirectory_Click(object sender, EventArgs e)
        {
            Image_Directionary.ShowDialog();
            Variablen.path = Image_Directionary.SelectedPath;
            Label_Verzeichnis.Text = "Verzeichnis: " + Variablen.path + @"\";
            Label_Verzeichnis.Location = new Point(path_Label.X - Label_Verzeichnis.Size.Width, Label_Verzeichnis.Location.Y);
            buttonChooseDirectory.Location = new Point(Label_Verzeichnis.Location.X - buttonChooseDirectory.Width -10, buttonChooseDirectory.Location.Y);
        }

        private void TextBox_Hidden_KeyPress(object sender, KeyPressEventArgs e)
        {
            timerSave.Enabled = false;
            timerSave.Enabled = true;
            e.Handled = true;
        }
        private void timerSave_Tick(object sender, EventArgs e)
        {
            timerSave.Enabled = false;
            //Save
            if (Variablen.SavePath != null)
            {
                try
                {
                    Image img = Image.FromFile(Variablen.preview_image_path);
                    Bitmap bmp = new Bitmap(img, 100, 150);
                    img = bmp;
                    img.Save(Variablen.SavePath + @"\" + TextBoxID.Text + ".jpg");
                    TextBoxID.Text = "";

                }
                catch
                {

                }
            }
            else
            {
                TextBoxID.Text = "";
                buttonChooseSaveDirectory_Click(sender, e);
            }          
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            timerSave.Enabled = false;
            timerSave.Enabled = true;
        }
    }
}
