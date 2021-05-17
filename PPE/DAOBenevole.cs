using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PPE
{
    public class DAOBenevole
    {
        public static List<benevole> GetInfoJ()
        {
            List<benevole> infoJ = new List<benevole>();
            string req = "Select * from hreBenevole";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                benevole a = new benevole(Convert.ToInt32(reader[0].ToString()), reader[1].ToString());
                infoJ.Add(a);
            }

            
            return infoJ;
        }
    }
}