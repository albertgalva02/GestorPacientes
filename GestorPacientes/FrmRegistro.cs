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
    public partial class FrmRegistro : Form
    {
        ServiciosUsuario usuario;
        public int index;
        public FrmRegistro()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            usuario = new ServiciosUsuario(connection);
            index = -1;
        }

        #region Eventos

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombobox();
        }

        public void Volver()
        {
            FrmMenu form = new FrmMenu();
            form.Show();
            this.Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
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

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TblCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void TblPrincipal_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.index = e.RowIndex;
                LoadUsuario();
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
            opcion1.Text = "Medico";
            opcion1.Value = "M";

            ComboboxItems opcion2 = new ComboboxItems();
            opcion2.Text = "Administrador";
            opcion2.Value = "A";

            CbxTipoUsuario.Items.Add(titulo);
            CbxTipoUsuario.Items.Add(opcion1);
            CbxTipoUsuario.Items.Add(opcion2);
            CbxTipoUsuario.SelectedItem = titulo;
        }

        public void Add() 
        {
            ComboboxItems CbxTipoUsuarioItem = (ComboboxItems)CbxTipoUsuario.SelectedItem;

            if (TbxNombre.Text == "" || TbxApellido.Text == "" || TbxCorreo.Text == "" || TbxPass.Text == "" || TbxPass2.Text == "" || TbxUsuario.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else 
            {
                if (TbxPass.Text == TbxPass2.Text)
                {
                    if (usuario.ExisteUsuario(TbxUsuario.Text) == 0)
                    {
                        Usuario user = new Usuario
                        {
                            Nombre = TbxNombre.Text,
                            Apellido = TbxApellido.Text,
                            Correo = TbxCorreo.Text,
                            TipoUsuario = (string)CbxTipoUsuarioItem.Value,
                            User = TbxUsuario.Text,
                            Pass = TbxPass.Text

                        };

                        usuario.Agregar(user);

                        MessageBox.Show("Usuario registrado exitosamente");
                        LimpiarCampos();
                        LoadData();
                    }
                    else 
                    {
                        MessageBox.Show("Este usuario ya existe, por favor intente con otro nombre de usuario");
                        TbxApellido.Text = Convert.ToString(usuario.ExisteUsuario(TbxUsuario.Text));
                    }
                }
                else 
                {
                    MessageBox.Show("verifique que la contraseña sea igual");
                }
                
            }
            
        }

        public void Edit() 
        {
            ComboboxItems CbxTipoUsuarioItem = (ComboboxItems)CbxTipoUsuario.SelectedItem;

            if (TbxNombre.Text == "" || TbxApellido.Text == "" || TbxCorreo.Text == "" || TbxPass.Text == "" || TbxPass2.Text == "" || TbxUsuario.Text == "" || CbxTipoUsuarioItem.Value == null)
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
            else
            {
                if (TbxPass.Text == TbxPass2.Text)
                {
                    if (usuario.UsuarioEditar(TbxUsuario.Text,Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value.ToString())) == 0)
                    {
                        Usuario user = new Usuario
                        {
                            Nombre = TbxNombre.Text,
                            Apellido = TbxApellido.Text,
                            Correo = TbxCorreo.Text,
                            TipoUsuario = (string)CbxTipoUsuarioItem.Value,
                            User = TbxUsuario.Text,
                            Pass = TbxPass.Text

                        };

                        usuario.Editar(user, Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value.ToString()));

                        MessageBox.Show("Usuario editado exitosamente");
                        LimpiarCampos();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario ya existe, por favor intente con otro nombre de usuario");
                    }
                }
                else
                {
                    MessageBox.Show("verifique que la contraseña sea igual");
                }

            }

        }

        public void Delete() 
        {
            if (index < 0)
            {
                MessageBox.Show("Seleccione el usuario que desea eliminar");
            }
            else
            {

                DialogResult opcion = MessageBox.Show("Esta seguro de que desea eliminar este usuario?", "Advertencia", MessageBoxButtons.OKCancel);

                if (opcion == DialogResult.OK)
                {
                    usuario.Eliminar(Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value.ToString()));

                    MessageBox.Show("Usuario eliminado exitosamente");
                    LimpiarCampos();
                    LoadData();
                }
            }
        }

        public void LoadUsuario() 
        {
            Usuario UsuarioSeleccionado = usuario.GetByID(Convert.ToInt32(DgvUsuarios.CurrentRow.Cells[0].Value.ToString()));
            
            TbxNombre.Text = UsuarioSeleccionado.Nombre;
            TbxApellido.Text = UsuarioSeleccionado.Apellido;
            TbxCorreo.Text = UsuarioSeleccionado.Correo;
            TbxUsuario.Text = UsuarioSeleccionado.User;
            TbxPass.Text = UsuarioSeleccionado.Pass;
            TbxPass2.Text = UsuarioSeleccionado.Pass;

            if (UsuarioSeleccionado.TipoUsuario == "A")
            {
                CbxTipoUsuario.SelectedIndex = 2;
            }
            else if (UsuarioSeleccionado.TipoUsuario == "M")
            {
                CbxTipoUsuario.SelectedIndex = 1;
            }
            else 
            {
                CbxTipoUsuario.SelectedIndex = 0;
            }

        }



        public void LimpiarCampos()
        {
            TbxApellido.Clear();
            TbxNombre.Clear();
            TbxPass.Clear();
            TbxPass2.Clear();
            TbxUsuario.Clear();
            TbxCorreo.Clear();
            CbxTipoUsuario.SelectedItem = null;
            DgvUsuarios.ClearSelection();
            this.index = -1;

        }

        public void LoadData() 
        {
            DgvUsuarios.DataSource = usuario.GetAll();
            DgvUsuarios.ClearSelection();
        }




        #endregion
    }
}
