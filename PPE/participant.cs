using System.Collections.Generic;

namespace PPE
{
    public class participant
    {
        private int id;
        private string nom;
        private string prenom;
        private int type;
        private string adresse;
        private string mail;
        private int portable;

        public participant(int id, string nom, string prenom, int type, string adresse, string mail, int portable)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.adresse = adresse;
            this.mail = mail;
            this.portable = portable;
        }
        #region getter setter
        public int Id
        {
            get => id;
            set => id = value;
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

        #endregion
    }

    class participantAll : participant
    {
        private int id_atelierParticipant;
        private int hreBenevole;

        public participantAll(int id, string nom, string prenom, int type, string adresse, string mail, int portable, int id_atelierParticipant, int hreBenevole) :base(id, nom, prenom, type, adresse, mail, portable)
        {
            this.Id_atelierParticipant = id_atelierParticipant;
            this.HreBenevole = hreBenevole;
        }

        public int Id_atelierParticipant { get => id_atelierParticipant; set => id_atelierParticipant = value; }
        public int HreBenevole { get => hreBenevole; set => hreBenevole = value; }
    }
}