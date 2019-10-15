using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace APP
{
    public partial class FormAuthentification : Form
    {
        //On pourrait entrer ces valeurs dans un fichier texte puis les récupérer ...
        private string id = "admin";
        private string mdp = "admin";

        public FormAuthentification()
        {
            InitializeComponent();
            this.TopMost = true;
        }



        private void btnValider_Click(object sender, EventArgs e)
        {
            if (IsIdCorrect() && IsMdpCorrect())
            {
                //le formulaire se ferme avec validation de l'authentification
                DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Merci de vérifier votre identifiant et votre mot de passe", 
                    "Échec de l'authentification.", MessageBoxButtons.OK);
            }
                
        }

        private bool IsIdCorrect()
        {
            return tbId.Text == id;
        }

        private bool IsMdpCorrect()
        {
            return tbMdp.Text == mdp;
        }
    }
}
