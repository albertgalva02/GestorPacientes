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
    public sealed partial class FrmCitas : Form
    {
        public static FrmCitas instancia { get; } = new FrmCitas();
        public int index;
        ServicioCita cita;
        public FrmCitas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            cita = new ServicioCita(connection);
            index = -1;

        }

        #region Eventos

        private void tableLayoutPanel4_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            Deseleccionar();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
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

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void BtnPendienteConsulta_Click(object sender, EventArgs e)
        {
            AgregarPruebas();
        }

        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            ConsultarResultados();
        }

        private void DgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;

                if (cita.GetEstadoCita(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString())) == "PC")
                {
                    BtnPendienteConsulta.Enabled = true;
                    BtnCompletar.Enabled = false;
                    BtnPendienteResultados.Enabled = false;
                } 
                else if (cita.GetEstadoCita(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString())) == "PR") 
                {
                    BtnPendienteResultados.Enabled = true;
                    BtnPendienteConsulta.Enabled = false;
                    BtnCompletar.Enabled = false;
                }
                else if (cita.GetEstadoCita(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString())) == "C")
                {
                    BtnCompletar.Enabled = true;
                    BtnPendienteResultados.Enabled = false;
                    BtnPendienteConsulta.Enabled = false;
                }   

            }
        }

        private void BtnPendienteResultados_Click(object sender, EventArgs e)
        {
            CompletarCita();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        #endregion

        #region Metodos


        public void Agregar() 
        {
            FrmCitaPaciente form = new FrmCitaPaciente();
            form.Show();
            Deseleccionar();
            this.Hide();
        }

        public void AgregarPruebas()
        {
            if (this.index >= 0)
            {
                FrmSelectPruebas form = new FrmSelectPruebas(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                Deseleccionar();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita");
            }

        }

        public void CompletarCita() 
        {
            if (this.index >= 0)
            {
                FrmResultadosCita form = new FrmResultadosCita(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                Deseleccionar();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar una cita");
            }
        }

        public void ConsultarResultados()
        {
            if (this.index >= 0)
            {
                FrmResultadosCompletados form = new FrmResultadosCompletados(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString()));
                form.Show();
                Deseleccionar();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita");
            }
        }

        public void Volver()
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Close();
        }

        public void LoadData()
        {
            DgvCitas.DataSource = cita.LoadData();
            DgvCitas.ClearSelection();
        }

        public void Deseleccionar()
        {
            DgvCitas.ClearSelection();
            this.index = -1;
            BtnCompletar.Enabled = false;
            BtnPendienteConsulta.Enabled = false;
            BtnPendienteResultados.Enabled = false;
        }

        public void Eliminar() 
        {
            if (this.index >= 0)
            {

                DialogResult opcion = MessageBox.Show("Esta seguro de que desea eliminar esta cita?" +
                    "si lo hace, tambien seran eliminados todos los resultados pertenecientes " +
                    "a la misma", "advertencia", MessageBoxButtons.OKCancel);

                if (opcion == DialogResult.OK)
                {
                    cita.Eliminar(Convert.ToInt32(DgvCitas.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Cita Eliminada Exitosamente");
                    Deseleccionar();
                    LoadData();
                }
            }
            else 
            {
                MessageBox.Show("Debe seleccionar una cita");
            }
        }


        #endregion

        
    }
}
