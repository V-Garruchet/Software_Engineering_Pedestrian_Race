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
    public partial class FormCourse : Form
    {
        private ParticipantRepository participantRepository;
        private ResultatRepository resultatRepository;
        private CourseRepository courseRepository;

        public FormCourse(ParticipantRepository participantRepository, ResultatRepository resultatRepository, CourseRepository courseRepository)
        {
            InitializeComponent();
            this.participantRepository = participantRepository;
            this.resultatRepository = resultatRepository;
            this.courseRepository = courseRepository;
            updateCourse();
        }

        private void updateCourse()
        {
            List<Resultat> resultats = resultatRepository.GetAll();
            //foreach (Resultat resultat in resultats)
            //{
            //    string[] line = { resultat.Participant.Id.ToString(), resultat.Participant.Nom.ToString(), resultat.Classement.ToString(), resultat.Temps.ToShortTimeString() };
            //    dvgTableauCourses.Rows.Add(line);
            //}
        }

        private void btnImpCSV_Click(object sender, EventArgs e)
        {
            if (ofdChooseCsv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofdChooseCsv.FileName);
                sr.Close();
            }
            CSV csv = new CSV(ofdChooseCsv.FileName);
            csv.Import(participantRepository, resultatRepository, courseRepository);

            updateCourse();
        }

        private void dvgTableauCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
