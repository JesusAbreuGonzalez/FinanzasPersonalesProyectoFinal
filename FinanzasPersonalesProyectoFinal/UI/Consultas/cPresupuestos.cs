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

namespace FinanzasPersonalesProyectoFinal.UI.Consultas
{
    public partial class cPresupuestos : Form
    {
        List<Presupuestos> lista = new List<Presupuestos>();
        public cPresupuestos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
            if (FechaCheckBox.Checked)
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //PresupuestoId
                            lista = PresupuestosBLL.GetList(r => r.PresupuestoId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                        case 1: //NombrePresupuesto
                            lista = PresupuestosBLL.GetList(r => r.NombrePresupuesto.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                        case 2: //MontoPresupuesto
                            lista = PresupuestosBLL.GetList(r => r.MontoPresupuesto == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                        case 3: //CategoriaId
                            lista = PresupuestosBLL.GetList(r => r.CategoriaId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los presupuestos
                else
                    lista = PresupuestosBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //PresupuestoId
                            lista = PresupuestosBLL.GetList(r => r.PresupuestoId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //NombrePresupuesto
                            lista = PresupuestosBLL.GetList(r => r.NombrePresupuesto.Contains(CriterioTextBox.Text));
                            break;
                        case 2: //MontoPresupuesto
                            lista = PresupuestosBLL.GetList(r => r.MontoPresupuesto == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 3: //CategoriaId
                            lista = PresupuestosBLL.GetList(r => r.CategoriaId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los presupuestos
                else
                    lista = PresupuestosBLL.GetList(r => true);
            }


            PresupuestosConsultaDataGridView.DataSource = null;
            PresupuestosConsultaDataGridView.DataSource = lista;
        }
    }
}
