using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAgenc.Presentation
{
    public partial class RendreVoiture : Form
    {
        public RendreVoiture()
        {
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
