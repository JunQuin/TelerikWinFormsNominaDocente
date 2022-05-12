using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TelerikWinFormsNominaDocente.Class
{
    internal class ClsConnection
    {
        /*string consulta = @"Server=HP-OMEN-15;Database=ineiNominaDocentes;User Id=sa;Password=cereal123;Trusted_Connection=True;";

        SqlConnection conn;
        
        conn = new SqlConnection(consulta);
        conn.Open();*/

        private static string Conn()
        {
            string consulta = @"Server=HP-OMEN-15;Database=ineiNominaDocentes;User Id=sa;Password=cereal123;Trusted_Connection=True;";
            return consulta;
        }
        
        public SqlConnection Con;

        public void ConnectionOpen()
        {
            Con = new SqlConnection(Conn());
            Con.Open();
        }

        public void ConnectionClose()
        {
            Con.Close();
        }

        public string ConnectionStatus()
        {
            var msj = Con.State.ToString();
            return msj;
        }
    }
}
