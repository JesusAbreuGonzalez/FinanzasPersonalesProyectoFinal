using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonalesProyectoFinal.UI.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (ClaveTextBox.Text == "Contraseña")
            {
                ClaveTextBox.PasswordChar = '\0';
            }
        }


        private void MostrarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarCheckBox.Checked)
            {
                ClaveTextBox.PasswordChar = '\0';
            }
            else
                ClaveTextBox.PasswordChar = '*';
        }

        private void ClaveTextBox_Enter(object sender, EventArgs e)
        {
            if (ClaveTextBox.Text == "Contraseña")
            {
                ClaveTextBox.Text = "";
                ClaveTextBox.PasswordChar = '*';
                ClaveTextBox.ForeColor = Color.Black;
            }
        }

        private void ClaveTextBox_Leave(object sender, EventArgs e)
        {
            if(ClaveTextBox.Text == "")
            {
                ClaveTextBox.Text = "Contraseña";
                ClaveTextBox.PasswordChar = '\0';
                ClaveTextBox.ForeColor = Color.Gray;
            }
        }

        private void NombreCompletoTextBox_Enter(object sender, EventArgs e)
        {
            if (NombreCompletoTextBox.Text == "Nombre Completo")
            {
                NombreCompletoTextBox.Text = "";
                NombreCompletoTextBox.ForeColor = Color.Black;
            }
        }

        private void NombreCompletoTextBox_Leave(object sender, EventArgs e)
        {
            if (NombreCompletoTextBox.Text == "")
            {
                NombreCompletoTextBox.Text = "Nombre Completo";
                NombreCompletoTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
