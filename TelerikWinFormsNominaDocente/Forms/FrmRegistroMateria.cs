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
    public partial class FrmRegistroMateria : RadForm
    {
        private readonly ClsQueries _clsQueries = new ClsQueries();

        private readonly SqlConnection _connection = new SqlConnection(
            @"Server=HP-OMEN-15;Database=ineiNominaDocentes;User Id=sa;Password=cereal123;Trusted_Connection=True;");

        private readonly DataTable _dataTable = new DataTable();

        //a new instance of a backgroundWorker is created.

        private readonly BackgroundWorker _worker = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };

        private readonly AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();

        private ClsConnection clsConnection;

        private int id;

        private string nombre;

        private bool status;

        public FrmRegistroMateria()
        {
            InitializeComponent();
        }

        private void FrmRegistroMateria_Load(object sender, EventArgs e)
        {
            LlenarDataTable();
            RadMessageBox.SetThemeName("FluentDark");
            radDropDownList1.SelectedIndex = 0;
        }

        private int LlenarDataTable()
        {
            var dataAdapter =
                new SqlDataAdapter(
                    "SELECT Materias.* FROM Materias ORDER BY Materias.MateriaID ",
                    _connection);
            dataAdapter.Fill(_dataTable);

            for (var i = 0; i < _dataTable.Rows.Count; i++)
                stringCollection.Add(_dataTable.Rows[i]["MateriaNombre"].ToString());

            TxtBusqueda.AutoCompleteCustomSource = stringCollection;

            return 0;
        }

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
                    MessageBox.Show("Error");
            };
            _worker.RunWorkerAsync();
        }

        private void BuscarMateria(string nombre)
        {
            RadMessageBox.SetThemeName("FluentDark");
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();
            var sqlQuery =
                "SELECT * FROM Materias WHERE MateriaNombre LIKE '%'+ @id +'%'";
            var sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", nombre);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                TxtNombre.Text = sqlDataReader["MateriaNombre"].ToString();
                id = Convert.ToInt32(sqlDataReader["MateriaID"]);
                status = (bool) sqlDataReader["MateriaStatus"];
                clsConnection.ConnectionClose();

                if (status)
                {
                    LblStatus.ForeColor = Color.ForestGreen;
                    LblStatus.Visible = true;
                    LblStatus.Text = "Activo";
                    radDropDownList1.SelectedIndex = 0;
                    BtnGuardar.Enabled = false;
                    BtnActualizar.Enabled = true;
                    BtnEliminar.Enabled = true;
                }

                else
                {
                    LblStatus.ForeColor = Color.OrangeRed;
                    LblStatus.Visible = true;
                    LblStatus.Text = "Inactivo";
                    radDropDownList1.SelectedIndex = 1;
                    BtnEliminar.Enabled = false;
                    BtnGuardar.Enabled = false;
                    BtnActualizar.Enabled = true;
                }
            }
            else
            {
                clsConnection.ConnectionClose();
                RadMessageBox.Show("Materia no encontrada. :c", "Error", MessageBoxButtons.OK,
                    RadMessageIcon.Exclamation);
            }

            clsConnection.ConnectionClose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                nombre = TxtNombre.Text;
                status = true;
                _clsQueries.RegistrarMateria(nombre, status);
                var nombrecompleto = nombre;
                TxtBusqueda.Text = nombrecompleto;
                LlenarDataTable();
                BuscarMateria(nombrecompleto);
            }
            else
            {
                RadMessageBox.Show("Llene todos los campos!", "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ThreadSafe(() =>
            {
                radProgressBar1.Visible = true;
                radProgressBar1.Value1 = 80;
                _clsQueries.ActualizarMateria(id, TxtNombre.Text);
                radProgressBar1.Value1 = 85;
                LlenarDataTable();
                radProgressBar1.Value1 = 90;
                var nombrecompleto = TxtNombre.Text;
                TxtBusqueda.Text = nombrecompleto;
                radProgressBar1.Value1 = 95;
                BuscarMateria(nombrecompleto);
                radProgressBar1.Value1 = 100;
                radProgressBar1.Visible = false;
                /*RadMessageBox.SetThemeName("FluentDark");
                RadMessageBox.Show(
                    "Materia: " + TxtNombre.Text + ". Actualizada correctamente", "Exito",
                    MessageBoxButtons.OK, RadMessageIcon.Info);*/
            }, this);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            radProgressBar1.Visible = true;
            radProgressBar1.Value1 = 80;
            _clsQueries.DesactivarMateria(id);
            var nombrecompleto = TxtNombre.Text;
            TxtBusqueda.Text = nombrecompleto;
            BuscarMateria(nombrecompleto);
            radProgressBar1.Visible = false;
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscarMateria(TxtBusqueda.Text);

            if (e.KeyCode == Keys.Escape) DefaultForm();
        }

        private void DefaultForm()
        {
            TxtNombre.Clear();
            TxtBusqueda.Clear();
            radDropDownList1.SelectedIndex = 0;
            /* radDropDownList1.SelectedItem = null;
            radDropDownList1.Text = "Seleccione opción...";*/
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            LblStatus.Visible = false;
        }
    }
}