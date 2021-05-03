using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class DAOAtelier
    {
        public static List<Atelier> getAtelier()
        {
            List<Atelier> lesAteliers = new List<Atelier>();
            string req = "Select * from atelier";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Atelier a = new Atelier(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), 
                    reader[3].ToString(), reader[4].ToString());
                lesAteliers.Add(a);
            }

            return lesAteliers;

        }

    }
}