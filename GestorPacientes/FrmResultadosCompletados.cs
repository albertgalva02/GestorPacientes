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
    public partial class FrmResultadosCompletados : Form
    {
        ServicioResultado resultado;
        public int IdCita;
        public FrmResultadosCompletados(int id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            resultado = new ServicioResultado(connection);
            IdCita = id;
        }

        #region Eventos
        private void FrmResultadosCompletados_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        #endregion

        #region Metodos

        public void LoadData() 
        {
            DgvResultados.DataSource = resultado.GetResultadosCompletados(this.IdCita);
            DgvResultados.ClearSelection();
        }

        public void Volver() 
        {
            FrmCitas.instancia.Show();
            this.Close();
        }
        #endregion

        
    }
}
