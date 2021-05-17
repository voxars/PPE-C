namespace PPE
{
    public class type
    {
        private int id;
        private string libelle;

        public type(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Libelle
        {
            get => libelle;
            set => libelle = value;
        }
    }
}