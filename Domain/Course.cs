using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {
        public virtual int Id { get; set; }
        public virtual string Nom { get; set; }
        /// <summary>
        /// Longueur de la course en mètre.
        /// </summary>
        public virtual int Longueur { get; set; }
        public virtual IList<Resultat> Resultats { get; set; }

        public Course()
        {
            Resultats = new List<Resultat>();
        }
        public Course(string nom):this()
        {
            Nom = nom;
        }

        /// <summary>
        /// Renvoie les participants de la course triés alphabétiquement.
        /// </summary>
        /// <returns></returns>
        public virtual List<Participant> GetParticipants()
        {
            List < Participant > participants = new List< Participant > ();

            if (Resultats == null)
                return null;

            foreach(Resultat r in Resultats)
            {
                participants.Add(r.Participant);
            }

            //Tri par ordre alphabétique des noms
            participants.Sort((p1,p2) => string.Compare(p1.Nom,p2.Nom));
            return participants;
        }

        /// <summary>
        /// Renvoie les résultats triés par ordre d'arrivée.
        /// </summary>
        /// <returns></returns>
        public virtual List<Resultat> GetSortedResultats()
        {
            List<Resultat> sortedResultats = new List<Resultat>(Resultats.ToList());
            sortedResultats.Sort((r1, r2) => DateTime.Compare(r1.Temps,r2.Temps));

            return sortedResultats;
        }
    }
}
