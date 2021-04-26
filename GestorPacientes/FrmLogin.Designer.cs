
namespace GestorPacientes
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.TblCampos = new System.Windows.Forms.TableLayoutPanel();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TblPrincipal.SuspendLayout();
            this.TblCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblPrincipal
            // 
            this.TblPrincipal.ColumnCount = 3;
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.681818F));
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.78409F));
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.TblPrincipal.Controls.Add(this.TblCampos, 1, 1);
            this.TblPrincipal.Controls.Add(this.LblTitulo, 1, 0);
            this.TblPrincipal.Controls.Add(this.BtnLogin, 1, 2);
            this.TblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TblPrincipal.Name = "TblPrincipal";
            this.TblPrincipal.RowCount = 3;
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.08823F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.36765F));
            this.TblPrincipal.Size = new System.Drawing.Size(373, 254);
            this.TblPrincipal.TabIndex = 0;
            // 
            // TblCampos
            // 
            this.TblCampos.ColumnCount = 2;
            this.TblCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75248F));
            this.TblCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24753F));
            this.TblCampos.Controls.Add(this.TbxPass, 1, 1);
            this.TblCampos.Controls.Add(this.LblUsuario, 0, 0);
            this.TblCampos.Controls.Add(this.LblPass, 0, 1);
            this.TblCampos.Controls.Add(this.TbxUsuario, 1, 0);
            this.TblCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblCampos.Location = new System.Drawing.Point(24, 45);
            this.TblCampos.Name = "TblCampos";
            this.TblCampos.RowCount = 2;
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.14286F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.85714F));
            this.TblCampos.Size = new System.Drawing.Size(322, 141);
            this.TblCampos.TabIndex = 1;
            // 
            // TbxPass
            // 
            this.TbxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPass.Location = new System.Drawing.Point(82, 92);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.PasswordChar = '*';
            this.TbxPass.Size = new System.Drawing.Size(237, 20);
            this.TbxPass.TabIndex = 6;
            this.TbxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPass_KeyPress);
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(3, 25);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(73, 13);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblPass
            // 
            this.LblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(3, 95);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(73, 13);
            this.LblPass.TabIndex = 4;
            this.LblPass.Text = "Contraseña:";
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUsuario.Location = new System.Drawing.Point(82, 21);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(237, 20);
            this.TbxUsuario.TabIndex = 5;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(137, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(96, 42);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Login";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLogin.Location = new System.Drawing.Point(96, 192);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(178, 41);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Ingresar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 254);
            this.Controls.Add(this.TblPrincipal);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.TblPrincipal.ResumeLayout(false);
            this.TblPrincipal.PerformLayout();
            this.TblCampos.ResumeLayout(false);
            this.TblCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPrincipal;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TableLayoutPanel TblCampos;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.Label LblTitulo;
    }
}

