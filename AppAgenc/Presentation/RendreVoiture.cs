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
    public partial class RendreVoiture : Form
    {
        public RendreVoiture()
        {
            InitializeComponent();
            foreach (Voiture uneVoiture in Acceuil.UneAgence.ParcVoitures)
            {
                cb_Voitures.Items.Add(uneVoiture.Nom);
            }
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Object voitureSelected = cb_Voitures.SelectedItem;
            Voiture laVoiture = Acceuil.UneAgence.ParcVoitures.Find(x => x.Nom == Convert.ToString(voitureSelected));
            laVoiture.EstLouee = false;
            laVoiture.Loueur = null;
            this.Close();

        }
    }
}
