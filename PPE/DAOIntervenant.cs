using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE
{
    class DAOIntervenant
    {
        public static void affecterIntervenantBDD(int idAtelier, int idIntervenant)
        {
            string requete = "insert into intervenant values (" + idIntervenant + "," + idAtelier + ")";

            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }

    }
}
