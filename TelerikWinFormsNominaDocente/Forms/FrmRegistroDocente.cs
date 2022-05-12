using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TelerikWinFormsNominaDocente.Class;

namespace TelerikWinFormsNominaDocente.Forms
{
    public partial class FrmRegistroDocente : RadForm
    {
        private readonly ClsQueries _clsQueries = new ClsQueries();

        private readonly SqlConnection _connection = new SqlConnection(
            @"Server=HP-OMEN-15;Database=ineiNominaDocentes;User Id=sa;Password=cereal123;Trusted_Connection=True;");

        private readonly DataTable _dataTable = new DataTable();

        private readonly AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();

        private ClsConnection clsConnection;

        private int id;

        private string nombre, apellido, celular, correo;

        private bool status;

        public FrmRegistroDocente()
        {
            InitializeComponent();

            _worker.RunWorkerCompleted += (sender, args) =>
            {

            };
        }

        private void FrmRegistroDocente_Load(object sender, EventArgs e)
        {
            LlenarDataTable();
            RadMessageBox.SetThemeName("FluentDark");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNombre.Text) && !string.IsNullOrWhiteSpace(TxtApellidos.Text) &&
                !string.IsNullOrWhiteSpace(TxtCelular.Text) && !string.IsNullOrWhiteSpace(TxtCorreo.Text))
            {
                nombre = TxtNombre.Text;
                apellido = TxtApellidos.Text;
                celular = TxtCelular.Text;
                correo = TxtCorreo.Text;
                status = true;
                _clsQueries.RegistrarDocente(nombre, apellido, celular, correo, status);
                var nombrecompleto = nombre + " " + apellido;
                TxtBusqueda.Text = nombrecompleto;
                LlenarDataTable();
                BuscarDocente(nombrecompleto);
            }
            else
            {
                RadMessageBox.Show("Llene todos los campos!", "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        private int LlenarDataTable()
        {
            var dataAdapter =
                new SqlDataAdapter(
                    "SELECT *, CONCAT_WS(' ', DocenteNombre, DocenteApellidos) as NombreCompleto from Docentes ORDER BY DocenteId",
                    _connection);
            dataAdapter.Fill(_dataTable);

            for (var i = 0; i < _dataTable.Rows.Count; i++)
            {
                stringCollection.Add(_dataTable.Rows[i]["NombreCompleto"].ToString());
            }

            TxtBusqueda.AutoCompleteCustomSource = stringCollection;

            return 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                radProgressBar1.Visible = true;
                radProgressBar1.Value1 = 80;
                _clsQueries.ActualizarDocente(id, TxtNombre.Text, TxtApellidos.Text, TxtCelular.Text, TxtCorreo.Text);
                radProgressBar1.Value1 = 85;
                LlenarDataTable();
                radProgressBar1.Value1 = 90;
                var nombrecompleto = TxtNombre.Text + " " + TxtApellidos.Text;
                TxtBusqueda.Text = nombrecompleto;
                radProgressBar1.Value1 = 95;
                BuscarDocente(nombrecompleto);
                radProgressBar1.Value1 = 100;
                radProgressBar1.Visible = false;
                RadMessageBox.SetThemeName("FluentDark");
                RadMessageBox.Show("Materia: " + TxtNombre.Text + " " + TxtApellidos.Text + ". Actualizada correctamente", "Exito", MessageBoxButtons.OK, RadMessageIcon.Info);
            }, this);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            radProgressBar1.Visible = true;
            radProgressBar1.Value1 = 80;
            _clsQueries.DesactivarDocente(id);
            var nombrecompleto = TxtNombre.Text + " " + TxtApellidos.Text;
            TxtBusqueda.Text = nombrecompleto;
            BuscarDocente(nombrecompleto);
            radProgressBar1.Visible = false;
        }

        //a new instance of a backgroundWorker is created.

        private readonly BackgroundWorker _worker = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true,
        };

        private void ThreadSafe(Action callback, Form form)
        {
            
            _worker.RunWorkerCompleted += (obj, e) =>
            {
                if (form.InvokeRequired)
                    form.Invoke(callback);
                else
                    callback();
                if (e.Cancelled)
                    MessageBox.Show("Se ha cancelado el proceso.");
                else if (e.Error != null)
                    MessageBox.Show("Error"+ e.Error);
            };
            _worker.RunWorkerAsync();
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscarDocente(TxtBusqueda.Text);

            if (e.KeyCode == Keys.Escape) DefaultForm();
        }

        private void BuscarDocente(string nombreCompleto)
        {
            RadMessageBox.SetThemeName("FluentDark");
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();
            var sqlQuery =
                "SELECT * FROM Docentes WHERE CONCAT(DocenteNombre, ' ', DocenteApellidos) like '%'+ @id +'%'";
            var sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", nombreCompleto);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                TxtNombre.Text = sqlDataReader["DocenteNombre"].ToString();
                TxtApellidos.Text = sqlDataReader["DocenteApellidos"].ToString();
                TxtCelular.Text = sqlDataReader["DocenteCelular"].ToString();
                TxtCorreo.Text = sqlDataReader["DocenteCorreo"].ToString();
                id = Convert.ToInt32(sqlDataReader["DocenteID"]);
                status = (bool) sqlDataReader["DocenteStatus"];
                clsConnection.ConnectionClose();

                if (status)
                {
                    LblStatus.ForeColor = Color.ForestGreen;
                    LblStatus.Visible = true;
                    LblStatus.Text = "Activo";
                    BtnGuardar.Enabled = false;
                    BtnActualizar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }

                else
                {
                    LblStatus.ForeColor = Color.OrangeRed;
                    LblStatus.Visible = true;
                    LblStatus.Text = "Inactivo";
                    BtnEliminar.Enabled = false;
                    BtnGuardar.Enabled = false;
                    BtnActualizar.Enabled = true;
                }
            }
            else
            {
                clsConnection.ConnectionClose();
                RadMessageBox.Show("Usuario No Encontrado :c", "Error", MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation);
            }

            clsConnection.ConnectionClose();
        }

        private void DefaultForm()
        {
            TxtNombre.Clear();
            TxtBusqueda.Clear();
            TxtApellidos.Clear();
            TxtCelular.Clear();
            TxtCorreo.Clear();
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            LblStatus.Visible = false;
        }
    }
}