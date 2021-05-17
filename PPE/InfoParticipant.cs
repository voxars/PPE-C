namespace PPE
{
    public class InfoParticipant
    {
        private string nom;
        private string atelier;
        private string type;


        public InfoParticipant(string nom, string atelier, string type)
        {
            this.nom = nom;
            this.atelier = atelier;
            this.type = type;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Atelier
        {
            get => atelier;
            set => atelier = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }
    }
}