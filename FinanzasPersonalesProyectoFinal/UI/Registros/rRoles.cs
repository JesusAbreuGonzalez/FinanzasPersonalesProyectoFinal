using FinanzasPersonalesProyectoFinal.BLL;
using FinanzasPersonalesProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonalesProyectoFinal.UI.Registros
{
    public partial class rRoles : Form
    {
        public List<RolesDetalle> rolesDetalle { get; set; }
        public List<RolesDetalle> detalle { get; set; }

        public rRoles()
        {
            InitializeComponent();
            this.rolesDetalle = new List<RolesDetalle>();
        }

        private void LlenarGrid()
        {
            RolDataGridView.DataSource = null;
            RolDataGridView.DataSource = rolesDetalle;
        }

        private void AgregarFila()
        {
            RolDataGridView.DataSource = null;
            RolDataGridView.DataSource = detalle;
        }

        //todo: ver si se puede limpiar el ComBox Permisos id
        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            ActivoCheckBox.Checked = false;
            AsignadoCheckBox.Checked = false;
            if(detalle != null)
                detalle.Clear();
            if(rolesDetalle != null)
                rolesDetalle.Clear();
            RolDataGridView.DataSource = null;
            RolesErrorProvider.Clear();
        }

        private void LlenaCampos(Roles roles)
        {
            RolIdNumericUpDown.Value = roles.RolId;
            DescripcionTextBox.Text = roles.Descripcion;
            ActivoCheckBox.Checked = roles.esActivo;
            rolesDetalle.Clear();
            this.rolesDetalle = roles.RolesDetalle;
            LlenarGrid();
        }

        private Roles LlenaClases()
        {
            Roles roles = new Roles();

            roles.FechaCreacion = DateTime.Now;
            roles.RolId = (int)RolIdNumericUpDown.Value;
            roles.Descripcion = DescripcionTextBox.Text;
            roles.esActivo = ActivoCheckBox.Checked;
            roles.RolesDetalle = this.rolesDetalle;
            LlenarGrid();

            return roles;
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == "")
            {
                RolesErrorProvider.SetError(DescripcionTextBox, "Obligatorio");
                paso = false;
            }

            if (rolesDetalle.Count == 0)
            {
                RolesErrorProvider.SetError(RolDataGridView, "Agregue algun  detalle");
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var roles = new Roles();
            int id = (int)RolIdNumericUpDown.Value;

            Limpiar();
            roles = RolesBLL.Buscar(id);

            if (roles != null)
                LlenaCampos(roles);
            else
                MessageBox.Show("Rol no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RolDataGridView.DataSource != null)
                this.rolesDetalle = (List<RolesDetalle>)RolDataGridView.DataSource;

            this.rolesDetalle.Add(
                new RolesDetalle()
                {
                    RolId = (int)RolIdNumericUpDown.Value,
                    PermisoId = PermisoIdComboBox.SelectedIndex + 1,
                    EsAsignado = AsignadoCheckBox.Checked
                }
            );

            detalle = rolesDetalle;
            AgregarFila();
            AsignadoCheckBox.Checked = false;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (RolDataGridView.Rows.Count > 0  && RolDataGridView.CurrentRow != null)
            {
                rolesDetalle.RemoveAt(RolDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles roles;

            if (!Validar())
                return;

            roles = LlenaClases();
            var paso = RolesBLL.Guardar(roles);

            if(paso)
            {
                Limpiar();
                MessageBox.Show("El rol ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El rol no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //todo: discutir el error del eliminar
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)RolIdNumericUpDown.Value;
            RolesErrorProvider.Clear();

            Limpiar();

            if (RolesBLL.Eliminar(id))
                MessageBox.Show("El rol ha sido eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                RolesErrorProvider.SetError(RolIdNumericUpDown, "Este Id no existe en la base de datos");
        }

        private void rRoles_Load(object sender, EventArgs e)
        {
            PermisoIdComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisoIdComboBox.DisplayMember = "Descripcion";
            PermisoIdComboBox.ValueMember = "PermisoId";
        }

        
    }
}
