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
    public partial class Administrateur : Form
    {
        public Administrateur()
        {
            InitializeComponent();
        }

        private string typeModif;

        private void enregistrer(Boolean suppr)
        {
            if (suppr == true)
            {
                MessageBox.Show("Vous supprimez " + typeModif);
            }
            else
            {
                MessageBox.Show("Vous modifiez " + typeModif);
            }
        }


        private void btModEnrg_Click(object sender, EventArgs e)
        {
            enregistrer(chkBxModSupprAdm.Checked);
        }

        private void dataGrdViRubrique_MouseHover(object sender, EventArgs e)
        {

        }

        private void dataGrdViSujet_MouseHover(object sender, EventArgs e)
        {
            lbModifRubAdm.Hide();
            txtBxModifRubAdm.Hide();
            lbDescRepAdm.Text = "Description";
            lbModifTitreAdm.Enabled = true;
            lbModifTitreAdm.Show();
            txtBxModifTitreAdm.Show();
            typeModif = "un sujet";
        }

        private void dataGrdViReponse_MouseHover(object sender, EventArgs e)
        {
            lbModifRubAdm.Hide();
            txtBxModifRubAdm.Hide();
            lbDescRepAdm.Text = "Réponse";
            lbModifTitreAdm.Enabled = false;
            lbModifTitreAdm.Hide();
            txtBxModifTitreAdm.Hide();
            typeModif = "une réponse";
        }
    }
}
