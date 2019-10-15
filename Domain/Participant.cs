using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Participant
    {
        public virtual int NumDossard { get; set; }
        public virtual string Nom { get; set;}
        public virtual string Prenom { get; set; }
		public virtual char Sexe { get; set; }
		public virtual DateTime DateNaissance { get; set;}
        public virtual string Mail { get; set; }
		public virtual string Licence { get; set; }
        public virtual List<Resultat> Resultat { get; set; }


        public Participant()
        {
        }

        public Participant(string nom, string prenom) : this()
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Participant(string nom, string prenom, DateTime dateNaissance, char sexe, string mail):this(nom,prenom)
        {
			Sexe = sexe;
			DateNaissance = dateNaissance;
			Mail = mail;
        }
		
		public Participant(string nom, string prenom, DateTime dateNaissance, char sexe, string mail, string licence):this(nom, prenom, dateNaissance, sexe, mail)
        {
            Licence = licence;
        }

        public override string ToString()
        {
            return "Participant n° : " + NumDossard + ", " + Prenom + " " + Nom;
        }

        public virtual int Age
        {
            get
            {
                int jours = DaysBetween(DateTime.Now, DateNaissance);
                int age = (int)(jours / 365.25);
                return age;
            }
        }

        private int DaysBetween(DateTime d1, DateTime d2)
        {
            int days = (int)(d1 - d2).TotalDays;

            return Math.Abs(days);
        }
    }
}
