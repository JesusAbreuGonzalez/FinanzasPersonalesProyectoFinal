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
    public partial class cUsuarios : Form
    {
        List<Usuarios> lista = new List<Usuarios>();
        public cUsuarios()
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
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
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
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
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
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value || r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilidades.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilidades.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
                }

            }


            UsuariosConsultaDataGridView.DataSource = null;
            UsuariosConsultaDataGridView.DataSource = lista;
        }
    }
}
