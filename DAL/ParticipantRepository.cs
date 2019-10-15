using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ParticipantRepository:Repository
    {
        public List<Participant> GetAll()
        {
            return Session.Query<Participant>().ToList();
        }

        public Participant FindByDossard(int numDossard)
        {
            IList<Participant> participants = Session.Query<Participant>().Where(p => p.NumDossard == numDossard).ToList();

            if (participants.Count == 0) return null;
            else return participants[0]; ;
        }

        public List<Participant> FindByNom(string nom)
        {
            List<Participant> participants = Session.Query<Participant>().Where(p => p.Nom == nom).ToList();
            return participants;
        }


        public void Save(Participant participant)
        {
            Session.SaveOrUpdate(participant);
            Session.Flush();
        }



    }
}
