using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBBK_Scanner
{
    public partial class BildBearbeiten : Form
    {
        public BildBearbeiten()
        {
            InitializeComponent();
        }

        private void BildBearbeiten_Load(object sender, EventArgs e)
        {
            Double factor = Convert.ToDouble(Image.FromFile(Variablen.preview_image_path).Width) / Image.FromFile(Variablen.preview_image_path).Height;
            pictureBoxEdit.Size = new Size(Convert.ToInt32(pictureBoxEdit.Height * factor), pictureBoxEdit.Height);
            pictureBoxEdit.Image = Image.FromFile(Variablen.preview_image_path);

            buttonCancel.Location = new Point(pictureBoxEdit.Location.X + pictureBoxEdit.Size.Width + 8, buttonCancel.Location.Y);
            ButtonBestätigen.Location = new Point(pictureBoxEdit.Location.X + pictureBoxEdit.Size.Width + 8 + buttonCancel.Size.Width + 8, ButtonBestätigen.Location.Y);

        }
    }
}
