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
    }
}
