using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Tests
{
    [TestClass()]
    public class CSVTests
    {
        [TestMethod()]
        public void ImportTest()
        {
            //Création des repositories
            ParticipantRepository participantRepository = new ParticipantRepository();
            ResultatRepository resultatRepository = new ResultatRepository();
            CourseRepository courseRepository  = new CourseRepository();

            //On crée une course et on l'ajoute à la BDD
            Course course = new Course("Test");
            courseRepository.Save(course);

            //On importe le CSV "CSV\\inscrits.csv"
            CSV csv = new CSV("..\\..\\..\\CSV\\inscrits.csv", course);
            csv.Import(participantRepository, resultatRepository, courseRepository);

            //On tente de retrouver la course importée dans la BDD
            Course courseBDD = courseRepository.FindById(course.Id);

            //Et on regarde si le nom du premier participant de la course dans la BDD correspond à celui du CSV importé
            Participant myResult = course.Resultats[0].Participant;
            Participant expectedResult = new Participant("Vignon", "Alexandre", new DateTime(1978, 11, 19), 'M', "alexv@mail.fr");

            Assert.AreEqual(expectedResult.Nom, myResult.Nom);
        }
    }



}