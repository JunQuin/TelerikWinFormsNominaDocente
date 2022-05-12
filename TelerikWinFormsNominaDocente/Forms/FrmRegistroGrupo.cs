using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TelerikWinFormsNominaDocente.Class;

namespace TelerikWinFormsNominaDocente.Forms
{
    public partial class FrmRegistroGrupo : Telerik.WinControls.UI.RadForm
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

        public FrmRegistroGrupo()
        {
            InitializeComponent();
        }

        private void FrmRegistroGrupo_Load(object sender, EventArgs e)
        {
            LlenarDataTable();
            RadMessageBox.SetThemeName("FluentDark");
            radDropDownList1.SelectedIndex = 0;
        }

        private int LlenarDataTable()
        {
            var dataAdapter =
                new SqlDataAdapter(
                    "SELECT * FROM Grupos ORDER BY Grupos.GrupoID ",
                    _connection);
            dataAdapter.Fill(_dataTable);

            for (var i = 0; i < _dataTable.Rows.Count; i++)
                stringCollection.Add(_dataTable.Rows[i]["GrupoNombre"].ToString());

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

        private void BuscarGrupo(string nombre)
        {
            RadMessageBox.SetThemeName("FluentDark");
            clsConnection = new ClsConnection();
            clsConnection.ConnectionOpen();
            var sqlQuery =
                "SELECT * FROM Grupos WHERE GrupoNombre LIKE '%'+ @id +'%'";
            var sqlCommand = new SqlCommand(sqlQuery, clsConnection.Con);
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id", nombre);
            var sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                TxtNombre.Text = sqlDataReader["GrupoNombre"].ToString();
                id = Convert.ToInt32(sqlDataReader["GrupoID"]);
                status = (bool) sqlDataReader["GrupoStatus"];
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
                RadMessageBox.Show("Grupo no encontrado. :c", "Error", MessageBoxButtons.OK,
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
                _clsQueries.RegistrarGrupo(nombre, status);
                var nombrecompleto = nombre;
                TxtBusqueda.Text = nombrecompleto;
                LlenarDataTable();
                BuscarGrupo(nombrecompleto);
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
                _clsQueries.ActualizarGrupo(id, TxtNombre.Text);
                radProgressBar1.Value1 = 85;
                LlenarDataTable();
                radProgressBar1.Value1 = 90;
                var nombrecompleto = TxtNombre.Text;
                TxtBusqueda.Text = nombrecompleto;
                radProgressBar1.Value1 = 95;
                BuscarGrupo(nombrecompleto);
                radProgressBar1.Value1 = 100;
                radProgressBar1.Visible = false;
            }, this);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            radProgressBar1.Visible = true;
            radProgressBar1.Value1 = 80;
            _clsQueries.DesactivarGrupo(id);
            var nombrecompleto = TxtNombre.Text;
            TxtBusqueda.Text = nombrecompleto;
            BuscarGrupo(nombrecompleto);
            radProgressBar1.Visible = false;
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BuscarGrupo(TxtBusqueda.Text);

            if (e.KeyCode == Keys.Escape) DefaultForm();
        }

        private void DefaultForm()
        {
            TxtNombre.Clear();
            TxtBusqueda.Clear();
            radDropDownList1.SelectedIndex = 0;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = true;
            LblStatus.Visible = false;
        }
    }
}