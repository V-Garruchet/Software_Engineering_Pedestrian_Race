using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ResultatRepository:Repository
    {
        public List<Resultat> GetAll()
        {
            return Session.Query<Resultat>().ToList();
        }

        public List<Resultat> FindByCourse(Course course)
        {
            List<Resultat> resultats = Session.Query<Resultat>().Where(r => r.Course.Id == course.Id).ToList();
            return resultats;
        }

        public Resultat FindByCourseParticipant(Course course, Participant participant)
        {
            List<Resultat> resultats = Session.Query<Resultat>().Where(r => (r.Course.Id == course.Id && r.Participant.NumDossard == participant.NumDossard)).ToList();

            if (resultats.Count == 0) return null;
            else return resultats[0];
        }

        public List<Resultat> FindAllByParticipants(Course course, List<Participant> participants)
        {
            List<Resultat> resultats = new List<Resultat>();
            foreach(Participant p in participants)
            {
                Resultat resultat = FindByCourseParticipant(course, p);
                resultats.Add(resultat);
            }

            return resultats;
        }


        public void Save(Resultat resultat)
        {
            Session.SaveOrUpdate(resultat);
            Session.Flush();
        }

        public void DeleteAllFromCourse(Course course)
        {
            List<Resultat> toDelete = FindByCourse(course);
            foreach (Resultat resToDelete in toDelete)
                Session.Delete(resToDelete);
            Session.Flush();
        }
    }
}
