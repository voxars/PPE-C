using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class DAOIntervenant
    {
        public static List<Intervenant> getIntervenantByAtelier(int idAtelier)
        {
            List<Intervenant> lesIntervenants = new List<Intervenant>();
            string req = "select i.id, prenom from intervenant i join participant p on i.id=p.id where id_atelier=" + idAtelier;
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Intervenant a = new Intervenant(int.Parse(reader[0].ToString()), reader[1].ToString());
                lesIntervenants.Add(a);
            }

            return lesIntervenants;
        }

    }
}
