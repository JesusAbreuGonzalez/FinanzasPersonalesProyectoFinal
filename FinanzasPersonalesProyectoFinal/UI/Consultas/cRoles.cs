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
    public partial class cRoles : Form
    {
        List<Roles> lista = new List<Roles>();
        public cRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            //En caso de que TodosRadioButton se encuentre seleccionado
            if (TodosRadioButton.Checked)
            {
                //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
                if (FechaCheckBox.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => true);
                }

            }
            //En caso de que ActivosRadioButton se encuentre seleccionado
            else if (ActivosRadioButton.Checked)
            {
                //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
                if (FechaCheckBox.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && r.esActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && r.esActivo);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && r.esActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => true && r.esActivo);
                }

            }
            //En caso de que InactivosRadioButton se encuentre seleccionado
            else if (InactivosRadioButton.Checked)
            {
                //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
                if (FechaCheckBox.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && !r.esActivo);
                                break;
                            case 1: //Alias
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && !r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && !r.esActivo);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && !r.esActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && !r.esActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => true && !r.esActivo);
                }

            }


            RolesConsultaDataGridView.DataSource = null;
            RolesConsultaDataGridView.DataSource = lista;
        }
    }
}
