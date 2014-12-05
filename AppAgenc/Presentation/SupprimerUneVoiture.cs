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
    public partial class SupprimerUneVoiture : Form
    {
        public SupprimerUneVoiture()
        {
            InitializeComponent();
            foreach (Voiture uneVoiture in Acceuil.UneAgence.ParcVoitures)
            {
                cbb_Voitures.Items.Add(uneVoiture.Nom);
            }
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_Voitures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Object voitureSelected = cbb_Voitures.SelectedItem;
            Voiture laVoiture = Acceuil.UneAgence.ParcVoitures.Find(x => x.Nom == Convert.ToString(voitureSelected));
            Acceuil.UneAgence.ParcVoitures.Remove(laVoiture);
        }
    }
}
