using FinanzasPersonalesProyectoFinal.UI.Consultas;
using FinanzasPersonalesProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonalesProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Registros
            this.RegistroRolesToolStripMenuItem.Click += new EventHandler(this.RegistroRolesToolStripMenuItem_ItemClicked);
            this.RegistroUsuariosToolStripMenuItem.Click += new EventHandler(this.RegistroUsuariosToolStripMenuItem_ItemClicked);
            this.RegistroPresupuestosToolStripMenuItem.Click += new EventHandler(this.RegistroPresupuestosToolStripMenuItem_ItemClicked);
            this.RegistroCategoriasToolStripMenuItem.Click += new EventHandler(this.RegistroCategoriasToolStripMenuItem_ItemClicked);
            this.RegistroGastosToolStripMenuItem.Click += new EventHandler(this.RegistroGastosToolStripMenuItem_ItemClicked);
            this.RegistroIngresosToolStripMenuItem.Click += new EventHandler(this.RegistroIngresosToolStripMenuItem_ItemClicked);

            //Consultas
            this.ConsultaUsuariosToolStripMenuItem.Click += new EventHandler(this.ConsultaUsuariosToolStripMenuItem_ItemClicked);
            this.ConsultaCategoriasToolStripMenuItem.Click += new EventHandler(this.ConsultaCategoriasToolStripMenuItem_ItemClicked);
            this.ConsultaGastosToolStripMenuItem.Click += new EventHandler(this.ConsultaGastosToolStripMenuItem_ItemClicked);
        }

        private void ConsultaGastosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var gastos = new cGastos();
            gastos.MdiParent = this;
            gastos.Show();
        }

        private void ConsultaCategoriasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var categorias = new cCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuarios = new cUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        //Eventos registros
        private void RegistroIngresosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var ingresos = new rIngresos();
            ingresos.MdiParent = this;
            ingresos.Show();
        }

        private void RegistroGastosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var gastos = new rGastos();
            gastos.MdiParent = this;
            gastos.Show();
        }

        private void RegistroCategoriasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var categoria = new rCategorias();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void RegistroPresupuestosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var presupuesto = new rPresupuestos();
            presupuesto.MdiParent = this;
            presupuesto.Show();
        }

        private void RegistroUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuarios = new rUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void RegistroRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var roles = new rRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
