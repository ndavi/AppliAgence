using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;


namespace Metier
{
    class Serialisation
    {
        private Agence uneAgence;
        private Agence importBinaire()
        {
            //On affiche une fenêtre permettant de choisir un fichier à charger
            OpenFileDialog FileDialogBin = new OpenFileDialog();
            FileDialogBin.Title = "Choisissez un fichier";
            //On fixe l'extension à .ci
            FileDialogBin.Filter = "Fichiers CI (*.ci)|*.ci";
            DialogResult result = FileDialogBin.ShowDialog();
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
                FileStream unFlux = null;
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
                finally
                {
                    unFlux.Close();
                    return this.uneAgence;
                }


            }
        }

        private void exportBinaire()
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
    }
}
