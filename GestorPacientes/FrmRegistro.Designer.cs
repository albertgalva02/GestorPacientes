
namespace GestorPacientes
{
    partial class FrmRegistro
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
            this.TblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TblCampos = new System.Windows.Forms.TableLayoutPanel();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.TbxCorreo = new System.Windows.Forms.TextBox();
            this.TbxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxPass2 = new System.Windows.Forms.TextBox();
            this.CbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.TblPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TblCampos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TblPrincipal
            // 
            this.TblPrincipal.ColumnCount = 3;
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.040323F));
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.12096F));
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.777778F));
            this.TblPrincipal.Controls.Add(this.LblTitulo, 1, 0);
            this.TblPrincipal.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.TblPrincipal.Controls.Add(this.BtnVolver, 1, 3);
            this.TblPrincipal.Controls.Add(this.DgvUsuarios, 1, 2);
            this.TblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TblPrincipal.Name = "TblPrincipal";
            this.TblPrincipal.RowCount = 4;
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.25675F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.3662F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15493F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.965517F));
            this.TblPrincipal.Size = new System.Drawing.Size(856, 577);
            this.TblPrincipal.TabIndex = 0;
            this.TblPrincipal.Click += new System.EventHandler(this.TblPrincipal_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(317, 12);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(222, 29);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Maestro de Usuarios";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.11392F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.88608F));
            this.tableLayoutPanel1.Controls.Add(this.TblCampos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 192);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TblCampos
            // 
            this.TblCampos.ColumnCount = 2;
            this.TblCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.08032F));
            this.TblCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.58635F));
            this.TblCampos.Controls.Add(this.TbxPass, 1, 5);
            this.TblCampos.Controls.Add(this.TbxUsuario, 1, 4);
            this.TblCampos.Controls.Add(this.TbxCorreo, 1, 2);
            this.TblCampos.Controls.Add(this.TbxApellido, 1, 1);
            this.TblCampos.Controls.Add(this.label2, 0, 0);
            this.TblCampos.Controls.Add(this.label8, 0, 6);
            this.TblCampos.Controls.Add(this.label7, 0, 5);
            this.TblCampos.Controls.Add(this.label6, 0, 4);
            this.TblCampos.Controls.Add(this.label5, 0, 3);
            this.TblCampos.Controls.Add(this.label4, 0, 2);
            this.TblCampos.Controls.Add(this.label3, 0, 1);
            this.TblCampos.Controls.Add(this.TbxPass2, 1, 6);
            this.TblCampos.Controls.Add(this.CbxTipoUsuario, 1, 3);
            this.TblCampos.Controls.Add(this.TbxNombre, 1, 0);
            this.TblCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblCampos.Location = new System.Drawing.Point(3, 3);
            this.TblCampos.Name = "TblCampos";
            this.TblCampos.RowCount = 7;
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02367F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02367F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02367F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02367F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49704F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91124F));
            this.TblCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.49704F));
            this.TblCampos.Size = new System.Drawing.Size(522, 186);
            this.TblCampos.TabIndex = 0;
            this.TblCampos.Click += new System.EventHandler(this.TblCampos_Click);
            // 
            // TbxPass
            // 
            this.TbxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPass.Location = new System.Drawing.Point(160, 133);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.PasswordChar = '*';
            this.TbxPass.Size = new System.Drawing.Size(359, 20);
            this.TbxPass.TabIndex = 14;
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUsuario.Location = new System.Drawing.Point(160, 107);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(359, 20);
            this.TbxUsuario.TabIndex = 13;
            // 
            // TbxCorreo
            // 
            this.TbxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCorreo.Location = new System.Drawing.Point(160, 55);
            this.TbxCorreo.Name = "TbxCorreo";
            this.TbxCorreo.Size = new System.Drawing.Size(359, 20);
            this.TbxCorreo.TabIndex = 11;
            // 
            // TbxApellido
            // 
            this.TbxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApellido.Location = new System.Drawing.Point(160, 29);
            this.TbxApellido.Name = "TbxApellido";
            this.TbxApellido.Size = new System.Drawing.Size(359, 20);
            this.TbxApellido.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Confirmar Contraseña:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de Usuario:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            // 
            // TbxPass2
            // 
            this.TbxPass2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPass2.Location = new System.Drawing.Point(160, 161);
            this.TbxPass2.Name = "TbxPass2";
            this.TbxPass2.PasswordChar = '*';
            this.TbxPass2.Size = new System.Drawing.Size(359, 20);
            this.TbxPass2.TabIndex = 12;
            // 
            // CbxTipoUsuario
            // 
            this.CbxTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxTipoUsuario.FormattingEnabled = true;
            this.CbxTipoUsuario.Location = new System.Drawing.Point(160, 81);
            this.CbxTipoUsuario.Name = "CbxTipoUsuario";
            this.CbxTipoUsuario.Size = new System.Drawing.Size(359, 21);
            this.CbxTipoUsuario.TabIndex = 15;
            // 
            // TbxNombre
            // 
            this.TbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNombre.Location = new System.Drawing.Point(160, 3);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(359, 20);
            this.TbxNombre.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnEliminar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnEditar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnRegistrar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(531, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(231, 186);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.tableLayoutPanel2_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.Location = new System.Drawing.Point(48, 127);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(134, 45);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditar.Location = new System.Drawing.Point(48, 65);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(134, 42);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegistrar.Location = new System.Drawing.Point(48, 3);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRegistrar.Size = new System.Drawing.Size(134, 46);
            this.BtnRegistrar.TabIndex = 0;
            this.BtnRegistrar.Text = "Registrarse";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.Location = new System.Drawing.Point(666, 526);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(145, 36);
            this.BtnVolver.TabIndex = 1;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToOrderColumns = true;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvUsuarios.Location = new System.Drawing.Point(46, 242);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(765, 278);
            this.DgvUsuarios.TabIndex = 3;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 577);
            this.ControlBox = false;
            this.Controls.Add(this.TblPrincipal);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.TblPrincipal.ResumeLayout(false);
            this.TblPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TblCampos.ResumeLayout(false);
            this.TblCampos.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPrincipal;
        private System.Windows.Forms.TableLayoutPanel TblCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxCorreo;
        private System.Windows.Forms.TextBox TbxApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.TextBox TbxPass2;
        private System.Windows.Forms.ComboBox CbxTipoUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.DataGridView DgvUsuarios;
    }
}