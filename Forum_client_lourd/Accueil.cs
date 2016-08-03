using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forum_client_lourd
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void testDroits(Boolean visiteur)
        {
            if(visiteur)
            {
                Visiteur Form1 = new Visiteur();
                Form1.ShowDialog();
            }
            else
            {
                if(string.IsNullOrEmpty(txtBxIdentifiant.Text) || string.IsNullOrEmpty(txtBxMotDePasse.Text) || string.IsNullOrWhiteSpace(txtBxIdentifiant.Text) || string.IsNullOrWhiteSpace(txtBxMotDePasse.Text))
                {
                    MessageBox.Show("Vous devez vous identifier avec un identifiant et un mot de passe");
                }
                else
                {
                    MessageBox.Show("Vous êtes identifié, redirection vers l'administrateur pour les tests");
                    //MessageBox.Show("Vous êtes identifié, redirection vers modérateur pour les tests");
                    // TODO tests de l'identifiant rt redirection vers la bonne page
                    // Moderateur Form1 = new Moderateur();
                    Administrateur Form1 = new Administrateur();
                    Form1.ShowDialog();
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Visiteur Form1 = new Visiteur();
            Form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utilisateur Form1 = new Utilisateur();
            Form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Moderateur Form1 = new Moderateur();
            Administrateur Form1 = new Administrateur();
            Form1.ShowDialog();

        }

        private void chkBxVisiteur_CheckedChanged(object sender, EventArgs e)
        {
            
            txtBxIdentifiant.Enabled = !chkBxVisiteur.Checked;
            txtBxMotDePasse.Enabled = !chkBxVisiteur.Checked;
            if(chkBxVisiteur.Checked)
            {
                btConnect.BackColor = Color.DeepPink;
            }
            else
            {
                btConnect.BackColor = Color.LimeGreen;
            }

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            testDroits(chkBxVisiteur.Checked);
        }

    }
}
