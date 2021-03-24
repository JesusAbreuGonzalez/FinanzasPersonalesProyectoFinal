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
    public partial class cGastos : Form
    {
        List<Gastos> lista = new List<Gastos>();
        public cGastos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //GastoId
                        lista = GastosBLL.GetList(r => r.GastoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 1: //DescripcionGasto
                        lista = GastosBLL.GetList(r => r.DescripcionGasto.Contains(CriterioTextBox.Text));
                        break;
                    case 2: //PresupuestoId
                        lista = GastosBLL.GetList(r => r.PresupuestoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            //En caso de que no haya nada en el textBox, se imprimirán todos los gastos
            else
                lista = GastosBLL.GetList(r => true);
          
            GastosConsultaDataGridView.DataSource = null;
            GastosConsultaDataGridView.DataSource = lista;
        }
    }
}
