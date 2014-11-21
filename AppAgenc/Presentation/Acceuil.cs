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

namespace AppAgenc
{
    public partial class Acceuil : Form
    {
        private static Agence uneAgence;
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

    }
}
