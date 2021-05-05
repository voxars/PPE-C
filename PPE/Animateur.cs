using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class Animateur
    {
        private int id;
        private string nom;
        private string prenom;
        private string type;
        private string adresse;
        private string mail;
        private int numPortable;
        private List<Animateur> lesAnimateurs;

        public Animateur(int id, string nom, string prenom, string type, string adresse, string mail, int numPortable)
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
        public string Type { get => type; set => type = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }
        public int NumPortable { get => numPortable; set => numPortable = value; }
        internal List<Animateur> LesAnimateurs { get => lesAnimateurs; set => lesAnimateurs = value; }
        #endregion

        public static List<Animateur> listeAnimateur()
        {
            return DAOAnimateur.getAnimateur();
        }
        public void affecterAnimateur()
        {
            DAOAnimateur.affecterAnimateurBDD(this);
        }
    }
}
