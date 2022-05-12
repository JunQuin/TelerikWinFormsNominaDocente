using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Telerik.WinControls;
using TelerikWinFormsNominaDocente.Class;
using TelerikWinFormsNominaDocente.Forms;

namespace TelerikWinFormsNominaDocente.Class
{
    internal class ClsQueries
    {
        ClsConnection clsConnection;
        
        public ClsQueries()
        {
            
        }

        readonly ClsFormControll ClsFormControll = new ClsFormControll();

        public void LoginQuery(string user, string password)
        {
            RadMessageBox.SetThemeName("FluentDark");
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();
            var sqlQuery = "SELECT TOP 1 * FROM Users where userName = @user and userPassword = @password;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@user", user);
            sqlCommand.Parameters.AddWithValue("@password", password);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                clsConnection.ConnectionClose();
                FrmLandingPage frmLandingPage = new FrmLandingPage
                {
                    Text = "NOMINA DOCENTE - INSTITUTO DE NEGOCIOS E INNOVACION VER 1.1"
                };
                RadMessageBox.Show("Redireccionando", "Exito", MessageBoxButtons.OK, RadMessageIcon.Info);
                frmLandingPage.Show();
                FrmLogin.Form.Minimize();
            }
            else
            {
                clsConnection.ConnectionClose();
                RadMessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                ClsFormControll.clearLogin();
            }
            clsConnection.ConnectionClose();
        }
    }
}
