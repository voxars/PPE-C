using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Intervenant
    {
        int id;
        string prenom;
        private List<Intervenant> lesIntervenants;

        public Intervenant(int id, string prenom)
        {
            this.Id = id;
            this.Prenom = prenom;
        }

        public int Id { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal List<Intervenant> LesIntervenants { get => lesIntervenants; set => lesIntervenants = value; }

        public static List<Intervenant> listeIntervenant(int idAtelier)
        {
            return DAOIntervenant.getIntervenantByAtelier(idAtelier);
        }

    }
}
