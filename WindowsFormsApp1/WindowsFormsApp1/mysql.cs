using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class WorkBench
    {
        private MySqlConnection db;
        public WorkBench(string host, string username, string database, string password) =>
            db = new MySqlConnection($"server={host};User Id={username};database={database}; password={password}");
        public bool Quarry(string command)
        {
            try
            {
                db.Open();
                MySqlCommand msqlcmd = new MySqlCommand(command, db);
                msqlcmd.ExecuteNonQuery();
                db.Close();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }
        }
        public List<string[]> SELECT(string command, int QntTableElem)
        {
            try
            {
                db.Open();
                MySqlCommand msqlcmd = new MySqlCommand(command, db);
                MySqlDataReader mdr = msqlcmd.ExecuteReader();
                string[] aux;
                List<string[]> ListAux = new List<string[]>();
                while (mdr.Read())
                {
                    aux = new string[QntTableElem];
                    for (int i = 0; i < aux.Length; i++)
                        aux[i] = mdr.GetString(i);
                    ListAux.Add(aux);
                }
                db.Close();
                return ListAux;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return new List<string[]>();
            }
        }
    }
}
