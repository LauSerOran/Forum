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
    public partial class Moderateur : Form
    {
        public Moderateur()
        {
            InitializeComponent();
        }

        private string typeMod;

        private void enregistrer(Boolean suppr)
        {
            if (suppr == true)
            {
                MessageBox.Show("Vous supprimez " + typeMod);
            }
            else
            {
                MessageBox.Show("Vous modifiez " + typeMod);
            }
        }

        private void dataGrdViSujetNoCtrl_MouseHover(object sender, EventArgs e)
        {
            lbDescRepMod.Text = "Description";
            lbModifTitreMod.Enabled = true;
            lbModifTitreMod.Show();
            txtBxModifTitreMod.Show();
            typeMod = "un Sujet";

        }

        private void dataGrdViReponseNoCtrl_MouseHover(object sender, EventArgs e)
        {
            lbDescRepMod.Text = "Réponse";
            lbModifTitreMod.Enabled = false;
            lbModifTitreMod.Hide();
            txtBxModifTitreMod.Hide();
            typeMod = "une Réponse";
        }

        private void btModEnrg_Click(object sender, EventArgs e)
        {
            enregistrer(chkBxModSuppr.Checked);

        }
    }
}
