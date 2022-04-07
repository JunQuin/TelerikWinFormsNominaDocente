namespace TelerikWinFormsNominaDocente
{
    public partial class FrmLogin
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
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtUser = new Telerik.WinControls.UI.RadTextBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPictureBox1 = new Telerik.WinControls.UI.RadPictureBox();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37 = new Telerik.WinControls.RootRadElement();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.txtUser);
            this.radPanel1.Controls.Add(this.txtPassword);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanel1.Location = new System.Drawing.Point(12, 145);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(430, 203);
            this.radPanel1.TabIndex = 0;
            this.radPanel1.ThemeName = "FluentDark";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(164, 144);
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.CustomFontSize = 17F;
            this.radButton1.Size = new System.Drawing.Size(127, 47);
            this.radButton1.TabIndex = 5;
            this.radButton1.Text = "Entrar";
            this.radButton1.ThemeName = "FluentDark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            this.radButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radButton1_KeyDown);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel1.Location = new System.Drawing.Point(65, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(84, 32);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Usuario:";
            this.radLabel1.ThemeName = "FluentDark";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.txtUser.Location = new System.Drawing.Point(195, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.ShowClearButton = true;
            this.txtUser.Size = new System.Drawing.Size(200, 37);
            this.txtUser.TabIndex = 0;
            this.txtUser.ThemeName = "FluentDark";
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.txtPassword.Location = new System.Drawing.Point(195, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '☼';
            this.txtPassword.Size = new System.Drawing.Size(200, 37);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.ThemeName = "FluentDark";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel2.Location = new System.Drawing.Point(31, 89);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(118, 32);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Contraseña:";
            this.radLabel2.ThemeName = "FluentDark";
            // 
            // radPictureBox1
            // 
            this.radPictureBox1.DefaultImage = null;
            this.radPictureBox1.Image = global::TelerikWinFormsNominaDocente.Properties.Resources.LOGO_INEI_BLANCO_MEDIUM;
            this.radPictureBox1.Location = new System.Drawing.Point(89, 22);
            this.radPictureBox1.Name = "radPictureBox1";
            this.radPictureBox1.Size = new System.Drawing.Size(277, 89);
            this.radPictureBox1.TabIndex = 1;
            this.radPictureBox1.ThemeName = "FluentDark";
            // 
            // object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37
            // 
            this.object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37.CustomFontSize = 15F;
            this.object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37.Name = "object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37";
            this.object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37.StretchHorizontally = true;
            this.object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37.StretchVertically = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.ControlBox = false;
            this.Controls.Add(this.radPictureBox1);
            this.Controls.Add(this.radPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "FluentDark";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        public Telerik.WinControls.UI.RadTextBox txtUser;
        public Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPictureBox radPictureBox1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.RootRadElement object_f6bd2e22_5d07_43f9_bb6c_52293f7a1c37;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}