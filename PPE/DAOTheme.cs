using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE
{
    public class DAOTheme
    {
        public static List<Theme> getThemeByAtelier(int idAtelier)
        {
            List<Theme> lesThemes = new List<Theme>();
            string req = "select id, libelle from theme where id_atelier=" + idAtelier;
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Theme t = new Theme(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesThemes.Add(t);
            }

            return lesThemes;
        }
    }
}