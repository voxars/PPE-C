using System.Collections.Generic;

namespace PPE
{
    public class participant
    {
        private string nom;
        private string prenom;
        private int type;
        private string adresse;
        private string mail;
        private int portable;
        private int idAtelier;
        private int hreBenevole;

        public participant(string nom, string prenom, int type, string adresse, string mail, int portable, int idAtelier, int hreBenevole)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.adresse = adresse;
            this.mail = mail;
            this.portable = portable;
            this.idAtelier = idAtelier;
            this.hreBenevole = hreBenevole;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }

        public int Type
        {
            get => type;
            set => type = value;
        }

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public int Portable
        {
            get => portable;
            set => portable = value;
        }

        public int IdAtelier
        {
            get => idAtelier;
            set => idAtelier = value;
        }

        public int HreBenevole
        {
            get => hreBenevole;
            set => hreBenevole = value;
        }
        

    }
}