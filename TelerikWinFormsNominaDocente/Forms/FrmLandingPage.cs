using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TelerikWinFormsNominaDocente.Class;

namespace TelerikWinFormsNominaDocente.Forms
{
    public partial class FrmLandingPage : Telerik.WinControls.UI.RadForm
    {
        public FrmLandingPage()
        {
            InitializeComponent();
        }

        private void FrmLandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private readonly ClsFormControll _clsFormControll = new ClsFormControll();

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            _clsFormControll.OpenCapturaPrimeroSecundariaForm();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            _clsFormControll.OpenCapturaSegundoSecundariaForm();
        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            _clsFormControll.OpenRegistroDocenteForm();
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            _clsFormControll.OpenRegistroNomina();
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            _clsFormControll.OpenRegistroMateriaForm();
        }

        private void radMenuItem12_Click(object sender, EventArgs e)
        {
            _clsFormControll.OpenRegistroGrupoForm();
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {

        }
    }
}
