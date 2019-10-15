using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace APP
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ResultatRepository resultatRepository = new ResultatRepository();
            ParticipantRepository participantRepository = new ParticipantRepository();
            CourseRepository courseRepository = new CourseRepository();

            Application.Run(new FormMenu(participantRepository, resultatRepository, courseRepository));
        }
    }
}
