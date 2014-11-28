using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace AppAgenc.Presentation
{
    public partial class ConsulterVoiture : Form
    {
        public ConsulterVoiture()
        {
            InitializeComponent();
            foreach (Voiture uneVoiture in Acceuil.UneAgence.ParcVoitures)
            {
                dgv.Rows.Add(uneVoiture.Nom, uneVoiture.Immatriculation,
                    uneVoiture.Puissance, uneVoiture.DateMiseService,
                    uneVoiture.Categorie, uneVoiture.EstLouee);
            }
        }

        private void btn_Femer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
