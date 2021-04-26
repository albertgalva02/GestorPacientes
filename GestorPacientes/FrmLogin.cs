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

    public sealed partial class FrmLogin : Form
    {
        ServiciosUsuario usuario;
        public static FrmLogin instancia { get; } = new FrmLogin();
        public string UserLog;
        public string PassLog; 
        public FrmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            usuario = new ServiciosUsuario(connection);
        }

        #region Eventos

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void TbxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Login();
            }
        }

        #endregion

        #region Metodos

        public void Login() 
        {
            if (TbxUsuario.Text == "" || TbxPass.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else 
            {
                if (usuario.Login(TbxUsuario.Text, TbxPass.Text) >= 1)
                {
                    UserLog = TbxUsuario.Text;
                    PassLog = TbxPass.Text;
                    LimpiarCampos();
                    FrmMenu form = new FrmMenu();
                    form.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Usuario o contraseñas incorrectos o no existen");
                }

            }
        }

        public void LimpiarCampos() 
        {
            TbxUsuario.Clear();
            TbxPass.Clear();
        }


        #endregion

        
    }
}
