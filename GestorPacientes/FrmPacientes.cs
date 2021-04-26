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
    public partial class FrmPacientes : Form
    {
        private string filename;
        public int index;
        ServiciosPaciente paciente;
        public FrmPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            paciente = new ServiciosPaciente(connection);
            filename = "";
            index = -1;
        }

        #region Eventos
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadData();
        }

        private void TblPrincipal_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
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

        private void DgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;
                Seleccionar();
            }
        }

        #endregion

        #region Metodos

        public void LoadCombobox()
        {
            ComboboxItems titulo = new ComboboxItems();
            titulo.Text = "Seleccione una opcion";
            titulo.Value = null;

            ComboboxItems opcion1 = new ComboboxItems();
            opcion1.Text = "Si";
            opcion1.Value = 1;

            ComboboxItems opcion2 = new ComboboxItems();
            opcion2.Text = "No";
            opcion2.Value = 0;

            CbxFumador.Items.Add(titulo);
            CbxFumador.Items.Add(opcion1);
            CbxFumador.Items.Add(opcion2);
            CbxFumador.SelectedItem = titulo;

            CbxAlergias.Items.Add(titulo);
            CbxAlergias.Items.Add(opcion1);
            CbxAlergias.Items.Add(opcion2);
            CbxAlergias.SelectedItem = titulo;
        }

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

            int id = this.index < 0 ? paciente.GetLastID() : Convert.ToInt32(DgvPacientes.CurrentRow.Cells[0].Value.ToString());

            string directorio = @"Images\Pacientes\" + id + "\\";
            CreateDirectory(directorio);

            string[] FilenameSplit = filename.Split('\\');
            string file = FilenameSplit[FilenameSplit.Length - 1];

            string destino = directorio + file;

            File.Copy(filename, destino, true);

            paciente.SavePhoto(id, destino);


        }

        public void Add()
        {
            ComboboxItems CbxFumadorItem = (ComboboxItems)CbxFumador.SelectedItem;
            ComboboxItems CbxAlergiasItem = (ComboboxItems)CbxAlergias.SelectedItem;

            if (TbxNombre.Text == "" || TbxApellido.Text == "" || TbxTelefono.Text == "" || TbxDireccion.Text == "" || TbxCedula.Text == "" || DtFechaNac.Value.ToString("dd/MM/yyyy") == "" || CbxFumadorItem.Value == null || CbxAlergiasItem.Value == null || PbFoto.Image == null)
            {
                MessageBox.Show("Debe rellenar todos los campos incluida la foto");
            }
            else
            {
                Paciente NuevoPaciente = new Paciente
                {
                    Nombre = TbxNombre.Text,
                    Apellido = TbxApellido.Text,
                    Telefono = TbxTelefono.Text,
                    Direccion = TbxDireccion.Text,
                    Cedula = TbxCedula.Text,
                    FechaNac = DtFechaNac.Value.ToString("dd/MM/yyyy"),
                    Fumador = (int)CbxFumadorItem.Value,
                    Alergias = (int)CbxAlergiasItem.Value
                };

                paciente.Agregar(NuevoPaciente);
                SavePhoto();
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Paciente agregado exitosamente!");

            }
        }

        public void Edit()
        {
            ComboboxItems CbxFumadorItem = (ComboboxItems)CbxFumador.SelectedItem;
            ComboboxItems CbxAlergiasItem = (ComboboxItems)CbxAlergias.SelectedItem;

            if (TbxNombre.Text == "" || TbxApellido.Text == "" || TbxTelefono.Text == "" || TbxDireccion.Text == "" || TbxCedula.Text == "" || DtFechaNac.Value.ToString("dd/MM/yyyy") == "" || CbxFumadorItem.Value == null || CbxAlergiasItem.Value == null || PbFoto.Image == null)
            {
                MessageBox.Show("Debe rellenar todos los campos incluida la foto");
            }
            else
            {
                Paciente NuevoPaciente = new Paciente
                {
                    Nombre = TbxNombre.Text,
                    Apellido = TbxApellido.Text,
                    Telefono = TbxTelefono.Text,
                    Direccion = TbxDireccion.Text,
                    Cedula = TbxCedula.Text,
                    FechaNac = DtFechaNac.Value.ToString("dd/MM/yyyy"),
                    Fumador = (int)CbxFumadorItem.Value,
                    Alergias = (int)CbxAlergiasItem.Value
                };

                paciente.Editar(NuevoPaciente, Convert.ToInt32(DgvPacientes.CurrentRow.Cells[0].Value.ToString()));
                SavePhoto();
                LoadData();
                LimpiarCampos();

                MessageBox.Show("Paciente editado exitosamente!");

            }
        }

        public void Delete()
        {
            DialogResult opcion = MessageBox.Show("Esta seguro de que desea eliminar este paciente?", "Advertencia", MessageBoxButtons.OKCancel);

            if (opcion == DialogResult.OK)
            {
                int IdEliminar = Convert.ToInt32(DgvPacientes.CurrentRow.Cells[0].Value.ToString());

                Paciente PacienteSeleccionado = paciente.GetByID(IdEliminar);

                File.Delete(PacienteSeleccionado.Foto);
                paciente.Eliminar(IdEliminar);
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
            DgvPacientes.DataSource = paciente.GetAll();
            DgvPacientes.ClearSelection();
        }


        public void LimpiarCampos()
        {
            TbxNombre.Clear();
            TbxApellido.Clear();
            TbxTelefono.Clear();
            TbxDireccion.Clear();
            TbxCedula.Clear();
            DtFechaNac.Text = "";
            CbxFumador.SelectedItem = null;
            CbxAlergias.SelectedItem = null;
            this.index = -1;
            PbFoto.ImageLocation = "";
            DgvPacientes.ClearSelection();

        }

        public void Seleccionar()
        {
            if (this.index >= 0)
            {
                TbxNombre.Text = DgvPacientes.CurrentRow.Cells[0].Value.ToString();
                Paciente PacienteSeleccionado = paciente.GetByID(Convert.ToInt32(DgvPacientes.CurrentRow.Cells[0].Value.ToString()));

                TbxNombre.Text       = PacienteSeleccionado.Nombre;
                TbxApellido.Text     = PacienteSeleccionado.Apellido;
                TbxTelefono.Text     = PacienteSeleccionado.Telefono;
                TbxDireccion.Text    = PacienteSeleccionado.Direccion;
                TbxCedula.Text       = PacienteSeleccionado.Cedula;
                DtFechaNac.Text      = PacienteSeleccionado.FechaNac;
                PbFoto.ImageLocation = PacienteSeleccionado.Foto;

                if (PacienteSeleccionado.Fumador == 1)
                {
                    CbxFumador.SelectedIndex = 1;
                }
                else if (PacienteSeleccionado.Fumador == 0)
                {
                    CbxFumador.SelectedIndex = 2;
                }
                else
                {
                    CbxFumador.SelectedIndex = 0;
                }

                if (PacienteSeleccionado.Alergias == 1)
                {
                    CbxAlergias.SelectedIndex = 1;
                }
                else if (PacienteSeleccionado.Alergias == 0)
                {
                    CbxAlergias.SelectedIndex = 2;
                }
                else
                {
                    CbxAlergias.SelectedIndex = 0;
                }

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
