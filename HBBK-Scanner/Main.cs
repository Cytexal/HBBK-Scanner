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
            Utils.input = true;
        }

        public void RefreshImages()
        {
            imagepaths.Clear();
            imagepaths = ImageUtils.getImagesinFolder(@""+Utils.path);

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


            Utils.preview_image_path = firstpath;
            Double factor = Convert.ToDouble(Image.FromFile(Utils.preview_image_path).Width) / Image.FromFile(Utils.preview_image_path).Height;
            Image_Preview.Size = new Size(Convert.ToInt32(Image_Preview.Height * factor), Image_Preview.Height);
            Image_Preview.Image = Image.FromFile(Utils.preview_image_path);
            Label_DName.Location = new Point(Image_Preview.Size.Width, Label_DName.Location.Y);
            Label_BBreite.Location = new Point(Image_Preview.Size.Width, Label_BBreite.Location.Y);
            Label_BHöhe.Location = new Point(Image_Preview.Size.Width, Label_BHöhe.Location.Y);
            Button_Bearbeiten.Location = new Point(Image_Preview.Size.Width + 8,Button_Bearbeiten.Location.Y);
            Label_DName.Text = "Datei-Name: " + ImageUtils.getImageName(firstpath);
            Label_BBreite.Text = "Bild-Breite: " + Image_Preview.Image.Width + " px";
            Label_BHöhe.Text = "Bild-Höhe: " + Image_Preview.Image.Height + " px";
            Label_BPfad.Text = "Pfad: " + firstpath;


        }

        private void Image_Click(object sender, EventArgs e)
        {
            Utils.preview_image_path = nametopath[((PictureBox)sender).Name];
            Double factor = Convert.ToDouble(Image.FromFile(Utils.preview_image_path).Width) / Image.FromFile(Utils.preview_image_path).Height;
            Image_Preview.Size = new Size(Convert.ToInt32(Image_Preview.Height * factor), Image_Preview.Height);
            Image_Preview.Image = Image.FromFile(Utils.preview_image_path);
            Label_DName.Location = new Point(Image_Preview.Size.Width, Label_DName.Location.Y);
            Label_BBreite.Location = new Point(Image_Preview.Size.Width, Label_BBreite.Location.Y);
            Label_BHöhe.Location = new Point(Image_Preview.Size.Width, Label_BHöhe.Location.Y);
            Label_DName.Text = "Datei-Name: " + ((PictureBox)sender).Name;
            Button_Bearbeiten.Location = new Point(Image_Preview.Size.Width + 8, Button_Bearbeiten.Location.Y);
            Label_BBreite.Text = "Bild-Breite: " + Image_Preview.Image.Width + " px";
            Label_BHöhe.Text = "Bild-Höhe: "+ Image_Preview.Image.Height + " px";
            Label_BPfad.Text = "Pfad: " + nametopath[((PictureBox)sender).Name];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Label_Wilkommen.Location = new Point(this.Width/2 - Label_Wilkommen.Width/2,this.Height/2 - 100);
            Button_Directory.Location = new Point(this.Width / 2 - Button_Directory.Width/2, this.Height / 2);
            path_Label = Label_Pfad.Location;
        }

        private void Button_Directory_Click(object sender, EventArgs e)
        {
            Image_Directionary.ShowDialog();
            Utils.path = Image_Directionary.SelectedPath;
            Label_Wilkommen.Hide();
            Label_Pfad.Text = "Pfad: " + Utils.path;
            Label_Pfad.Location = new Point(path_Label.X - Label_Pfad.Size.Width, Label_Pfad.Location.Y);
            Label_Pfad.Show();
            Bilder_Anzeige.Show();
            Button_Directory.Hide();
            RefreshImages();
            Tool_Panel.Show();
            Image_Preview.Show();
            

        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
        }

        private void timer_focus_Tick(object sender, EventArgs e)
        {
            TB_Hidden.Select();
        }

        private void TB_Hidden_TextChanged(object sender, EventArgs e)
        {
            if (TB_Hidden.Text.Length == 1 && Utils.input)
            {
                Utils.input = false;
                Timer t = new Timer();
                t.Interval = 1000;
                t.Tick += t_Tick;
                t.Enabled = true;
            }



            try
            {
                int i = Convert.ToInt32(TB_Hidden.Text);
            }
            catch
            {
                TB_Hidden.Text = "";
            }
        }

        private void t_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Enabled = false;
        }

        private void Button_Bearbeiten_Click(object sender, EventArgs e)
        {
          //  File.Copy(Utils.preview_image_path, @"");
        }
    }
}
