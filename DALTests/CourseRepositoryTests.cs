using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Diagnostics;

namespace DAL.Tests
{
    [TestClass()]
    public class CourseRepositoryTests
    {
        [TestMethod()]
        public void FindByIdTest()
        {
            //Création d'une course de test et ajout dans la BDD 
            CourseRepository courseRepository = new CourseRepository();
            Course c = new Course("courseTest");
            courseRepository.Save(c);

            //Comparaison entre l'Id obtenu via la méthode FindById (myResult) 
            //et le véritable id de la course (expectedResult)
            int expectedResult = c.Id;
            int myResult = courseRepository.FindById(c.Id).Id;

            Debug.WriteLine("expectedResult : " + expectedResult, "; myResult : " + myResult);

            Assert.AreEqual(myResult, expectedResult);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            //On créé une course, un participant et un résultat 
            CourseRepository courseRepository = new CourseRepository();
            ResultatRepository resultatRepository = new ResultatRepository();
            ParticipantRepository participantRepository = new ParticipantRepository();

            Course c = new Course("courseTest");
            courseRepository.Save(c);
            Participant p = new Participant("test", "test");
            participantRepository.Save(p);

            Resultat r = new Resultat(c,p,new DateTime());
            resultatRepository.Save(r);

            //Ajout du résultat à la course 
            c.Resultats.Add(r);
            courseRepository.Save(c);

            int id = c.Id;

            //La course est-elle bien présente dans la bdd après son ajout ?
            if (courseRepository.FindById(c.Id).Id != id )
                Assert.Fail();

            //Suppression de la course
            courseRepository.Delete(c);

            Course result = courseRepository.FindById(id);
            Debug.WriteLine("Resultat GetById : " + result);

            //La course a-t-elle été supprimée ? Est-est elle bien absente dans la bdd ?
            Assert.AreEqual(result, null);
        }
    }
}