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
    public partial class FrmSelectPruebas : Form
    {
        ServicioPrueba prueba;
        ServicioCita cita;
        ServicioResultado resultado;
        private int index;
        int IdCita;
        public FrmSelectPruebas(int id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            prueba = new ServicioPrueba(connection);
            cita = new ServicioCita(connection);
            resultado = new ServicioResultado(connection);
            index = -1;
            IdCita = id;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSelectPruebas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DgvPruebas.DataSource = prueba.GetAll();
            DgvPruebas.ClearSelection();
        }

        public void Volver()
        {
            FrmCitas.instancia.Show();
            this.Close();
        }

        

        public void Aplicar() 
        {
            if (this.index >= 0)
            {
                foreach (DataGridViewRow item in DgvPruebas.SelectedRows)
                {
                    Resultados NuevoResultado = new Resultados
                    {
                        CedulaPaciente = cita.GetCedulaByCita(this.IdCita),
                        IdPrueba = Convert.ToInt32(item.Cells[0].Value.ToString()),
                        Estado = "P",
                        IdCita = this.IdCita
                    };

                    cita.ActualizaEstado("PR", this.IdCita);
                    resultado.Agregar(NuevoResultado);

                }

                MessageBox.Show("Pruebas Agregadas Exitosamente!");
                Volver();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar al menos una prueba de laboratorio");
            }
                       
        }

        public void Deseleccionar() 
        {
            DgvPruebas.ClearSelection();
            this.index = -1;
        }

        private void DgvPruebas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                this.index = e.RowIndex;
            }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            Aplicar();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
