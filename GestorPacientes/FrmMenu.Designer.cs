
namespace GestorPacientes
{
    partial class FrmMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMedicos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnPruebas = new System.Windows.Forms.Button();
            this.BtnPacientes = new System.Windows.Forms.Button();
            this.BtnResultados = new System.Windows.Forms.Button();
            this.BtnCitas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.80223F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.48166F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.55662F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnVolver, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.8254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.47619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01587F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnMedicos, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnUsuarios, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnPruebas, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnPacientes, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnResultados, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnCitas, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(77, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.20513F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.1282F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 215);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicos";
            // 
            // BtnMedicos
            // 
            this.BtnMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMedicos.Enabled = false;
            this.BtnMedicos.Location = new System.Drawing.Point(45, 109);
            this.BtnMedicos.Name = "BtnMedicos";
            this.BtnMedicos.Size = new System.Drawing.Size(140, 41);
            this.BtnMedicos.TabIndex = 1;
            this.BtnMedicos.Text = "Medicos";
            this.BtnMedicos.UseVisualStyleBackColor = true;
            this.BtnMedicos.Click += new System.EventHandler(this.BtnMedicos_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administracion";
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUsuarios.Enabled = false;
            this.BtnUsuarios.Location = new System.Drawing.Point(45, 51);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(140, 40);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnPruebas
            // 
            this.BtnPruebas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPruebas.Enabled = false;
            this.BtnPruebas.Location = new System.Drawing.Point(45, 167);
            this.BtnPruebas.Name = "BtnPruebas";
            this.BtnPruebas.Size = new System.Drawing.Size(140, 41);
            this.BtnPruebas.TabIndex = 2;
            this.BtnPruebas.Text = "Pruebas de Laboratorio";
            this.BtnPruebas.UseVisualStyleBackColor = true;
            this.BtnPruebas.Click += new System.EventHandler(this.BtnPruebas_Click);
            // 
            // BtnPacientes
            // 
            this.BtnPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPacientes.Enabled = false;
            this.BtnPacientes.Location = new System.Drawing.Point(275, 50);
            this.BtnPacientes.Name = "BtnPacientes";
            this.BtnPacientes.Size = new System.Drawing.Size(140, 42);
            this.BtnPacientes.TabIndex = 3;
            this.BtnPacientes.Text = "Pacientes";
            this.BtnPacientes.UseVisualStyleBackColor = true;
            this.BtnPacientes.Click += new System.EventHandler(this.BtnPacientes_Click);
            // 
            // BtnResultados
            // 
            this.BtnResultados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnResultados.Enabled = false;
            this.BtnResultados.Location = new System.Drawing.Point(275, 167);
            this.BtnResultados.Name = "BtnResultados";
            this.BtnResultados.Size = new System.Drawing.Size(140, 41);
            this.BtnResultados.TabIndex = 5;
            this.BtnResultados.Text = "Resultados";
            this.BtnResultados.UseVisualStyleBackColor = true;
            this.BtnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // BtnCitas
            // 
            this.BtnCitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCitas.Enabled = false;
            this.BtnCitas.Location = new System.Drawing.Point(275, 108);
            this.BtnCitas.Name = "BtnCitas";
            this.BtnCitas.Size = new System.Drawing.Size(140, 43);
            this.BtnCitas.TabIndex = 4;
            this.BtnCitas.Text = "Citas";
            this.BtnCitas.UseVisualStyleBackColor = true;
            this.BtnCitas.Click += new System.EventHandler(this.BtnCitas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Principal";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(544, 276);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(76, 36);
            this.BtnVolver.TabIndex = 2;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 315);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnResultados;
        private System.Windows.Forms.Button BtnCitas;
        private System.Windows.Forms.Button BtnPacientes;
        private System.Windows.Forms.Button BtnPruebas;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnMedicos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVolver;
    }
}