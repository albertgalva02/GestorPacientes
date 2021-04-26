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
    public partial class FrmResultadosCita : Form
    {
        ServicioCita cita;
        ServicioResultado resultado;
        public int IdCita;
        public FrmResultadosCita(int id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            cita = new ServicioCita(connection);
            resultado = new ServicioResultado(connection);
            IdCita = id;
        }

        public void Volver() 
        {
            FrmCitas form = new FrmCitas();
            form.Show();
            this.Close();
        }

        public void CompletarCita() 
        {
            cita.ActualizaEstado("C",this.IdCita);
            MessageBox.Show("Estado de la cita Actualizado. Ahora la cita se encuentra en estado 'Completada'");
            Volver();
        }

        public void LoadData() 
        {
            DgvPruebas.DataSource = resultado.GetResultadosCita(this.IdCita);
            DgvPruebas.ClearSelection();
        }

        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            CompletarCita();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void FrmResultadosCita_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
