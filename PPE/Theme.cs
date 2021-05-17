using System.Collections.Generic;

namespace PPE
{
    public class Theme
    {
        private int id;
        private string libelle;
        private List<Theme> lesThemes;

        public Theme(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        internal List<Theme> LesThemes { get => lesThemes; set => lesThemes = value; }

        public static List<Theme> listeTheme(int idAtelier)
        {
            return DAOTheme.getThemeByAtelier(idAtelier);
        }
    }
}