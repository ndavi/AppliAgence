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
    public partial class SupprimerUneVoiture : Form
    {
        public SupprimerUneVoiture()
        {
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_Voitures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
