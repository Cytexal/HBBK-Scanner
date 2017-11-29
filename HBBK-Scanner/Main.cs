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
        String Name;
        String Path;
        int Counter =-8;
        bool autoscrollname = false;
        bool autoscrollpath = false;


        //Image.FromFile(nametopath[listBox1.SelectedItem.ToString()]);

        public Main()
        {
            InitializeComponent();
            Variablen.input = true;
        }

        public void RefreshImages()
        {
            imagepaths.Clear();
            nametopath.Clear();
            Bilder_Anzeige.Controls.Clear();
            try
            {
            imagepaths = ImageUtils.getImagesinFolder(Variablen.path);
            String firstpath = "";

            foreach (String path in imagepaths)
            {
                if (!nametopath.ContainsKey(ImageUtils.getImageName(path)))
                {
                    if (Image.FromFile(path).Width >= Image.FromFile(path).Height)
                    {
                            //imagepaths.Remove(path);
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
                        image.Name = ImageUtils.getImageName(path);
                        image.Visible = true;
                        image.Image = Image.FromFile(path);
                        image.Click += Image_Click;

                        Bilder_Anzeige.Controls.Add(image);
                    }
                }
            }


                UpdatePreviewImage(firstpath);
                LabelNoPics.Hide();
            }
            catch
            {
                Bilder_Anzeige.Controls.Add(LabelNoPics);
                LabelNoPics.Show();
            }
            CheckPics();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            UpdatePreviewImage(nametopath[((PictureBox)sender).Name]);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Label_Willkommen.Location = new Point(this.Width/2 - Label_Willkommen.Width/2,this.Height/2 - 100);
            Button_Start.Location = new Point(this.Width / 2 - Button_Start.Width/2, this.Height / 2);
            path_Label = Label_Verzeichnis.Location;
        }

        private void Button_Directory_Click(object sender, EventArgs e)
        {
            if (Image_Directionary.ShowDialog() == DialogResult.OK)
            {

                Variablen.path = Image_Directionary.SelectedPath;
                Label_Willkommen.Hide();

                Label_Verzeichnis.Text = "Verzeichnis: " + Variablen.path + @"\";
                Label_Verzeichnis.Location = new Point(path_Label.X - Label_Verzeichnis.Size.Width, Label_Verzeichnis.Location.Y);
                Label_Verzeichnis.Show();

                Label_Speicherort.Text = "Speicherort: Kein Verzeichnis ausgewählt";
                Label_Speicherort.Location = new Point(path_Label.X - Label_Speicherort.Size.Width, Label_Speicherort.Location.Y);
                Label_Speicherort.Show();

                buttonChooseDirectory.Location = new Point(Label_Verzeichnis.Location.X - buttonChooseDirectory.Size.Width - 5, buttonChooseDirectory.Location.Y);
                buttonChooseDirectory.Show();

                buttonChooseSaveDirectory.Location = new Point(Label_Speicherort.Location.X - buttonChooseSaveDirectory.Size.Width - 5, buttonChooseSaveDirectory.Location.Y);
                buttonChooseSaveDirectory.Show();

                Label_noDirectory.Location = new Point(path_Label.X - Label_noDirectory.Size.Width, Label_noDirectory.Location.Y);
                Label_noDirectory.Show();

                groupBoxSpeichergröße.Show();

                Bilder_Anzeige.Show();
                Button_Start.Hide();
                RefreshImages();
                Tool_Panel.Show();
                Image_Preview.Show();
            }
        }

        private void timer_focus_Tick(object sender, EventArgs e)
        {
            TextBoxID.Select();
        }

        private void buttonChooseSaveDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSaveDirectory.ShowDialog() == DialogResult.OK)
            {
                Variablen.SavePath = folderBrowserDialogSaveDirectory.SelectedPath;
                Label_Speicherort.Text = "Verzeichnis: " + Variablen.SavePath + @"\";
                Label_Speicherort.Location = new Point(path_Label.X - Label_Speicherort.Size.Width, Label_Speicherort.Location.Y);
                buttonChooseSaveDirectory.Location = new Point(Label_Speicherort.Location.X - buttonChooseSaveDirectory.Width - 10, buttonChooseSaveDirectory.Location.Y);
                Label_noDirectory.Hide();
            }
        }

        private void buttonChooseDirectory_Click(object sender, EventArgs e)
        {
            if (Image_Directionary.ShowDialog() == DialogResult.OK)
            {
                Variablen.path = Image_Directionary.SelectedPath;
                Label_Verzeichnis.Text = "Verzeichnis: " + Variablen.path + @"\";
                Label_Verzeichnis.Location = new Point(path_Label.X - Label_Verzeichnis.Size.Width, Label_Verzeichnis.Location.Y);
                buttonChooseDirectory.Location = new Point(Label_Verzeichnis.Location.X - buttonChooseDirectory.Width - 10, buttonChooseDirectory.Location.Y);
                RefreshImages();
            }
        }

        private void TextBox_Hidden_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private Control GetControlByName(string Name)
        {
            foreach (Control c in Bilder_Anzeige.Controls)
            {
            if (c.Name == Name)
                return c;
            }
            return null;
        }

        public void SaveImage(Image img)
        {
            img.Save(Variablen.SavePath + @"\" + TextBoxID.Text + ".jpg");

            List<String> paths = new List<string>();
            paths.AddRange(nametopath.Values);
            int index = paths.IndexOf(Variablen.preview_image_path);
            if(index+1 == paths.Count)
            {
                nametopath.Remove(ImageUtils.getImageName(paths[index]));
                Bilder_Anzeige.Controls.Remove(GetControlByName(ImageUtils.getImageName(paths[index])));
                if (paths.Count == 1)
                {
                    SetLabel();
                }
                else
                {
                    UpdatePreviewImage(paths[0]);
                }

            }
            else
            {
                UpdatePreviewImage(paths[index+1]);
                nametopath.Remove(ImageUtils.getImageName(paths[index]));
                Bilder_Anzeige.Controls.Remove(GetControlByName(ImageUtils.getImageName(paths[index])));
            }
            
        }


        

        private void Button_Löschen_Click(object sender, EventArgs e)
        {
            string RightNow = Variablen.preview_image_path;
            List<String> paths = new List<string>();
            paths.AddRange(nametopath.Values);
            int index = paths.IndexOf(Variablen.preview_image_path);
            if (index + 1 == paths.Count)
            {
                nametopath.Remove(ImageUtils.getImageName(paths[index]));
                Bilder_Anzeige.Controls.Remove(GetControlByName(ImageUtils.getImageName(paths[index])));
                if (paths.Count == 1)
                {
                    SetLabel();
                }
                else
                {
                    UpdatePreviewImage(paths[0]);
                }

            }
            else
            {
                UpdatePreviewImage(paths[index + 1]);
                nametopath.Remove(ImageUtils.getImageName(paths[index]));
                Bilder_Anzeige.Controls.Remove(GetControlByName(ImageUtils.getImageName(paths[index])));
            }
            try
            {
                File.Delete(RightNow);
            }
            catch
            {

            }
        }

        private void timer_textbox_Tick(object sender, EventArgs e)
        {
            if(TextBoxID.Focused)
            {
                TextBoxID.BackColor = Color.LimeGreen;
            }
            else
            {
                TextBoxID.BackColor = Color.IndianRed;
            }

        }

        private void TextBoxID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartSave();
            }
        }

        private void StartSave()
        {
            if (Variablen.SavePath != null)
            {
                Save();
            }
            else
            {
                if (folderBrowserDialogSaveDirectory.ShowDialog() == DialogResult.OK)
                {
                    Variablen.SavePath = folderBrowserDialogSaveDirectory.SelectedPath;
                    Variablen.SavePath = folderBrowserDialogSaveDirectory.SelectedPath;
                    Label_Speicherort.Text = "Verzeichnis: " + Variablen.SavePath + @"\";
                    Label_Speicherort.Location = new Point(path_Label.X - Label_Speicherort.Size.Width, Label_Speicherort.Location.Y);

                    buttonChooseSaveDirectory.Location = new Point(Label_Speicherort.Location.X - buttonChooseSaveDirectory.Width - 10, buttonChooseSaveDirectory.Location.Y);
                    Label_noDirectory.Hide();
                    Label_Speicherort.Text = "Verzeichnis: " + Variablen.SavePath + @"\";

                    Save();
                }

            }
        }

        private void Save()
        {
            try
            {
                Image img = Image.FromFile(Variablen.preview_image_path);
                Bitmap bmp = new Bitmap(img, Convert.ToInt32(numericUpDownSaveWidth.Value), Convert.ToInt32(numericUpDownSaveHeight.Value));
                img = bmp;
                if (!File.Exists(Variablen.SavePath + @"\" + TextBoxID.Text + ".jpg"))
                {
                    SaveImage(img);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Im ausgewählten Verzeichnis befindet sich bereits eine Datei mit der selben ID. " +
                        "Möchten sie die Datei überschreiben? ", "Duplikat gefunden", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SaveImage(img);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                TextBoxID.Text = "";
            }
            catch
            {

            }
        }

        public void UpdatePreviewImage(String path)
        {
            Variablen.preview_image_path = path;
            Double factor = Convert.ToDouble(Image.FromFile(Variablen.preview_image_path).Width) / Image.FromFile(Variablen.preview_image_path).Height;
            Image_Preview.Size = new Size(Convert.ToInt32(Image_Preview.Height * factor), Image_Preview.Height);
            Image_Preview.Image = Image.FromFile(Variablen.preview_image_path);
            panelDName.Location = new Point(Image_Preview.Size.Width, panelDName.Location.Y);
            Label_BBreite.Location = new Point(Image_Preview.Size.Width, Label_BBreite.Location.Y);
            Label_BHöhe.Location = new Point(Image_Preview.Size.Width, Label_BHöhe.Location.Y);

            if(ImageUtils.getImageName(path).Length > 16)
            {
                Label_DName.Text = "Datei-Name: " + ImageUtils.getImageName(Path);
                autoscrollname = true;
                Name = ImageUtils.getImageName(path).Substring(ImageUtils.getImageName(path).Length - (ImageUtils.getImageName(path).Length - 16));
            }
            else
            {
                Label_DName.Text = "Datei-Name: " + ImageUtils.getImageName(path);
            }
            Path = path;
            
            Button_Löschen.Location = new Point(Image_Preview.Size.Width + 8, Button_Löschen.Location.Y);
            Label_BBreite.Text = "Bild-Breite: " + Image_Preview.Image.Width + " px";
            Label_BHöhe.Text = "Bild-Höhe: " + Image_Preview.Image.Height + " px";
            Label_BPfad.Text = "Pfad: " + path;
            labelCreateTime.Text = "Erstelldatum: " + File.GetCreationTime(Variablen.preview_image_path) + " Uhr";
            labelCreateTime.Location = new Point(Image_Preview.Size.Width, labelCreateTime.Location.Y);
        }

        private void SetLabel()
        {
            Label_Willkommen.Show();
            Label_Verzeichnis.Hide();
            Label_Speicherort.Hide();
            buttonChooseDirectory.Hide();
            buttonChooseSaveDirectory.Hide();
            Label_noDirectory.Hide();
            Bilder_Anzeige.Hide();
            Button_Start.Show();
            Tool_Panel.Hide();
            Image_Preview.Hide();
        }

        private void CheckPics()
        {
            int Count = 0;
            foreach (Control c in Bilder_Anzeige.Controls)
            {
                if (c is PictureBox)
                {
                    Count++;
                }
            }
            if (Count>0)
            {
                LabelNoPics.Hide();
            }
            else
            {
                Bilder_Anzeige.Controls.Add(LabelNoPics);
                LabelNoPics.Show();
            }
        }
    }
}
