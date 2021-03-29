using FinanzasPersonalesProyectoFinal.Entidades;
using FinanzasPersonalesProyectoFinal.BLL;
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
    public partial class rPresupuestos : Form
    {
        public rPresupuestos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            PresupuestosIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            MontoPresupuestoTextBox.Clear();
            RegistroPresupuestosErrorProvider.Clear();
        }

        private void LlenaCampos(Presupuestos presupuestos)
        {
            PresupuestosIdNumericUpDown.Value = presupuestos.PresupuestoId;
            NombresTextBox.Text = presupuestos.NombrePresupuesto;
            MontoPresupuestoTextBox.Text = Convert.ToString(presupuestos.MontoPresupuesto);
            CategoriasComboBox.SelectedIndex = presupuestos.CategoriaId - 1;
        }

        private Presupuestos LlenaClase()
        {
            Presupuestos presupuestos = new Presupuestos();

            presupuestos.FechaCreacion = DateTime.Now;
            presupuestos.PresupuestoId = (int)PresupuestosIdNumericUpDown.Value;
            presupuestos.NombrePresupuesto = NombresTextBox.Text;
            presupuestos.MontoPresupuesto = Convert.ToInt32(MontoPresupuestoTextBox.Text);
            presupuestos.CategoriaId = CategoriasComboBox.SelectedIndex + 1;

            return presupuestos;
        }

        private bool Validar()
        {
            bool paso = true;

            if (NombresTextBox.Text == "")
            {
                RegistroPresupuestosErrorProvider.SetError(NombresTextBox, "Obligatorio");
                paso = false;
            }

            if (MontoPresupuestoTextBox.Text == "")
            {
                RegistroPresupuestosErrorProvider.SetError(MontoPresupuestoTextBox, "Obligatorio");
                paso = false;
            }

            if (CategoriasComboBox.Text == "")
            {
                RegistroPresupuestosErrorProvider.SetError(CategoriasComboBox, "Obligatorio");
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = (int)PresupuestosIdNumericUpDown.Value;

            Limpiar();

            var presupuestos = PresupuestosBLL.Buscar(id);

            if (presupuestos != null)
                LlenaCampos(presupuestos);
            else
                MessageBox.Show("Presupuesto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Presupuestos presupuestos;

            if (!Validar())
                return;

            presupuestos = LlenaClase();
            var paso = PresupuestosBLL.Guardar(presupuestos);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El presupuesto ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El presupuesto no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RegistroPresupuestosErrorProvider.Clear();
            int id = (int)PresupuestosIdNumericUpDown.Value;

            Limpiar();

            if (PresupuestosBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                RegistroPresupuestosErrorProvider.SetError(PresupuestosIdNumericUpDown, "No se puede eliminar un presupuesto que no existe");
        }

        private void rPresupuestos_Load(object sender, EventArgs e)
        {
            CategoriasComboBox.DataSource = CategoriasBLL.GetCategorias();
            CategoriasComboBox.DisplayMember = "NombreCategoria";
            CategoriasComboBox.ValueMember = "CategoriaId";
        }
    }
}
