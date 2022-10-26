using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace couleurs
{
    public partial class Form1 : Form
    {

        List<string> color = new List<string> { "ROUGE", "VERT", "BLEU", "JAUNE", "ORANGE", "MAUVE", "ROSE", "BRUN"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouterCouleur_Click(object sender, EventArgs e)
        {
            if (color.Contains(couleuradd.Text.ToUpper()))
                list_couleur.Items.Add(couleuradd.Text[0].ToString().ToUpper() + couleuradd.Text.Substring(1).ToLower());
            else
                MessageBox.Show("Entrer une couleur", "Erreur");

            couleuradd.Text = "";

        }
        private void btncouleurchosie_Click(object sender, EventArgs e)
        {
            int col = 0;
            string chaine = "";

            if (list_couleur.Items.Count != 0)

            {
                chaine += list_couleur.SelectedItems[col];
                col++;
                while (col < list_couleur.SelectedItems.Count)
                {
                    chaine += "," + list_couleur.SelectedItems[col];
                    col++;
                }

                MessageBox.Show("Couleur(s) choisie(s):" + chaine + ".", "Couleur(s) choisie(s)");
            }
            else

                MessageBox.Show("Aucune couleur choisie.", "Couleurs(s) choisie(s)");
        }
        private void btnsupprimerselection_Click(object sender, EventArgs e)
        {
            if (list_couleur.SelectedItems.Count == 0)
                MessageBox.Show("Aucune couleur choisie", "Supprimer une couleur");
            else
                while (list_couleur.SelectedItems.Count != 0)

                    list_couleur.Items.Remove(list_couleur.SelectedItems);

            
        }
    }
}
