using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Resultat
    {
        public virtual int Id { get; set; }
        public virtual Course Course { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual DateTime Temps { get; set; }

        public Resultat()
        {

        }

        public Resultat(Course course, Participant participant, DateTime temps)
        {
            Course = course;
            Participant = participant;
            Temps = temps;
        }

        /// <summary>
        /// Vitesse moyenne en km/h arrondie à 2 décimales.
        /// </summary>
        /// <returns></returns>
        public virtual double GetVitesseMoyenne()
        {
            double courseLongueurKm = Course.Longueur/1000;
            double tempsHeures = GetTempsMinutes() / 60.0;
            double vitesseMoyenne = courseLongueurKm / tempsHeures;
            return Math.Round(vitesseMoyenne,2);
        }

        /// <summary>
        /// Allure moyenne en min/km arrondie à 2 décimales.
        /// </summary>
        /// <returns></returns>
        public virtual double GetAllureMoyenne()
        {
            double courseLongueurKm = Course.Longueur / 1000;
            double vitesseMoyenne = GetTempsMinutes() / courseLongueurKm;
            return Math.Round(vitesseMoyenne,2);
        }

        protected virtual int GetTempsMinutes()
        {
            return Temps.Minute + Temps.Hour * 60;
        }
    }
}
