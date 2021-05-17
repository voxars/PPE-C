using System.Collections.Generic;

namespace PPE
{
    public class Intervenant
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