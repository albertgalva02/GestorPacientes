using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using Database.Modelo;
using Database;
using System.Configuration;
using System.Data.SqlClient;

namespace GestorPacientes
{
    public partial class FrmCitaPaciente : Form
    {
        public int IdPaciente;
        public int index;
        ServiciosPaciente paciente;
        public FrmCitaPaciente()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            paciente = new ServiciosPaciente(connection);
            index = -1;
        }

        #region Eventos

        private void FrmCitaPaciente_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            SeleccionarPaciente();
        }

        private void DgvCitaPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                index = e.RowIndex;
            }
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscaPaciente();
        }

        #endregion

        #region Metodos

        public void BuscaPaciente()
        {
            int id_medico = paciente.GetByCedula(TbxCedula.Text);

            if (TbxCedula.Text == "")
            {
                LoadData();
            }
            else
            { 
                if (id_medico >= 1)
                {
                    DgvCitaPaciente.DataSource = paciente.GetSearch(id_medico);
                    DgvCitaPaciente.ClearSelection();

                }
                else
                {
                    MessageBox.Show("No se han encontrado resultados");
                }
            }
        }

        public void LoadData()
        {
            DgvCitaPaciente.DataSource = paciente.GetAll();
            DgvCitaPaciente.ClearSelection();
        }

        public void SeleccionarPaciente() 
        {
            if (this.index >= 0)
            {
                FrmCitaMedico form = new FrmCitaMedico(Convert.ToInt32(DgvCitaPaciente.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un paciente");
            }
        }

        public void Deseleccionar() 
        {
            TbxCedula.Clear();
            DgvCitaPaciente.ClearSelection();
            this.index = -1;
        }

        #endregion
               
    }
}
