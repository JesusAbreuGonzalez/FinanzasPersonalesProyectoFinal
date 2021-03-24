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
    public partial class cIngresos : Form
    {
        List<Ingresos> lista = new List<Ingresos>();
        public cIngresos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //IngresoId
                        lista = IngresosBLL.GetList(r => r.IngresoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //DescripcionGasto
                        lista = IngresosBLL.GetList(r => r.DescripcionIngreso.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //PresupuestoId
                        lista = IngresosBLL.GetList(r => r.PresupuestoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            //En caso de que no haya nada en el textBox, se imprimirán todos los Ingresos
            else
                lista = IngresosBLL.GetList(r => true);

            IngresosConsultaDataGridView.DataSource = null;
            IngresosConsultaDataGridView.DataSource = lista;
        }
    }
}
