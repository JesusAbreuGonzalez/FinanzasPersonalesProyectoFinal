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
    public partial class cCategorias : Form
    {
        List<Categorias> lista = new List<Categorias>();
        public cCategorias()
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
                        case 0: //CategoriaId
                            lista = CategoriasBLL.GetList(r => r.CategoriaId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                        case 1: //NombreCategoria
                            lista = CategoriasBLL.GetList(r => r.NombreCategoria.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los categorias
                else
                    lista = CategoriasBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //CategoriaId
                            lista = CategoriasBLL.GetList(r => r.CategoriaId == Utilidades.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //NombreCategoria
                            lista = CategoriasBLL.GetList(r => r.NombreCategoria.Contains(CriterioTextBox.Text));
                            break;
                    }
                }
                //En caso de que no haya nada en el textBox, se imprimirán todos los categorias
                else
                    lista = CategoriasBLL.GetList(r => true);
            }


            CategoriasConsultaDataGridView.DataSource = null;
            CategoriasConsultaDataGridView.DataSource = lista;
        }
    }
}
