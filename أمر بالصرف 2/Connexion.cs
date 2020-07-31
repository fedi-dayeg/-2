using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace أمر_بالصرف_2
{
    public class Connexion
    {
        public OleDbConnection ConnectionDb()
        {
            string setConn = @"Data Source=""D:\centre\centre.accdb"";
Provider=""Microsoft.ACE.OLEDB.12.0""; 
User ID=Admin";

            OleDbConnection Connection = new OleDbConnection(setConn);

            try
            {
                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Connexion a la base de donne impossible !!" + e, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return Connection;
        }
    }
}
