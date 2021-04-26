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
    public partial class FrmCitaMedico : Form
    {
        public int IdPaciente;
        public int index;
        ServiciosMedico medico;
        public FrmCitaMedico(int id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            medico = new ServiciosMedico(connection);
            index = -1;
            IdPaciente = id;

        }

        #region Eventos

        private void FrmCitaMedico_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscaMedico();
        }

        private void DgvCitaMedico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;
            }
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            SeleccionarMedico();
        }

        #endregion

        #region Metodos

        public void BuscaMedico() 
        {
            int id_medico = medico.GetByCedula(TbxCedula.Text);

            if (TbxCedula.Text == "")
            {
                LoadData();
            }
            else
            {
                if (TbxCedula.Text == "")
                {
                    LoadData();
                }
                else
                {
                    if (id_medico >= 1)
                    {
                        DgvCitaMedico.DataSource = medico.GetSearch(id_medico);
                        DgvCitaMedico.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("No se han encontrado resultados");
                    }
                }
            }
        }

        public void SeleccionarMedico()
        {
            if (this.index >= 0)
            {
                FrmAgregaCita form = new FrmAgregaCita(IdPaciente, Convert.ToInt32(DgvCitaMedico.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente");
            }
        }

        public void LoadData()
        {
            DgvCitaMedico.DataSource = medico.GetAll();
            DgvCitaMedico.ClearSelection();
        }

        public void Deseleccionar()
        {
            TbxCedula.Clear();
            DgvCitaMedico.ClearSelection();
            this.index = -1;
        }


        #endregion

        
    }
}
