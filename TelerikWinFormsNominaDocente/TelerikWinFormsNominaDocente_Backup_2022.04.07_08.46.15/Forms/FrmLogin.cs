using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TelerikWinFormsNominaDocente.Class;

namespace TelerikWinFormsNominaDocente
{
    public partial class FrmLogin : Telerik.WinControls.UI.RadForm
    {
        public static FrmLogin Form;
        public FrmLogin()
        {
            Form = this;
            InitializeComponent();
        }

        private readonly ClsQueries _clsQueries = new ClsQueries();

        private void radButton1_Click(object sender, EventArgs e)
        {
            _clsQueries.LoginQuery(txtUser.Text, txtPassword.Text);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _clsQueries.LoginQuery(txtUser.Text, txtPassword.Text);
            }
            
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void radButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private readonly ClsFormControll _clsFormControll = new ClsFormControll();

        public void Minimize()
        {
            _clsFormControll.clearLogin();
            this.Hide();
            this.ShowInTaskbar = false;
        }
    }
}
