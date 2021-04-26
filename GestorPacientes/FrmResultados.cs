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
    public partial class FrmResultados : Form
    {
        public int index;
        ServicioResultado resultado;
        public FrmResultados()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            resultado = new ServicioResultado(connection);
            index = -1;
        }

        #region Eventos
        private void FrmResultados_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        #endregion

        #region Metodos
        public void LoadData() 
        {
            DgvResultados.DataSource = resultado.GetAll();
            DgvResultados.ClearSelection();
        }

        public void Volver() 
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Close();
        }

        public void Report() 
        {
            if (this.index >= 0)
            {
                FrmReportarResultados form = new FrmReportarResultados(Convert.ToInt32(DgvResultados.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un resultado");
            }
        }

        public void a() 
        {
            if (this.index >= 0)
            {
                FrmReportarResultados form = new FrmReportarResultados(Convert.ToInt32(DgvResultados.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un resultado");
            }
        }

        public void Buscar() 
        {
            if (TbxCedula.Text == "") 
            {
                LoadData();
            }
            else
            {
                if (resultado.GetByCedula(TbxCedula.Text) >= 1)
                {
                    DgvResultados.DataSource = resultado.GetSearch(TbxCedula.Text);
                    DgvResultados.ClearSelection();
                }
                else 
                {
                    MessageBox.Show("No se han encontrado resultados");
                }
            }
        }

        public void Deseleccionar() 
        {
            DgvResultados.ClearSelection();
            this.index = -1;
        }


        #endregion

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            a();
        }
    }
}
