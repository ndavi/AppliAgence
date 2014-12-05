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
    public partial class AjouterUneVoiture : Form
    {
        public AjouterUneVoiture()
        {
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Voiture voiture = new Voiture(txt_NomVoiture.Text, txt_Categorie.Text,
                Convert.ToDouble(txt_Puissance.Text), txt_Immatriculation.Text,
                rb_Oui.Checked, Convert.ToDateTime(txt_dateMiseEnService.Value.Year + "/" + txt_dateMiseEnService.Value.Month + "/" +txt_dateMiseEnService.Value.Day));
            Acceuil.UneAgence.AjouterVoiture(voiture);
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
