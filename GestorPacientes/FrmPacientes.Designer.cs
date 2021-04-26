
namespace GestorPacientes
{
    partial class FrmPacientes
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
            this.DgvPacientes = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CbxAlergias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.TbxCedula = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxDireccion = new System.Windows.Forms.TextBox();
            this.TbxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.DtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.CbxFumador = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnFoto = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.TblPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblPrincipal
            // 
            this.TblPrincipal.ColumnCount = 3;
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.069658F));
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.21487F));
            this.TblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.597403F));
            this.TblPrincipal.Controls.Add(this.DgvPacientes, 1, 1);
            this.TblPrincipal.Controls.Add(this.BtnVolver, 1, 2);
            this.TblPrincipal.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TblPrincipal.Name = "TblPrincipal";
            this.TblPrincipal.RowCount = 3;
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.91975F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.43827F));
            this.TblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.444445F));
            this.TblPrincipal.Size = new System.Drawing.Size(985, 615);
            this.TblPrincipal.TabIndex = 1;
            this.TblPrincipal.Click += new System.EventHandler(this.TblPrincipal_Click);
            // 
            // DgvPacientes
            // 
            this.DgvPacientes.AllowUserToAddRows = false;
            this.DgvPacientes.AllowUserToDeleteRows = false;
            this.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DgvPacientes.Location = new System.Drawing.Point(33, 304);
            this.DgvPacientes.MultiSelect = false;
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPacientes.Size = new System.Drawing.Size(923, 255);
            this.DgvPacientes.TabIndex = 0;
            this.DgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientes_CellClick);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.Location = new System.Drawing.Point(840, 565);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(116, 36);
            this.BtnVolver.TabIndex = 1;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.00505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.99495F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTitulo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.180327F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.81967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 295);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.65321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.34679F));
            this.tableLayoutPanel2.Controls.Add(this.CbxAlergias, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.TbxApellido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TbxNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TbxCedula, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.TbxDireccion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TbxTelefono, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.DtFechaNac, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.CbxFumador, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 262);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.tableLayoutPanel2_Click);
            // 
            // CbxAlergias
            // 
            this.CbxAlergias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxAlergias.FormattingEnabled = true;
            this.CbxAlergias.Location = new System.Drawing.Point(150, 232);
            this.CbxAlergias.Name = "CbxAlergias";
            this.CbxAlergias.Size = new System.Drawing.Size(422, 21);
            this.CbxAlergias.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiene Alergias:";
            // 
            // TbxApellido
            // 
            this.TbxApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApellido.Location = new System.Drawing.Point(150, 38);
            this.TbxApellido.Name = "TbxApellido";
            this.TbxApellido.Size = new System.Drawing.Size(422, 20);
            this.TbxApellido.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cedula:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNombre.Location = new System.Drawing.Point(150, 6);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(422, 20);
            this.TbxNombre.TabIndex = 6;
            // 
            // TbxCedula
            // 
            this.TbxCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCedula.Location = new System.Drawing.Point(150, 134);
            this.TbxCedula.Mask = "999-9999999-9";
            this.TbxCedula.Name = "TbxCedula";
            this.TbxCedula.Size = new System.Drawing.Size(422, 20);
            this.TbxCedula.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fumador";
            // 
            // TbxDireccion
            // 
            this.TbxDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxDireccion.Location = new System.Drawing.Point(150, 102);
            this.TbxDireccion.Name = "TbxDireccion";
            this.TbxDireccion.Size = new System.Drawing.Size(422, 20);
            this.TbxDireccion.TabIndex = 8;
            // 
            // TbxTelefono
            // 
            this.TbxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTelefono.Location = new System.Drawing.Point(150, 70);
            this.TbxTelefono.Mask = "999-999-9999";
            this.TbxTelefono.Name = "TbxTelefono";
            this.TbxTelefono.Size = new System.Drawing.Size(422, 20);
            this.TbxTelefono.TabIndex = 11;
            // 
            // DtFechaNac
            // 
            this.DtFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtFechaNac.Location = new System.Drawing.Point(150, 166);
            this.DtFechaNac.Name = "DtFechaNac";
            this.DtFechaNac.Size = new System.Drawing.Size(422, 20);
            this.DtFechaNac.TabIndex = 15;
            // 
            // CbxFumador
            // 
            this.CbxFumador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxFumador.FormattingEnabled = true;
            this.CbxFumador.Location = new System.Drawing.Point(150, 197);
            this.CbxFumador.Name = "CbxFumador";
            this.CbxFumador.Size = new System.Drawing.Size(422, 21);
            this.CbxFumador.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.PbFoto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.BtnFoto, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(584, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.31373F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.80882F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.22059F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 262);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // PbFoto
            // 
            this.PbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFoto.Location = new System.Drawing.Point(3, 3);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(330, 161);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 0;
            this.PbFoto.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.20261F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.1637F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74022F));
            this.tableLayoutPanel4.Controls.Add(this.BtnAgregar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnEditar, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnEliminar, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 211);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(330, 48);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAgregar.Location = new System.Drawing.Point(3, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(103, 42);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEditar.Location = new System.Drawing.Point(112, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(106, 42);
            this.BtnEditar.TabIndex = 0;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEliminar.Location = new System.Drawing.Point(224, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 42);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnFoto
            // 
            this.BtnFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFoto.Location = new System.Drawing.Point(3, 170);
            this.BtnFoto.Name = "BtnFoto";
            this.BtnFoto.Size = new System.Drawing.Size(330, 35);
            this.BtnFoto.TabIndex = 2;
            this.BtnFoto.Text = "Subir Foto";
            this.BtnFoto.UseVisualStyleBackColor = true;
            this.BtnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblTitulo, 2);
            this.LblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(347, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(229, 27);
            this.LblTitulo.TabIndex = 4;
            this.LblTitulo.Text = "Maestro de Pacientes";
            // 
            // FotoDialog
            // 
            this.FotoDialog.FileName = "openFileDialog1";
            this.FotoDialog.Title = "Seleccionar Foto";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 615);
            this.ControlBox = false;
            this.Controls.Add(this.TblPrincipal);
            this.Name = "FrmPacientes";
            this.Text = "Maestro de Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.TblPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPrincipal;
        private System.Windows.Forms.DataGridView DgvPacientes;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox TbxTelefono;
        private System.Windows.Forms.TextBox TbxDireccion;
        private System.Windows.Forms.TextBox TbxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.MaskedTextBox TbxCedula;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnFoto;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxAlergias;
        private System.Windows.Forms.DateTimePicker DtFechaNac;
        private System.Windows.Forms.ComboBox CbxFumador;
        private System.Windows.Forms.OpenFileDialog FotoDialog;
    }
}