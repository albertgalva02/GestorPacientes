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
    public partial class FrmReportarResultados : Form
    {
        ServicioResultado resultado;
        public int IdResultado;
        public FrmReportarResultados(int id)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            resultado = new ServicioResultado(connection);
            IdResultado = id;
        }

        #region Eventos

        private void FrmReportarResultados_Load(object sender, EventArgs e)
        {

        }

        private void BtnReportar_Click(object sender, EventArgs e)
        {
            ReportarResultados();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        #endregion

        #region Metodos

        public void ReportarResultados() 
        {
            if (TbxResultado.Text == "")
            {
                MessageBox.Show("Debe escribir algun resultado");
            }
            else 
            {
                resultado.CerrarResultado(TbxResultado.Text, this.IdResultado);
                resultado.ActualizaEstado("C", this.IdResultado);

                MessageBox.Show("Resultado cerrado exitosamente!");
                Volver();
            }
                        
        }

        public void Volver() 
        {
            FrmResultados form = new FrmResultados();
            form.Show();
            this.Close();
        }

        #endregion
    }
}
