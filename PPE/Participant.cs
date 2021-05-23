using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Participant
    {
        private int id;
        private string nom;
        private string prenom;
        private int type;
        private string adresse;
        private string mail;
        private int numPortable;

        public Participant(int id, string nom, string prenom, int type, string adresse, string mail, int numPortable)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Type = type;
            this.Adresse = adresse;
            this.Mail = mail;
            this.NumPortable = numPortable;
        }

        #region Getter Setter
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }
        public int NumPortable { get => numPortable; set => numPortable = value; }
        public int Type { get => type; set => type = value; }
        #endregion


    }
}
