using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Metier
{
    public class Serialisation
    {
        private Agence uneAgence;
        /// <summary>
        /// Importe une agence depuis un fichier binaire
        /// </summary>
        /// <returns>Retourne une agence instanciée</returns>
        public Agence importBinaire()
        {
            //On affiche une fenêtre permettant de choisir un fichier à charger
            OpenFileDialog FileDialogBin = new OpenFileDialog();
            FileDialogBin.Title = "Choisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
            FileStream unFlux = null;
            //Si l'utilisateur clique sur "Charger"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String nomFichier = "";
                String chemin = "";
                //On récupère le chemin complet, le nom du fichier et le chemin du dossier contenant le fichier à charger
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                BinaryFormatter fs;
                try
                {
                    //On ouvre un flux binaire
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Open);
                    //On formate le flux en binaire
                    fs = new BinaryFormatter();
                    //On vide la collection avant de récupérer le contenu désérialiser
                    this.uneAgence = (Agence)fs.Deserialize(unFlux);
                    //On affiche un message indiquant le succès de la désérialisation
                    MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            unFlux.Close();
            return this.uneAgence;
        }
        /// <summary>
        /// Exportation d'une agence dans un fichier binaire
        /// </summary>
        /// <param name="uneAgence">Agence à exporter</param>
        public void exportBinaire(Agence uneAgence)
        {
            //On affiche une fenêtre permettant de saisir un fichier dans lequel sauvegarder
            SaveFileDialog FileDialogBin = new SaveFileDialog();
            FileDialogBin.Title = "Saisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
            //Si l'utilisateur clique sur "Enregistrer"
            if (result == DialogResult.OK)
            {
                String cheminComplet = "";
                String nomFichier = "";
                String chemin = "";
                //On récupère le chemin complet choisi dans lequel on remplace \ par \\
                cheminComplet = FileDialogBin.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                //On récupère le nom du fichier qui se trouve en fin du chemin complet
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                //On récupère le chemin du dossier qui contient le fichier ci-dessus (l'autre partie du chemin complet)
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                //On crée un flux binaire de sortie
                FileStream unFlux = null;
                BinaryFormatter fs;
                String nom_fichier = nomFichier;
                try
                {
                    Directory.SetCurrentDirectory(chemin);
                    unFlux = new FileStream(nomFichier, FileMode.Create);
                    //On formate le flux en binaire
                    fs = new BinaryFormatter();
                    fs.Serialize(unFlux, uneAgence);
                    //S'il n'y a pas eu d'erreurs on affiche un message qui en informe l'utilisateur
                    MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("/n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    unFlux.Close();
                }
            }
        }
        /// <summary>
        /// Import d'un fichier en Xml
        /// </summary>
        /// <returns>Retourne un objet instancié Agence</returns>
        public Agence importXml()
        {
            OpenFileDialog fileDialogXML = new OpenFileDialog();
            fileDialogXML.Title = "Choisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*.xml) | *.xml";
            DialogResult result = fileDialogXML.ShowDialog();
            FileStream stream = null;
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";
                string chemin = "";
                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                XmlSerializer serializer;
                Directory.SetCurrentDirectory(chemin);
                if (File.Exists(nomFichier))
                {
                    try
                    {
                        stream = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
                        serializer = new XmlSerializer(typeof(Agence));
                        this.uneAgence = (Agence)serializer.Deserialize(stream);
                        stream.Close();
                        MessageBox.Show("La désérialisation s'est terminée avec succès !", "Désérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            stream.Close();
            return this.uneAgence;
        }
        /// <summary>
        /// Sauvegarde un objet de type agence sur le disque dur
        /// </summary>
        public void exportXml(Agence uneAgence)
        {
            SaveFileDialog fileDialogXML = new SaveFileDialog();
            fileDialogXML.Title = "Saisissez un fichier";
            fileDialogXML.Filter = "Fichiers XML (*.xml) | *.xml";
            DialogResult result = fileDialogXML.ShowDialog();
            if (result == DialogResult.OK)
            {
                string cheminComplet = "";
                string nomFichier = "";
                string chemin = "";
                cheminComplet = fileDialogXML.FileName;
                cheminComplet = cheminComplet.Replace("\\", "\\\\");
                nomFichier = cheminComplet.Substring(cheminComplet.LastIndexOf("\\\\") + 2, cheminComplet.Length - cheminComplet.LastIndexOf("\\\\") - 2);
                chemin = cheminComplet.Substring(0, cheminComplet.Length - (nomFichier.Length + 2));
                FileStream stream = null;
                XmlSerializer serializer;
                try
                {
                    Directory.SetCurrentDirectory(chemin);
                    stream = new FileStream(nomFichier, FileMode.Create);
                    serializer = new XmlSerializer(typeof(Agence));
                    serializer.Serialize(stream, uneAgence);
                    MessageBox.Show("La sérialisation s'est terminée avec succès !", "Sérialisation finie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
        }
    }
}
