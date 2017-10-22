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
            if(Image.FromFile(Variablen.preview_image_path).Height >= 1000)
            {
                Double factor = Convert.ToDouble(Image.FromFile(Variablen.preview_image_path).Width) / Image.FromFile(Variablen.preview_image_path).Height;
                this.Size = new Size(Convert.ToInt32(1000 * factor), 1000);
                this.BackgroundImage = Image.FromFile(Variablen.preview_image_path);
            }
            else
            {
                Double factor = Convert.ToDouble(Image.FromFile(Variablen.preview_image_path).Width) / Image.FromFile(Variablen.preview_image_path).Height;
                this.Size = new Size(Convert.ToInt32(Image.FromFile(Variablen.preview_image_path).Height * factor), Image.FromFile(Variablen.preview_image_path).Height);
                this.BackgroundImage = Image.FromFile(Variablen.preview_image_path);
            }
        }
    }
}
