using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using DAL;
using Domain;

namespace APP
{
    public partial class FormParticipant : Form
    {
        private ParticipantRepository participantRepository;
        private ResultatRepository resultatRepository;
        private CourseRepository courseRepository;

        public FormParticipant(ParticipantRepository participantRepository, ResultatRepository resultatRepository)
        {
            InitializeComponent();
            this.participantRepository = participantRepository;
            this.resultatRepository = resultatRepository;

        }

        private void dgvTableauParticipant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void test_btn_Click(object sender, EventArgs e)
        {

        }

        private void updateParticipants()
        {
            List<Participant> participants = participantRepository.GetAll();
            foreach (Participant participant in participants)
            {
                string[] line = { participant.Id.ToString(), participant.Nom.ToString(), participant.Prenom.ToString() };
                dgvTableauParticipant.Rows.Add(line);
            }
        }


        private void btnImpCSV_Click(object sender, EventArgs e)
        {
            if (ofdChooseCsv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofdChooseCsv.FileName);
                sr.Close();
                lbTest.Text = ofdChooseCsv.FileName;
            }
            CSV csv = new CSV(ofdChooseCsv.FileName);
            csv.FillSQL("participants", participantRepository, resultatRepository,courseRepository);

            updateParticipants();
        }

        private void dgvTableauParticipant_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*
        private void BindToDataGrid()
{
    // Instruct the DataGrid to bind to the DataSet, with the 
    // ParentTable as the topmost DataTable.
    dataGrid1.SetDataBinding(dataSet,"ParentTable");
}

    */

    }
}
