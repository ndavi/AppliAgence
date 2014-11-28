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
    public partial class Acceuil : Form
    {
        private static Agence uneAgence = new Agence();
        public static Agence UneAgence
        {
            get { return Acceuil.uneAgence; }
            set { Acceuil.uneAgence = value; }
        }
        public Acceuil()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sauvegarderLesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serialisation serializer = new Serialisation();
            serializer.exportXml(uneAgence);
        }

        private void chargerUneSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serialisation serializer = new Serialisation();
            uneAgence = serializer.importXml();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterUneVoiture ajouterVoiture = new AjouterUneVoiture();
            ajouterVoiture.Show();
        }

        private void toutesLesVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsulterVoiture consulterVoiture = new ConsulterVoiture();
            consulterVoiture.Show();
        }

        private void ajouterUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterUnePersonne ajPersonne = new AjouterUnePersonne();
            ajPersonne.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LouerVoiture uneloc = new LouerVoiture();
            uneloc.Show();
        }

        private void rendreUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RendreVoiture Rendre = new RendreVoiture();
            Rendre.Show();
        }

        private void supprimerUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerUnePersonne uneSupPer = new SupprimerUnePersonne();
            uneSupPer.Show();
        }

        private void supprimerUneVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerUneVoiture supuneVoit = new SupprimerUneVoiture();
            supuneVoit.Show();
        }

        private void toutesLesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationPersonne uneConsPers = new ConsultationPersonne();
            uneConsPers.Show();
        }

    }
}
