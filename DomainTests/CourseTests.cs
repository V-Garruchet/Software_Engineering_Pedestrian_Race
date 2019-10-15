using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Domain.Tests
{
    [TestClass()]
    public class CourseTests
    {

        [TestMethod()]
        public void GetSortedResultatsTest()
        {
            //Création d'une course avec 3 résultats non triés
            Course course = new Course();
            Resultat r1 = new Resultat(course, new Participant(), new DateTime(2018,6,12, 2,36,2));
            Resultat r2 = new Resultat(course, new Participant(), new DateTime(2018,6,12, 1, 23, 26));
            Resultat r3 = new Resultat(course, new Participant(), new DateTime(2018,6,12, 2, 02, 42));

            IList<Resultat> lres = new List<Resultat> { r1, r2, r3 };
            course.Resultats = lres;

            //Liste attendue (triée)
            List<Resultat> expectedList = new List<Resultat> { r2, r3, r1 };
            //Résulat de GetSortedResultats()
            List<Resultat> myList = course.GetSortedResultats();

            Debug.WriteLine("myList 1 : " + myList[1].Temps );
            Debug.WriteLine("expectedList 1 : " + expectedList[1].Temps);

            CollectionAssert.AreEqual(expectedList, myList);

        }
    }
}