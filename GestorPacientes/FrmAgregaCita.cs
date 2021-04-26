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
    public partial class FrmAgregaCita : Form
    {
        public int IdPac;
        public int IdMed;
        ServiciosMedico ServicioM;
        ServiciosPaciente ServicioP;
        ServicioCita cita;
        Medico medico;
        Paciente paciente;

        public FrmAgregaCita(int IdP, int IdM)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            IdPac     = IdP;
            IdMed     = IdM;
            ServicioP = new ServiciosPaciente(connection);
            ServicioM = new ServiciosMedico(connection);
            cita      = new ServicioCita(connection);
            paciente  = ServicioP.GetByID(IdP);
            medico    = ServicioM.GetByID(IdM);
            TbxPaciente.Text = paciente.Nombre+" "+ paciente.Apellido;
            TbxMedico.Text = medico.Nombre+" "+ medico.Apellido;
        }

        #region Eventos

        private void FrmAgregaCita_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        #endregion

        #region Metodos

        public void Agregar() 
        {
            if (TbxPaciente.Text == "" || TbxMedico.Text == "" || TbxCausa.Text == "" || DtpFecha.Text == "" || DtpHora.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else 
            {
                Cita NuevaCita = new Cita
                {
                    IdPaciente = this.IdPac,
                    IdMedico = this.IdMed,
                    Fecha = DtpFecha.Value.ToString("dd/MM/yyyy"),
                    Hora = DtpHora.Value.ToString("hh:mm:ss"),
                    Causa = TbxCausa.Text,
                    Estado = "PC"
                };

                cita.Agregar(NuevaCita);

                MessageBox.Show("Cita Agregada Exitosamente!");
                FrmCitas form = new FrmCitas();
                form.Show();
                this.Close();

            }
        }

        #endregion
    }
}
