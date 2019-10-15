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
    public partial class FormAjoutParticipant : Form
    {
        CourseRepository courseRepository;
        ParticipantRepository participantRepository;
        ResultatRepository resultatRepository;
        Course course;


        public FormAjoutParticipant(Course course, CourseRepository courseRepository, ParticipantRepository participantRepository, ResultatRepository resultatRepository)
        {
            this.course = course;
            this.courseRepository = courseRepository;
            this.participantRepository = participantRepository;
            this.resultatRepository = resultatRepository;

            InitializeComponent();
            this.TopMost = true;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //TOus les champs obligatoires sont remplis ?
            if (tb_nom.Text == "" || tb_prenom.Text == "" || (!rb_F.Checked && !rb_H.Checked))
            {
                //Non : affichage d'un message d'erreur.
                MessageBox.Show("Merci de remplir tout les champs précédés d'un asterix (*)","Champs manquants",
                                  MessageBoxButtons.OK);
            }

            else
            {
                //Oui : on créé puis on sauvegarde le participant dans la bdd, avec un résultat vierge
                string nom = tb_nom.Text;
                string prenom = tb_prenom.Text;
                char sexe = rb_F.Checked ? 'F' : 'M';
                DateTime dateNaissance = dtp_naissance.Value;
                string mail = tb_mail.Text;
                string license = tb_license.Text;

                Participant p = new Participant(nom, prenom, dateNaissance, sexe, mail, license);
                Resultat r = new Resultat(course, p, new DateTime());

                participantRepository.Save(p);
                resultatRepository.Save(r);

                course.Resultats.Add(r);
                courseRepository.Save(course);
          
                //puis on ferme ce formulaire
                DialogResult = DialogResult.OK;
                this.Close();
            }
            

        }


    }
}
