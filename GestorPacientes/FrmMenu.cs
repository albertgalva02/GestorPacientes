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
using System.Data.SqlClient;
using System.Configuration;

namespace GestorPacientes
{
    public partial class FrmMenu : Form
    {
        //public static FrmMenu instancia { get; } = new FrmMenu();
        ServiciosUsuario usuario;
        
        public FrmMenu()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            usuario = new ServiciosUsuario(connection);
        }

        #region Eventos

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmRegistro form = new FrmRegistro();
            form.Show();
            this.Hide();
        }

        private void BtnMedicos_Click(object sender, EventArgs e)
        {
            FrmMedicos form = new FrmMedicos();
            form.Show();
            this.Hide();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            FrmPacientes form = new FrmPacientes();
            form.Show();
            this.Hide();
        }

        private void BtnPruebas_Click(object sender, EventArgs e)
        {
            FrmPrueba form = new FrmPrueba();
            form.Show();
            this.Hide();
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            FrmCitas form = new FrmCitas();
            form.Show();
            this.Hide();
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            FrmResultados form = new FrmResultados();
            form.Show();
            this.Hide();
        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Seguridad();
        }

        #endregion

        #region Metodos
        public void Volver() 
        {
            FrmLogin.instancia.UserLog = null;
            FrmLogin.instancia.PassLog = null;
            FrmLogin.instancia.Show();
            this.Close();
        }

        public void Seguridad() 
        {

            if (usuario.GetTipoUsuario(FrmLogin.instancia.UserLog, FrmLogin.instancia.PassLog) == "A")
            {
                BtnUsuarios.Enabled = true;
                BtnMedicos.Enabled = true;
                BtnPruebas.Enabled = true;
            }
            else if (usuario.GetTipoUsuario(FrmLogin.instancia.UserLog, FrmLogin.instancia.PassLog) == "M")
            {
                BtnPacientes.Enabled = true;
                BtnCitas.Enabled = true;
                BtnResultados.Enabled = true;
            } 
            else if (usuario.GetTipoUsuario(FrmLogin.instancia.UserLog, FrmLogin.instancia.PassLog) == "SA") 
            {
                BtnUsuarios.Enabled = true;
                BtnMedicos.Enabled = true;
                BtnPruebas.Enabled = true;
                BtnPacientes.Enabled = true;
                BtnCitas.Enabled = true;
                BtnResultados.Enabled = true;
            }
        }



        #endregion

        
    }
}
