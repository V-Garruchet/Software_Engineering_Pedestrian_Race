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
    public partial class FormModifCourse : Form
    {
        CourseRepository courseRepository;
        Course course;


        public FormModifCourse(Course course, CourseRepository courseRepository)
        {
            this.course = course;
            this.courseRepository = courseRepository;

            InitializeComponent();
            this.TopMost = true;

            tb_nom.Text = course.Nom;
            nup_longueur.Value = course.Longueur;
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            course.Nom = tb_nom.Text;
            course.Longueur = (int)nup_longueur.Value;
            courseRepository.Save(course);
            DialogResult = DialogResult.OK;
        }
    }
}
