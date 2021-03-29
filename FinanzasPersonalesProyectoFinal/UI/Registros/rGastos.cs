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
    public partial class rGastos : Form
    {
        public List<GastosDetalle> gastosDetalle { get; set; }
        public List<GastosDetalle> detalle { get; set; }

        public rGastos()
        {
            InitializeComponent();
            this.gastosDetalle = new List<GastosDetalle>();
        }

        private void LlenarGrid()
        {
            GastosDataGridView.DataSource = null;
            GastosDataGridView.DataSource = gastosDetalle;
        }

        private void AgregarFila()
        {
            GastosDataGridView.DataSource = null;
            GastosDataGridView.DataSource = detalle;
        }

        private void Limpiar()
        {
            GastoIdNumericUpDown.Value = 0;
            DescipcionTextBox.Clear();
            if (gastosDetalle != null)
                gastosDetalle.Clear();
            if (detalle != null)
                detalle.Clear();
            GastosDataGridView.DataSource = null;
            GastosErrorProvider.Clear();
        }

        private void LlenaCampos(Gastos gastos)
        {
            GastoIdNumericUpDown.Value = gastos.GastoId;
            DescipcionTextBox.Text = gastos.DescripcionGasto;
            PresupuestoIdComboBox.Text = Convert.ToString(gastos.PresupuestoId);
            this.gastosDetalle = gastos.GastosDetalle;
            LlenarGrid();
        }

        private Gastos LlenaClase()
        {
            Gastos gastos = new Gastos();

            gastos.GastoId = (int)GastoIdNumericUpDown.Value;
            gastos.DescripcionGasto = DescipcionTextBox.Text;
            gastos.PresupuestoId = PresupuestoIdComboBox.SelectedIndex;
            gastos.GastosDetalle = this.gastosDetalle;
            LlenarGrid();

            return gastos;
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescipcionTextBox.Text == "")
            {
                GastosErrorProvider.SetError(DescipcionTextBox, "Obligatorio");
                paso = false;
            }

            if (gastosDetalle.Count == 0)
            {
                GastosErrorProvider.SetError(GastosDataGridView, "Agregue algun detalle");
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var gastos = new Gastos();
            int id = (int)GastoIdNumericUpDown.Value;

            Limpiar();
            gastos = GastosBLL.Buscar(id);

            if (gastos != null)
                LlenaCampos(gastos);
            else
                MessageBox.Show("Gasto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (GastosDataGridView.DataSource != null)
                this.gastosDetalle = (List<GastosDetalle>)GastosDataGridView.DataSource;

            this.gastosDetalle.Add(
                new GastosDetalle()
                {
                    GastoId = (int)GastoIdNumericUpDown.Value,
                    MontoGasto = Convert.ToInt32(MontoTextBox.Text),
                }
            );

            detalle = gastosDetalle;
            AgregarFila();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (GastosDataGridView.Rows.Count > 0 && GastosDataGridView.CurrentRow != null)
            {
                gastosDetalle.RemoveAt(GastosDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Gastos gastos;

            if (!Validar())
                return;

            gastos = LlenaClase();
            var paso = GastosBLL.Guardar(gastos);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("El gasto ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El gasto  no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)GastoIdNumericUpDown.Value;
            GastosErrorProvider.Clear();

            Limpiar();

            if (GastosBLL.Eliminar(id))
                MessageBox.Show("El gasto ha sido eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                GastosErrorProvider.SetError(GastoIdNumericUpDown, "Este Id no existe en la base de datos");

        }

        private void rGastos_Load(object sender, EventArgs e)
        {
            PresupuestoIdComboBox.DataSource = PresupuestosBLL.GetPresupuestos();
            PresupuestoIdComboBox.DisplayMember = "NombrePresupuesto";
            PresupuestoIdComboBox.ValueMember = "PresupuestoId";
        }
    }
}
