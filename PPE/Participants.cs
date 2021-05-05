namespace PPE
{
    public class Participants
    {
        private string nom;
        private string prenom;
        private string type;
        private string adresse;
        private string mail;
        private int portable;
        private string login;
        private string password;


        public Participants(string nom, string prenom, string type, string adresse, string mail, int portable, string login, string password)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.type = type;
            this.adresse = adresse;
            this.mail = mail;
            this.portable = portable;
            this.login = login;
            this.password = password;
        }

        #region Setter Getter

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

        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        #endregion
        
    }
}