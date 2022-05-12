using System;
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
            FrmCapturaPrimeroSecundaria frmCapturaPrimeroSecundaria = new FrmCapturaPrimeroSecundaria
            {
                Text = "NOMINA DOCENTE - INSTITUTO DE NEGOCIOS E INNOVACION VER 1.1"
            };
            frmCapturaPrimeroSecundaria.ShowDialog();
        }

        /// <summary>
        /// OpenCapturaPrimeroSecundariaForm()
        /// Metodo Para abrir formulario de captura
        /// de primero de secundaria
        /// </summary>
        public void OpenCapturaSegundoSecundariaForm()
        {
            FrmCapturaSegundoSecundaria frmCapturaSegundoSecundaria = new FrmCapturaSegundoSecundaria
            {
                Text = "Captura de Datos - Segundo de Secundaria"
            };
            frmCapturaSegundoSecundaria.ShowDialog();
        }

        #endregion

        #region Abrir Editor de materias

        public void OpenRegistroMateriaForm()
        {
            FrmRegistroMateria frmCapturaMateria = new FrmRegistroMateria
            {
                Text = "Registro de Datos - Materias",
            };
            frmCapturaMateria.ShowDialog();
        }
        

        #endregion


        #region Registro de datos

        public void OpenRegistroDocenteForm()
        {
            FrmRegistroDocente frmRegistroDocente = new FrmRegistroDocente
            {
                Text = "Registro de Datos - Docentes",
            };
            frmRegistroDocente.ShowDialog();
        }

        public void OpenRegistroGrupoForm()
        {
            FrmRegistroGrupo frmRegistroGrupo = new FrmRegistroGrupo
            {
                Text = "Registro de Datos - Grupos",
            };
            frmRegistroGrupo.ShowDialog();
        }

        public void OpenRegistroNomina()
        {
            FrmRegistroNomina frmRegistroNomina = new FrmRegistroNomina
            {
                Text = "Registro de Datos - Nomina",
            };
            frmRegistroNomina.ShowDialog();
        }

        #endregion
    }
}
