namespace PPE
{
    public class benevole
    {
        private int id;
        private string demij;

        public benevole(int id, string demij)
        {
            this.id = id;
            this.demij = demij;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Demij
        {
            get => demij;
            set => demij = value;
        }
    }
}