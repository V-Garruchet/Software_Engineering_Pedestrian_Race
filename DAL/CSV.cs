using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Gestion des CSV
    /// </summary>
    public class CSV
    {
        private string filePath;
        private ParticipantRepository participantRepository;
        private CourseRepository courseRepository;
        private ResultatRepository resultatRepository;
        private DataTable table;
        private Course course;

        public CSV(string filePath, Course course)
        {
            this.filePath = filePath;
            this.course = course;   
        }

        /// <summary>
        /// Importe le csv dans la base de données. Détection automatique du type (participants ou résultats).
        /// </summary>
        /// <param name="participantRepository"></param>
        /// <param name="resultatRepository"></param>
        /// <param name="courseRepository"></param>
        public void Import(ParticipantRepository participantRepository, ResultatRepository resultatRepository, CourseRepository courseRepository)
        {
            this.participantRepository = participantRepository;
            this.resultatRepository = resultatRepository;
            this.courseRepository = courseRepository;

            ReadCSV();
            string type = "";
            if (table.Columns.Count == 2)
            {
                type = "resultats";
            }
            else if (table.Columns.Count == 6)
            {
                type = "participants";
            }
            else
            {
                throw new System.ArgumentException("Fichier CSV non valide : ", filePath);
            }

            //Réinitialisation de la liste de résultats dans la course
            course.Resultats = new List<Resultat>();
            courseRepository.Save(course);

            FillSQL(type);
        }



        /// <summary>
        /// Lit le fichier csv.
        /// </summary>
        /// <returns>DataTable contenant les informations du CSV.</returns>
        private void ReadCSV()
        {
            table = new DataTable();
            // Creating the columns
            File.ReadLines(filePath).Take(1)
                .SelectMany(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => table.Columns.Add(x.Trim()));

            // Adding the rows
            File.ReadLines(filePath).Skip(1)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => table.Rows.Add(line));
        }

        /// <summary>
        /// Rempli la base de donnée avec les informations contenues dans le CSV
        /// </summary>
        /// <param name="type">"participants" ou "resultats"</param>
        /// <param name="participantRepository"></param>
        /// <param name="resultatRepository"></param>
        /// <param name="courseRepository"></param>
        private void FillSQL(string type)
        {
            if (type == "participants")
            {
                resultatRepository.DeleteAllFromCourse(course);
            }
            int nbreRows = table.Rows.Count;
            if (nbreRows > 1)
            {
                for (int i = 0; i < nbreRows; i++)
                {
                    if (type == "participants")
                    {
                        Participant p = new Participant(table.Rows[i].ItemArray.GetValue(0).ToString(), table.Rows[i].ItemArray.GetValue(1).ToString(),
                                                        Convert.ToDateTime(table.Rows[i].ItemArray.GetValue(2)), Convert.ToChar(table.Rows[i].ItemArray.GetValue(3)),
                                                        table.Rows[i].ItemArray.GetValue(4).ToString(), table.Rows[i].ItemArray.GetValue(5).ToString());
                        participantRepository.Save(p);
                        //Résultat temporaire avant les résultats de la course (temps = 0)
                        Resultat r = new Resultat(course, p, new DateTime());

                        course.Resultats.Add(r);
                        resultatRepository.Save(r);
                    }
                    else if (type == "resultats")
                    {
                        int numDossard = Convert.ToInt32(table.Rows[i].ItemArray.GetValue(0));
                        Participant p = participantRepository.FindByDossard(numDossard);

                        if (p == null)
                            throw new Exception("Le participant " + numDossard + " n'existe pas dans la BDD. Importez les participants avant d'importer les résultats.");

                        string time = table.Rows[i].ItemArray.GetValue(1).ToString();
                        int h = Convert.ToInt32(lectChaineCsv(time, ':')[0]);
                        int min = Convert.ToInt32(lectChaineCsv(time, ':')[1]);
                        int s = Convert.ToInt32(lectChaineCsv(time, ':')[2]);
                        DateTime temps = new DateTime(2000, 1, 1, h, min, s);
                        Resultat r = resultatRepository.FindByCourseParticipant(course, p);
                        r.Temps = temps;

                        course.Resultats.Add(r);
                        resultatRepository.Save(r);
                    }
                    else throw new System.ArgumentException("Le type renseigné est invalide : ", type);
                }
            }
        }

        private static List<string> lectChaineCsv(string chaine, char car)
        {
            if (chaine[chaine.Length - 1].ToString() == ";")
            {
                chaine = chaine.Substring(0, chaine.Length - 1);
            }
            int i = 0;
            int compteur = 0;
            List<string> liste = new List<string> { };
            while (i < chaine.Length - 1)
            {
                liste.Add("");
                while (chaine[i] != car && i != chaine.Length - 1)
                {
                    liste[compteur] += chaine[i];
                    i += 1;
                }
                if (i == chaine.Length - 1)
                {
                    liste[compteur] += chaine[i];
                }
                else
                {
                    i += 1;
                    compteur += 1;
                }
            }
            return liste;
        }

    }
}