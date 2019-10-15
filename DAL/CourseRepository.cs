using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CourseRepository:Repository
    {
        public List<Course> GetAll()
        {
            return Session.Query<Course>().ToList();
        }
        public Course FindById(int courseId)
        {
            IList<Course> courses = Session.Query<Course>().Where(c => c.Id == courseId).ToList();
            if (courses.Count == 0) return null;
            else return courses[0]; ;
        }

        public void Save(Course course)
        {
            Session.SaveOrUpdate(course);
            Session.Flush();
        }

        public void Delete(Course course)
        {
            //Suppression de tous les résultats propres à la course
            //(gestion de la suppression en cascade à la main car soucis avec nhibernate)
            foreach(Resultat resultat in course.Resultats)
            {
                Session.Delete(resultat);
            }
            Save(course);

            //Puis suppression de la course
            Session.Delete(course);
            Session.Flush();
            //Save(course);
        }

    }
}
