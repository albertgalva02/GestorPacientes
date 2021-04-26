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
using System.IO;

namespace GestorPacientes
{
    public partial class FrmMedicos : Form
    {
        private string filename;
        public int index;
        ServiciosMedico medico;
        public FrmMedicos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            medico = new ServiciosMedico(connection);
            filename = "";
            index = -1;
        }



        #region Eventos

        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TblPrincipal_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

        private void DgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;
                Seleccionar();
            }
        }

        #endregion

        #region Metodos

        private void AddPhoto() 
        {
            DialogResult result = FotoDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                filename = FotoDialog.FileName;

                PbFoto.ImageLocation = filename;
            }
        }

        private void SavePhoto() 
        {

            int id = this.index < 0 ? medico.GetLastID() : Convert.ToInt32(DgvMedicos.CurrentRow.Cells[0].Value.ToString());

            string directorio = @"Images\Medicos\"+ id + "\\";
            CreateDirectory(directorio);

            string[] FilenameSplit = filename.Split('\\');
            string file = FilenameSplit[FilenameSplit.Length - 1];

            string destino = directorio + file;

            File.Copy(filename, destino, true);

            medico.SavePhoto(id, destino);


        }

        public void Add() 
        {
            if (TbxNombre.Text == "" || TbxApellido.Text == "" || TbxCedula.Text == "" || TbxCorreo.Text == "" || TbxTelefono.Text == "" || PbFoto.Image == null)
            {
                MessageBox.Show("Debe rellenar todos los campos incluida la foto");
            }
            else 
            {
                Medico NuevoMedico = new Medico
                {
                    Nombre = TbxNombre.Text,
                    Apellido = TbxApellido.Text,
                    Cedula = TbxCedula.Text,
                    Correo = TbxCorreo.Text,
                    Telefono = TbxTelefono.Text
                };

                medico.Agregar(NuevoMedico);
                SavePhoto();
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Medico agregado exitosamente!");

            }
        }

        public void Edit() 
        {
            if (TbxNombre.Text == "" || TbxApellido.Text == "" || TbxCedula.Text == "" || TbxCorreo.Text == "" || TbxTelefono.Text == "" || PbFoto.Image == null)
            {
                MessageBox.Show("Debe rellenar todos los campos incluida la foto");
            }
            else
            {
                Medico NuevoMedico = new Medico
                {
                    Nombre = TbxNombre.Text,
                    Apellido = TbxApellido.Text,
                    Cedula = TbxCedula.Text,
                    Correo = TbxCorreo.Text,
                    Telefono = TbxTelefono.Text
                };

                medico.Editar(NuevoMedico, Convert.ToInt32(DgvMedicos.CurrentRow.Cells[0].Value.ToString()));
                SavePhoto();
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Medico editado exitosamente!");

            }
        }

        public void Delete() 
        {
            DialogResult opcion = MessageBox.Show("Esta seguro de que desea eliminar este medico?","Advertencia",MessageBoxButtons.OKCancel);

            if (opcion == DialogResult.OK)
            {
                int IdEliminar = Convert.ToInt32(DgvMedicos.CurrentRow.Cells[0].Value.ToString());

                Medico MedicoSeleccionado = medico.GetByID(IdEliminar);

                File.Delete(MedicoSeleccionado.Foto);
                medico.Eliminar(IdEliminar);
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
            DgvMedicos.DataSource = medico.GetAll();
            DgvMedicos.ClearSelection();
        }


        public void LimpiarCampos() 
        {
            TbxNombre.Clear();
            TbxApellido.Clear();
            TbxCorreo.Clear();
            TbxCedula.Clear();
            TbxTelefono.Clear();
            DgvMedicos.ClearSelection();
            this.index = -1;
            PbFoto.ImageLocation = "";

        }

        public void Seleccionar() 
        {
            if (this.index >= 0) 
            {
                TbxNombre.Text = DgvMedicos.CurrentRow.Cells[0].Value.ToString();
                Medico MedicoSeleccionado = medico.GetByID(Convert.ToInt32(DgvMedicos.CurrentRow.Cells[0].Value.ToString()));
                
                TbxNombre.Text       = MedicoSeleccionado.Nombre;
                TbxApellido.Text     = MedicoSeleccionado.Apellido;
                TbxCedula.Text       = MedicoSeleccionado.Cedula;
                TbxCorreo.Text       = MedicoSeleccionado.Correo;
                TbxTelefono.Text     = MedicoSeleccionado.Telefono;
                PbFoto.ImageLocation = MedicoSeleccionado.Foto;

            }
        }

        public void CreateDirectory(string directorio) 
        {
            if (!Directory.Exists(directorio)) 
            {
                Directory.CreateDirectory(directorio);
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
