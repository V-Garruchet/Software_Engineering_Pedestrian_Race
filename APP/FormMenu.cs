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
using Microsoft.VisualBasic;
using System.Globalization;

namespace APP
{
    public partial class FormMenu : Form
    {
        private CourseRepository courseRepository;
        private ResultatRepository resultatRepository;
        private ParticipantRepository participantRepository;
        private Course course;
        private static List<object[]> liste = new List<object[]> { };
        private static List<object[]> listeTemps = new List<object[]> { };
        private static bool connected = false;


        public FormMenu(ParticipantRepository participantRepository, ResultatRepository resultatRepository, CourseRepository courseRepository)
        {
            InitializeComponent();
            this.courseRepository = courseRepository;
            this.resultatRepository = resultatRepository;
            this.participantRepository = participantRepository;

            this.WindowState = FormWindowState.Maximized;
            UpdateCbCourse();
        }

        /// <summary>
        /// Mise a jour de l'affichage du combobox des courses, selon la course sélectionnée
        /// </summary>
        private void UpdateCbCourse()
        {
            //Suppression de tous les éléments du combobox
            cbCourse.Items.Clear();

            //Item 1 : nouvelle course 
            cbCourse.Items.Add("- Nouvelle course -");

            //On récupère toutes les courses dans la bdd puis on les ajoute au combobox
            List<Course> courses = courseRepository.GetAll();
            foreach(Course c in courses)
            {
                Object item = c.Id + ". " + c.Nom + " (" + c.Longueur/1000 + " km)";
                cbCourse.Items.Add(item);
            }

            //Si on a sélectionné une course, on l'affiche dans le combobox des courses, sinon celui-ci n'affiche rien
            if (course != null)
                cbCourse.SelectedItem = course.Id + ". " + course.Nom;

            else cbCourse.SelectedIndex = 0;
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aucune course sélectionnée
            if (cbCourse.SelectedIndex == 0)
            {
                //Désactivation des boutons non utilisables
                btnRechercherAge.Enabled = false;
                btnRechercher.Enabled = false;
                btn_ajouter.Enabled = false;
                //btnDeleteCourse.Enabled = false;
                btnDeleteCourse.Text = "Créer";
                btnModifierCourse.Enabled = false;

                course = null;
                UpdateCourse();
            }
            else
            {
                //Activation des boutons grisés
                btnRechercherAge.Enabled = true;
                btnDeleteCourse.Text = "Supprimer";
                btnDeleteCourse.Enabled = true;
                btnModifierCourse.Enabled = true;
                btnRechercher.Enabled = true;
                btn_ajouter.Enabled = true;
                string selectedItem = cbCourse.SelectedItem.ToString();

                //On prend le chiffre en entier (avant le .)
                string selectedId = "";
                int i = 0;
                while (selectedItem[i] != '.')
                {
                    selectedId += selectedItem[i];
                    i++;
                }

                int courseId = Convert.ToInt32(selectedId);
                course = courseRepository.FindById(courseId);

                foreach (Participant participant in course.GetParticipants())
                {
                    cbRecherche.Items.Add(participant.Nom);
                    cbRecherche.Items.Add(participant.NumDossard);
                }
                UpdateCourse();
            }
            
        }

        /// <summary>
        /// Mise à jour de l'affichage des participants de la course sélectionnée
        /// </summary>
        private void UpdateParticipants()
        {
            List<Participant> participants;
            if (course == null)
            {
                ResetDvg(dgvParticipants);
            }
            else
            {
                participants = course.GetParticipants();
                showParticipants(participants);
            }
        }

        /// <summary>
        /// Mise à jour de l'affichage des résultats de la course sélectionnée
        /// </summary>
        private void UpdateResultats()
        {
            if (course == null)
            {
                ResetDvg(dgvResultats);
            }
            else
            {
                List<Resultat> resultats = course.GetSortedResultats();
                foreach(Resultat resultat in resultats)
                {
                    resultat.Temps = Convert.ToDateTime(resultat.Temps.ToString());
                }              
                showResultats(resultats);
            }
        }

