namespace PPE
{
    public class participant
    {
        private string nom;
        private string prenom;
        private string type;
        private string adresse;
        private string mail;
        private int portable;
        private int idAtelier;

        public participant(string nom, string prenom, string type, string adresse, string mail, int portable, int idAtelier)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.adresse = adresse;
            this.mail = mail;
            this.portable = portable;
            this.idAtelier = idAtelier;
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

        public string Type
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
    }
}