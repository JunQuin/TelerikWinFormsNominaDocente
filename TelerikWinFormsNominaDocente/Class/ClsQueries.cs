using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Telerik.WinControls;
using TelerikWinFormsNominaDocente.Forms;

namespace TelerikWinFormsNominaDocente.Class
{
    internal class ClsQueries
    {
        ClsConnection clsConnection;
        
        public ClsQueries()
        {
            
        }

        readonly ClsFormControll _clsFormControll = new ClsFormControll();

        public void LoginQuery(string user, string password)
        {
            bool status = true;
            RadMessageBox.SetThemeName("FluentDark");
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();
            var sqlQuery = "SELECT TOP 1 * FROM Usuarios where UsuarioName = @user and UsuarioPassword = @password AND UsuarioStatus = @status;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@user", user);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlCommand.Parameters.AddWithValue("@status", status);
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
                _clsFormControll.clearLogin();
            }
            clsConnection.ConnectionClose();
        }

        #region Forms de Docente

        public void RegistrarDocente(string nombre, string apellido, string celular, string correo, bool status)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "INSERT INTO Docentes (DocenteNombre, DocenteApellidos, DocenteCelular, DocenteCorreo, DocenteStatus)" +
                           "VALUES(@nombre, @apellidos, @celular, @correo, @status);";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@apellidos", apellido);
            sqlCommand.Parameters.AddWithValue("@celular", celular);
            sqlCommand.Parameters.AddWithValue("@correo", correo);
            sqlCommand.Parameters.AddWithValue("@status", status);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        public void ActualizarDocente(int id, string nombre, string apellido, string celular, string correo)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "UPDATE Docentes SET DocenteNombre = @nombre, DocenteApellidos = @apellidos, DocenteCelular = @celular, DocenteCorreo = @correo, DocenteStatus = '1' WHERE DocenteID = @id;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@apellidos", apellido);
            sqlCommand.Parameters.AddWithValue("@celular", celular);
            sqlCommand.Parameters.AddWithValue("@correo", correo);
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }
        public void DesactivarDocente(int id)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "UPDATE Docentes SET DocenteStatus = '0' WHERE DocenteID = @id;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
                RadMessageBox.SetThemeName("FluentDark");
                RadMessageBox.Show("Docente Desactivado", "Exito", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        #endregion

        #region Forms Materias

        public void RegistrarMateria(string nombre, bool status)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "INSERT INTO Materias (MateriaNombre, MateriaStatus)" +
                           "VALUES(@nombre, @status);";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@status", status);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        public void ActualizarMateria(int id, string nombre)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "UPDATE Materias SET MateriaNombre = @nombre, MateriaStatus = '1' WHERE MateriaID = @id;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        public void DesactivarMateria(int id)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "UPDATE Materias SET MateriaStatus = '0' WHERE MateriaID = @id;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        #endregion

        #region Form Grupos

        public void RegistrarGrupo(string nombre, bool status)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "INSERT INTO Grupos (GrupoNombre, GrupoStatus)" +
                           "VALUES(@nombre, @status);";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@status", status);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        public void ActualizarGrupo(int id, string nombre)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "UPDATE Grupos SET GrupoNombre = @nombre, GrupoStatus = '1' WHERE GrupoID = @id;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", nombre);
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        public void DesactivarGrupo(int id)
        {
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();

            var sqlQuery = "UPDATE Grupos SET GrupoStatus = '0' WHERE GrupoID = @id;";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                RadMessageBox.Show("Error Generado. Detalles: " + e.ToString(), "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally
            {
                clsConnection.ConnectionClose();
            }
        }

        #endregion

    }
}
