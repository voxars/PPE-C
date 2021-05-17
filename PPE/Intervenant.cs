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

        public Intervenant(int id, string prenom)
        {
            this.Id = id;
            this.Prenom = prenom;
        }

        public int Id { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        

    }
}