        public void UpdateCourse()
        {
            UpdateParticipants();
            UpdateResultats();
        }

        private void ResetDvg(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Refresh();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Boite de dialogue "attention à la perte de données" 
            DialogResult dialogResult = MessageBox.Show("L'import entrainera la perte des informations concernant la " +
                "course sélectionnée. Voulez-vous continuer ?", "Attention", MessageBoxButtons.YesNo);

            //Si aucune course n'est sélectionnée ou si l'utilisateur clique sur "oui"
            if (course == null || dialogResult == DialogResult.Yes)
            {     
                //SI il s'est correctement authentifié, on lui demande de choisir son csv
                if (connected && ofdChooseCsv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //et s'il a bien choisi un csv valide, on met à jour la bdd en conséquence
                    System.IO.StreamReader sr = new System.IO.StreamReader(ofdChooseCsv.FileName);
                    sr.Close();

                    //Création d'une nouvelle course si aucune course n'est sélectionnée
                    if (course == null)
                    {
                        course = new Course("Nouvelle course");
                        courseRepository.Save(course);
                        UpdateCbCourse();
                        cbCourse.SelectedIndex = cbCourse.Items.Count - 1;
                    }
                    CSV csv = new CSV(ofdChooseCsv.FileName, course);
                    //On essaie d'importer le CSV et en cas d'erreur on informe l'utilisateur
                    try
                    {
                        csv.Import(participantRepository, resultatRepository, courseRepository);
                        UpdateCourse();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }    
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (btnDeleteCourse.Text == "Créer")
            {
                course = new Course("Nouvelle course");
                courseRepository.Save(course);
                UpdateCbCourse();
                btnDeleteCourse.Text = "Supprimer";
                cbCourse.SelectedIndex = cbCourse.Items.Count - 1;
            }
            else
            {
                courseRepository.Delete(course);
                course = null;
                UpdateCourse();
                UpdateCbCourse();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (cbRecherche.SelectedItem != null)
            {
                string selectedItem = cbRecherche.SelectedItem.ToString();

                int partNum;

                if (int.TryParse(selectedItem, out partNum))
                {
                    //On prend le dossard en entrée
                    Participant participant = participantRepository.FindByDossard(partNum);
                    List<Participant> participants = new List<Participant> { participant };
                    showParticipants(participants);
                    showResultats(resultatRepository.FindAllByParticipants(course, participants));
                }
                else
                {

                    //On prend le nom en entrée
                    string partNom = Convert.ToString(selectedItem);
                    List<Participant> participants = participantRepository.FindByNom(partNom);
                    showParticipants(participants);
                    showResultats(resultatRepository.FindAllByParticipants(course, participants));
                }
                tbAgeMax.Text = "";
                tbAgeMini.Text = "";
            }
            else
            {
                cbRecherche.Text = "";
                string selectedItem = cbCourse.SelectedItem.ToString();

                //On prend le chiffre en entier (avant le .)
                string selectedId = "";
                int i = 0;
                while (selectedItem[i] != '.')
                {
                    selectedId += selectedItem[i];
                    i++;
                }

                int courseId = Convert.ToInt32(selectedId);
                course = courseRepository.FindById(courseId);

                foreach (Participant participant in course.GetParticipants())
                {
                    cbRecherche.Items.Add(participant.Nom);
                    cbRecherche.Items.Add(participant.NumDossard);
                }
                UpdateCourse();
            }
        }


        private void showResultats(List<Resultat> resultats)
        {
            dgvResultats.Rows.Clear();
            dgvResultats.Refresh();

            int classement = 1;

            foreach (Resultat resultat in resultats)
            {
                string temps;

                string[] line;

                if (resultat.Temps == new DateTime())
                {
                    temps = "En attente de résultat";

                    line = new string []{ "Non classé", resultat.Participant.Nom.ToString(), resultat.Participant.NumDossard.ToString(), temps, "Non défini", "Non défini"};
                    classement -= 1;
                }
                else
                {
                    temps = resultat.Temps.ToString("hh:mm:ss", CultureInfo.CreateSpecificCulture("fr-FR"));

                    line = new string[] { classement.ToString(), resultat.Participant.Nom.ToString(), resultat.Participant.NumDossard.ToString(), temps, resultat.GetVitesseMoyenne().ToString(), resultat.GetAllureMoyenne().ToString() };
                }
             
                dgvResultats.Rows.Add(line);
                classement++;
            }
        }
        private void showParticipants(List<Participant> participants)
        {
            dgvParticipants.Rows.Clear();
            dgvParticipants.Refresh();

            foreach (Participant participant in participants)
            {
                string[] line = { participant.NumDossard.ToString(), participant.Nom.ToString(), participant.Prenom.ToString(), participant.Sexe.ToString(),
                    participant.DateNaissance.ToString("dd/MM/yyyy"), participant.Mail.ToString(), participant.Licence.ToString() };
                dgvParticipants.Rows.Add(line);               
            }
        }

        private void btnRechercherAge_Click(object sender, EventArgs e)
        {
            int ageMin;
            if (tbAgeMini.Text != null && int.TryParse(tbAgeMini.Text, out ageMin))
            {
                tbAgeMax.Text = Convert.ToString(ageMin + 10);
                List<Participant> partsCourse = course.GetParticipants();
                List<Participant> partsAge = course.GetParticipants();

                foreach (Participant participant in partsCourse)
                {
                    if (participant.Age > Int32.Parse(tbAgeMax.Text) || participant.Age < Int32.Parse(tbAgeMini.Text))
                    {
                        partsAge.Remove(participant);
                    }
                }

                List<Resultat> resAge = resultatRepository.FindAllByParticipants(course, partsAge);
                showParticipants(partsAge);
                showResultats(resAge);

                cbRecherche.Text = "";
                cbRecherche.SelectedItem = null;
            }
            else
            {
                tbAgeMini.Text = "";
                tbAgeMax.Text = "";

                string selectedItem = cbCourse.SelectedItem.ToString();

                //On prend le chiffre en entier (avant le .)
                string selectedId = "";
                int i = 0;
                while (selectedItem[i] != '.')
                {
                    selectedId += selectedItem[i];
                    i++;
                }

                int courseId = Convert.ToInt32(selectedId);
                course = courseRepository.FindById(courseId);

                foreach (Participant participant in course.GetParticipants())
                {
                    cbRecherche.Items.Add(participant.Nom);
                    cbRecherche.Items.Add(participant.NumDossard);
                }
                UpdateCourse();
            }
        }


        /// <summary>
        /// Affiche la fenêtre d'authentification et si l'utilisateur s'est correctement authentifié on retourne true (false sinon)
        /// </summary>
        /// <returns></returns>
        private void Connection()
        {
            if (!connected)
            {
                Form authForm = new FormAuthentification();
                DialogResult authResult = authForm.ShowDialog();

                if (authResult == DialogResult.OK)
                    connected = true;
            }
            return ;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //Ajout d un participant via le formulaire ajout participant puis mise a jour des données
            if (AjoutParticipantSucessed())
            {
                UpdateCourse();
            }    
        }

        private bool AjoutParticipantSucessed()
        {
            Form ajoutPart = new FormAjoutParticipant(course, courseRepository, participantRepository, resultatRepository);
            DialogResult ajoutPartResult = ajoutPart.ShowDialog();
            return ajoutPartResult == DialogResult.OK;
        }

        private bool ModifCourseSucessed()
        {
            Form modifCourse = new FormModifCourse(course, courseRepository);
            DialogResult modifCourseResult = modifCourse.ShowDialog();
            return modifCourseResult == DialogResult.OK;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edition")
            {
                //On affiche la fenêtre d'authentification pour l'inviter à s'authentifier
                Connection();
                if (connected)
                {
                    btnEdit.Text = "Valider";
                    dgvParticipants.ReadOnly = false;
                    dgvParticipants.Columns[0].ReadOnly = true;
                    dgvResultats.Columns[3].ReadOnly = false;

                    liste.Clear();

                    if (course == null)
                    {
                        btnDeleteCourse.Text = "Créer";
                    }
                    else btnModifierCourse.Visible = true; 
                }
            }
            else
            {
                foreach (object[] valLin in listeTemps)
                {
                    object val = valLin[0];
                    int lin = Convert.ToInt32(valLin[1]);

                    Participant part = participantRepository.FindByDossard(Convert.ToInt32(dgvResultats[2, lin].Value));
                    Resultat res = resultatRepository.FindByCourseParticipant(course, part);

                    //string time = "2000/01/01 " + dgvResultats[3, lin].Value.ToString();
                    string time = dgvResultats[3, lin].Value.ToString();

                    DateTime temps;
                    if (DateTime.TryParse(time, out temps))
                        res.Temps = temps;
                    else
                        dgvParticipants[3, lin].Value = val;

                    resultatRepository.Save(res);
                    
                }
                

                foreach (object[] valColLin in liste)
                {
                    object val = valColLin[0];
                    int col = Convert.ToInt32(valColLin[1]);
                    int lin = Convert.ToInt32(valColLin[2]);


                    Participant part = participantRepository.FindByDossard(Convert.ToInt32(dgvParticipants[0, lin].Value));
                    if (col == 1)
                    {
                        part.Nom = dgvParticipants[col, lin].Value.ToString();
                    }
                    if (col == 2)
                    {
                        part.Prenom = dgvParticipants[col, lin].Value.ToString();
                    }
                    if (col == 3)
                    {
                        char sexe;
                        if (Char.TryParse(dgvParticipants[col, lin].Value.ToString(), out sexe))
                            part.Sexe = sexe;
                        else
                            dgvParticipants[col, lin].Value = val;
                    }
                    if (col == 4)
                    {
                        DateTime date;
                        if (DateTime.TryParse(dgvParticipants[col, lin].Value.ToString(), out date))
                            part.DateNaissance = date;
                        else
                            dgvParticipants[col, lin].Value = val;
                    }
                    if (col == 5)
                    {
                        part.Mail = dgvParticipants[col, lin].Value.ToString();
                    }
                    if (col == 6)
                    {
                        part.Licence = dgvParticipants[col, lin].Value.ToString();
                    }
                    participantRepository.Save(part);
                }
                
                UpdateResultats();

                btnEdit.Text = "Edition";
                dgvParticipants.ReadOnly = true;
                dgvResultats.Columns[3].ReadOnly = true;
            }
        }


        private void dgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)       // A un défaut
        {
            foreach (DataGridViewCell cell in dgvParticipants.SelectedCells)
            {
                object[] valColLin = new object[3];
                valColLin[0] = cell.Value;
                valColLin[1] = cell.ColumnIndex;
                valColLin[2] = cell.RowIndex;
                liste.Add(valColLin);
            }
        }

        private void btnModifierCourse_Click(object sender, EventArgs e)
        {
            int indexCbCourse = cbCourse.SelectedIndex;

            if (ModifCourseSucessed())
            {
                UpdateCbCourse();
                UpdateResultats();
                cbCourse.SelectedIndex = indexCbCourse;
            }
        }

        private void dgvResultats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvResultats.SelectedCells)
            {
                object[] valLin = new object[2];
                valLin[0] = cell.Value;
                valLin[1] = cell.RowIndex;
                listeTemps.Add(valLin);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connexion")
            {
                Connection();
                if (connected)
                {
                    btnDeleteCourse.Visible = true;
                    btnImport.Enabled = true;
                    btnModifierCourse.Visible = true;
                    btn_ajouter.Visible = true;
                    btnConnect.Text = "Déconnexion";
                    btnEdit.Visible = true;
                }
            }
            else
            {
                btnDeleteCourse.Visible = false;
                btnImport.Enabled = false;
                btnModifierCourse.Visible = false;
                btn_ajouter.Visible = false;
                btnEdit.Visible = false;
                btnConnect.Text = "Connexion";
            }
        }

    }
}
