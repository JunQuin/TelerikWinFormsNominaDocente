using TelerikWinFormsNominaDocente.Forms;

namespace TelerikWinFormsNominaDocente.Class
{
    internal class ClsFormControll
    {
        #region Login
        public void clearLogin()
        {
            FrmLogin.Form.txtUser.Clear();
            FrmLogin.Form.txtPassword.Clear();
            FrmLogin.Form.txtUser.Focus();
        }
        #endregion

        #region Captura de horas

        /// <summary>
        /// OpenCapturaPrimeroSecundariaForm()
        /// Metodo Para abrir formulario de captura
        /// de primero de secundaria
        /// </summary>
        public void OpenCapturaPrimeroSecundariaForm()
        {
            FrmCapturaPrimeroSecundaria frmCapturaPrimero = new FrmCapturaPrimeroSecundaria
            {
                Text = "NOMINA DOCENTE - INSTITUTO DE NEGOCIOS E INNOVACION VER 1.1"
            };
            frmCapturaPrimero.Show();
        }

        #endregion
    }
}
