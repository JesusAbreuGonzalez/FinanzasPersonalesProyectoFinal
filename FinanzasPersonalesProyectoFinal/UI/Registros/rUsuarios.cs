using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanzasPersonalesProyectoFinal.BLL;
using FinanzasPersonalesProyectoFinal.Entidades;

namespace FinanzasPersonalesProyectoFinal.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        //todo: ver si se puede limpiar el ComBox Roles
        private void Limpiar()
        {
            UsuariosIdNumericUpDown.Value = 0;
            AliasTextBox.Clear();
            NombresTextBox.Clear();
            EmailTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmarClaveTextBox.Clear();
            ActivoCheckBox.Checked = false;
            UsuariosErrorProvider.Clear();
        }

        private void LlenaCampos(Usuarios usuarios)
        {
            UsuariosIdNumericUpDown.Value = usuarios.UsuarioId;
            AliasTextBox.Text = usuarios.Alias;
            NombresTextBox.Text = usuarios.Nombres;
            EmailTextBox.Text = usuarios.Email;
            ActivoCheckBox.Checked = usuarios.Activo;
            RolesComboBox.SelectedIndex = usuarios.RolId;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = (int)UsuariosIdNumericUpDown.Value;
            usuarios.Alias = AliasTextBox.Text;
            usuarios.Nombres = NombresTextBox.Text;
            usuarios.Email = EmailTextBox.Text;
            usuarios.Clave = ClaveTextBox.Text;
            usuarios.Activo = ActivoCheckBox.Checked;
            usuarios.FechaIngreso = DateTime.Now;
            usuarios.RolId = RolesComboBox.SelectedIndex;

            return usuarios;
        }

        //todo: consultar a ver si las validacion Alias y Id serian necesarias
        private bool Validar()
        {
            bool paso = true;

            if (AliasTextBox.Text == "")
            {
                UsuariosErrorProvider.SetError(AliasTextBox, "Obligatorio");
                paso = false;
            }

            if (NombresTextBox.Text == "")
            {
                UsuariosErrorProvider.SetError(NombresTextBox, "Obligatorio");
                paso = false;
            }

            if (EmailTextBox.Text == "")
            {
                UsuariosErrorProvider.SetError(EmailTextBox, "Obligatorio");
                paso = false;
            }

            if (RolesComboBox.Text == "")
            {
                UsuariosErrorProvider.SetError(RolesComboBox, "Obligatorio");
                paso = false;
            }

            if (ClaveTextBox.Text == "")
            {
                UsuariosErrorProvider.SetError(ClaveTextBox, "Obligatorio");
                paso = false;
            }

            if (ConfirmarClaveTextBox.Text == "")
            {
                UsuariosErrorProvider.SetError(ConfirmarClaveTextBox, "Obligatorio");
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = (int)UsuariosIdNumericUpDown.Value;

            Limpiar();

            var usuarios = UsuariosBLL.Buscar(id);

            if (usuarios != null)
                LlenaCampos(usuarios);
            else
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;

            if (!Validar())
                return;

            usuarios = LlenaClase();
            var paso = UsuariosBLL.Guardar(usuarios);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El usuario ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El usuario no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            UsuariosErrorProvider.Clear();
            int id = (int)UsuariosIdNumericUpDown.Value;

            Limpiar();
            
            if(UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                UsuariosErrorProvider.SetError(UsuariosIdNumericUpDown, "No se puede eliminar un usuario que no existe");
        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {
            RolesComboBox.DataSource = RolesBLL.GetRoles();
            RolesComboBox.DisplayMember = "Descripcion";
            RolesComboBox.ValueMember = "RolId";
        }
    }
}
