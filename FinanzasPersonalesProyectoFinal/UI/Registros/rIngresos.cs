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
    public partial class rIngresos : Form
    {
        public List<IngresosDetalle> ingresosDetalle { get; set; }
        public List<IngresosDetalle> detalle { get; set; }

        public rIngresos()
        {
            InitializeComponent();
            this.ingresosDetalle = new List<IngresosDetalle>();
        }

        private void LlenarGird()
        {
            IngresosDataGridView.DataSource = null;
            IngresosDataGridView.DataSource = ingresosDetalle;
        }

        private void LlenarFila()
        {
            IngresosDataGridView.DataSource = null;
            IngresosDataGridView.DataSource = detalle;
        }

        private void Limpiar()
        {
            IngresosIdNumericUpDown.Value = 0;
            DescipcionTextBox.Clear();
            MontoTextBox.Clear();
            IngresosDataGridView.DataSource = null;
            IngresosErrorProvider.Clear();
        }

        private void LlenaCampos(Ingresos ingresos)
        {
            IngresosIdNumericUpDown.Value = ingresos.IngresoId;
            DescipcionTextBox.Text = ingresos.DescripcionIngreso;
            PresupuestoIdComboBox.Text = Convert.ToString(ingresos.PresupuestoId);
            this.ingresosDetalle = ingresos.IngresosDetalle;
            LlenarGird();
        }

        private Ingresos LlenaClases()
        {
            Ingresos ingresos = new Ingresos();

            ingresos.IngresoId = (int)IngresosIdNumericUpDown.Value;
            ingresos.DescripcionIngreso = DescipcionTextBox.Text;
            ingresos.PresupuestoId = PresupuestoIdComboBox.SelectedIndex;
            ingresos.IngresosDetalle = this.ingresosDetalle;
            LlenarGird();

            return ingresos;
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescipcionTextBox.Text == "")
            {
                IngresosErrorProvider.SetError(DescipcionTextBox, "Obligatorio");
                paso = false;
            }

            if (ingresosDetalle.Count == 0)
            {
                IngresosErrorProvider.SetError(IngresosDataGridView, "Agregue algun detalle");
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var ingresos = new Ingresos();
            int id = (int)IngresosIdNumericUpDown.Value;

            Limpiar();
            ingresos = IngresosBLL.Buscar(id);

            if (ingresos != null)
                LlenaCampos(ingresos);
            else
                MessageBox.Show("Ingreso no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (IngresosDataGridView.DataSource != null)
                this.ingresosDetalle = (List<IngresosDetalle>) IngresosDataGridView.DataSource;

            this.ingresosDetalle.Add(
                new IngresosDetalle()
                {
                    DetalleId = (int)IngresosIdNumericUpDown.Value,
                    MontoIngreso = Convert.ToInt32(MontoTextBox.Text)
                }
            );

            detalle = ingresosDetalle;
            LlenarFila();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if(IngresosDataGridView.Rows.Count > 0 && IngresosDataGridView.CurrentRow != null)
            {
                ingresosDetalle.RemoveAt(IngresosDataGridView.CurrentRow.Index);
                LlenarGird();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ingresos ingresos;

            if (!Validar())
                return;

            ingresos = LlenaClases();
            var paso = IngresosBLL.Guardar(ingresos);

            if(paso)
            {
                Limpiar();
                MessageBox.Show("El ingreso ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El ingreso no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)IngresosIdNumericUpDown.Value;

            Limpiar();

            if (IngresosBLL.Eliminar(id))
                MessageBox.Show("El ingreso ha sido eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                IngresosErrorProvider.SetError(IngresosIdNumericUpDown, "Este Id no existe en la base de datos");
        }

        private void rIngresos_Load(object sender, EventArgs e)
        {
            PresupuestoIdComboBox.DataSource = PresupuestosBLL.GetPresupuestos();
            PresupuestoIdComboBox.DisplayMember = "NombrePresupuesto";
            PresupuestoIdComboBox.ValueMember = "PresupuestoId";
        }
    }
}
