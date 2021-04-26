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
    public partial class FrmPrueba : Form
    {
        public int index;
        ServicioPrueba prueba;
        public FrmPrueba()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            prueba = new ServicioPrueba(connection);
            index = -1;
        }

        #region Eventos

        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvPruebas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;
                Seleccionar();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tableLayoutPanel3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TblPrincipal_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Metodos
        public void Add()
        {
            if (TbxNombre.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else
            {
                Prueba NuevoMedico = new Prueba
                {
                    Nombre = TbxNombre.Text
                };

                prueba.Agregar(NuevoMedico);
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Prueba agregada exitosamente!");

            }
        }

        public void Edit()
        {
            if (TbxNombre.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else
            {
                Prueba NuevaPrueba = new Prueba
                {
                    Nombre = TbxNombre.Text,
                };

                prueba.Editar(NuevaPrueba, Convert.ToInt32(DgvPruebas.CurrentRow.Cells[0].Value.ToString()));
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Prueba editada exitosamente!");

            }
        }

        public void Delete()
        {
            DialogResult opcion = MessageBox.Show("Esta seguro de que desea eliminar esta prueba?", "Advertencia", MessageBoxButtons.OKCancel);

            if (opcion == DialogResult.OK)
            {
                int IdEliminar = Convert.ToInt32(DgvPruebas.CurrentRow.Cells[0].Value.ToString());

                prueba.Eliminar(IdEliminar);
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Medico Eliminado exitosamente!");

            }
            else
            {
                LimpiarCampos();
            }

        }

        public void LoadData()
        {
            DgvPruebas.DataSource = prueba.GetAll();
            DgvPruebas.ClearSelection();
        }


        public void LimpiarCampos()
        {
            TbxNombre.Clear();
            DgvPruebas.ClearSelection();

        }

        public void Seleccionar()
        {
            if (this.index >= 0)
            {
                TbxNombre.Text = DgvPruebas.CurrentRow.Cells[0].Value.ToString();
                Prueba MedicoSeleccionado = prueba.GetByID(Convert.ToInt32(DgvPruebas.CurrentRow.Cells[0].Value.ToString()));

                TbxNombre.Text = MedicoSeleccionado.Nombre;

            }
        }

        public void Volver()
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Close();
        }

        #endregion

    }
}
