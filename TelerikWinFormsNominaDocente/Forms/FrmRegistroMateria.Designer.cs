namespace TelerikWinFormsNominaDocente.Forms
{
    partial class FrmRegistroMateria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.LblStatus = new Telerik.WinControls.UI.RadLabel();
            this.BtnActualizar = new Telerik.WinControls.UI.RadButton();
            this.TxtBusqueda = new Telerik.WinControls.UI.RadTextBox();
            this.BtnEliminar = new Telerik.WinControls.UI.RadButton();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radProgressBar1.Location = new System.Drawing.Point(236, 69);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radProgressBar1.SeparatorColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radProgressBar1.SeparatorColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radProgressBar1.SeparatorColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radProgressBar1.Size = new System.Drawing.Size(320, 24);
            this.radProgressBar1.TabIndex = 5;
            this.radProgressBar1.Text = "Progreso de la Operacion";
            this.radProgressBar1.ThemeName = "FluentDark";
            this.radProgressBar1.Visible = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radDropDownList1);
            this.radPanel1.Controls.Add(this.LblStatus);
            this.radPanel1.Controls.Add(this.BtnActualizar);
            this.radPanel1.Controls.Add(this.TxtBusqueda);
            this.radPanel1.Controls.Add(this.BtnEliminar);
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.BtnGuardar);
            this.radPanel1.Controls.Add(this.TxtNombre);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Location = new System.Drawing.Point(12, 106);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(760, 374);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "FluentDark";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoSize = false;
            this.radDropDownList1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDropDownList1.DropDownAnimationEnabled = true;
            this.radDropDownList1.DropDownHeight = 111;
            this.radDropDownList1.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown;
            this.radDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.radDropDownList1.EnableAlternatingItemColor = true;
            this.radDropDownList1.Enabled = false;
            this.radDropDownList1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            radListDataItem1.Text = "Activo";
            radListDataItem2.Text = "Inactivo";
            this.radDropDownList1.Items.Add(radListDataItem1);
            this.radDropDownList1.Items.Add(radListDataItem2);
            this.radDropDownList1.Location = new System.Drawing.Point(175, 134);
            this.radDropDownList1.Name = "radDropDownList1";
            // 
            // 
            // 
            this.radDropDownList1.RootElement.CustomFontSize = 15.25F;
            this.radDropDownList1.Size = new System.Drawing.Size(167, 32);
            this.radDropDownList1.TabIndex = 1;
            this.radDropDownList1.Text = "Seleccione una opción";
            this.radDropDownList1.ThemeName = "FluentDark";
            // 
            // LblStatus
            // 
            this.LblStatus.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.LblStatus.Location = new System.Drawing.Point(44, 18);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(157, 34);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Activo/Inactivo";
            this.LblStatus.ThemeName = "FluentDark";
            this.LblStatus.Visible = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualizar.BackgroundImage = global::TelerikWinFormsNominaDocente.Properties.Resources._1570021_update_icon32x32;
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.Font = new System.Drawing.Font("Segoe UI", 17.25F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnActualizar.Location = new System.Drawing.Point(299, 284);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(148, 72);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.ThemeName = "FluentDark";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtBusqueda.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtBusqueda.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.TxtBusqueda.Location = new System.Drawing.Point(309, 18);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TxtBusqueda.Size = new System.Drawing.Size(412, 32);
            this.TxtBusqueda.TabIndex = 5;
            this.TxtBusqueda.ThemeName = "FluentDark";
            this.TxtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyDown);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BackgroundImage = global::TelerikWinFormsNominaDocente.Properties.Resources._1570068_close_icon;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 17.25F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEliminar.Location = new System.Drawing.Point(499, 284);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(148, 72);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.ThemeName = "FluentDark";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel6.Location = new System.Drawing.Point(233, 18);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(70, 32);
            this.radLabel6.TabIndex = 5;
            this.radLabel6.Text = "Buscar";
            this.radLabel6.ThemeName = "FluentDark";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackgroundImage = global::TelerikWinFormsNominaDocente.Properties.Resources._1570021_add_icon;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 17.25F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.Location = new System.Drawing.Point(99, 284);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(148, 72);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.ThemeName = "FluentDark";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.TxtNombre.Location = new System.Drawing.Point(175, 78);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TxtNombre.Size = new System.Drawing.Size(317, 32);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.ThemeName = "FluentDark";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel3.Location = new System.Drawing.Point(44, 134);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 32);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Estatus:";
            this.radLabel3.ThemeName = "FluentDark";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel2.Location = new System.Drawing.Point(44, 78);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(90, 32);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Nombre:";
            this.radLabel2.ThemeName = "FluentDark";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Black;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 21.5F);
            this.radLabel1.Location = new System.Drawing.Point(192, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(401, 44);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Registro de datos de materias";
            this.radLabel1.ThemeName = "FluentDark";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).Text = "Registro de datos de materias";
            ((Telerik.WinControls.UI.RadLabelElement)(this.radLabel1.GetChildAt(0))).CustomFontSize = 21F;
            // 
            // FrmRegistroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistroMateria";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "FluentDark";
            this.Load += new System.EventHandler(this.FrmRegistroMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel LblStatus;
        private Telerik.WinControls.UI.RadButton BtnActualizar;
        private Telerik.WinControls.UI.RadTextBox TxtBusqueda;
        private Telerik.WinControls.UI.RadButton BtnEliminar;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
    }
}
