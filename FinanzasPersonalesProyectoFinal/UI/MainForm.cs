using FinanzasPersonalesProyectoFinal.BLL;
using FinanzasPersonalesProyectoFinal.Entidades;
using FinanzasPersonalesProyectoFinal.UI.Consultas;
using FinanzasPersonalesProyectoFinal.UI.Login;
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
            //menuStrip
            //Registros
            this.RegistroRolesToolStripMenuItem.Click += new EventHandler(this.RegistroRolesToolStripMenuItem_ItemClicked);
            this.RegistroUsuariosToolStripMenuItem.Click += new EventHandler(this.RegistroUsuariosToolStripMenuItem_ItemClicked);
            this.RegistroPresupuestosToolStripMenuItem.Click += new EventHandler(this.RegistroPresupuestosToolStripMenuItem_ItemClicked);
            this.RegistroCategoriasToolStripMenuItem.Click += new EventHandler(this.RegistroCategoriasToolStripMenuItem_ItemClicked);
            this.RegistroGastosToolStripMenuItem.Click += new EventHandler(this.RegistroGastosToolStripMenuItem_ItemClicked);
            this.RegistroIngresosToolStripMenuItem.Click += new EventHandler(this.RegistroIngresosToolStripMenuItem_ItemClicked);

            //Consultas
            this.ConsultaRolesToolStripMenuItem.Click += new EventHandler(this.ConsultaRolesToolStripMenuItem_ItemClicked);
            this.ConsultaUsuariosToolStripMenuItem.Click += new EventHandler(this.ConsultaUsuariosToolStripMenuItem_ItemClicked);
            this.ConsultaPresupuestosToolStripMenuItem.Click += new EventHandler(this.ConsultaPresupuestosToolStripMenuItem_ItemClicked);
            this.ConsultaCategoriasToolStripMenuItem.Click += new EventHandler(this.ConsultaCategoriasToolStripMenuItem_ItemClicked);
            this.ConsultaGastosToolStripMenuItem.Click += new EventHandler(this.ConsultaGastosToolStripMenuItem_ItemClicked);
            this.ConsultaIngresosToolStripMenuItem.Click += new EventHandler(this.ConsultaIngresosToolStripMenuItem_ItemClicked);

            //ToolStrip
            //Registros
            this.rGastosToolStripButton.Click += new EventHandler(this.RegistroGastosToolStripMenuItem_ItemClicked);
            this.rIngresosToolStripButton.Click += new EventHandler(this.RegistroIngresosToolStripMenuItem_ItemClicked);

            //Consultas
            this.cGastosToolStripButton.Click += new EventHandler(this.ConsultaGastosToolStripMenuItem_ItemClicked);
            this.cIngresosToolStripButton.Click += new EventHandler(this.ConsultaIngresosToolStripMenuItem_ItemClicked);
            this.cPresupuestosToolStripButton.Click += new EventHandler(this.ConsultaPresupuestosToolStripMenuItem_ItemClicked);
        }

        //Eventos Consultas
        private void ConsultaRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var roles = new cRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void ConsultaUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuarios = new cUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void ConsultaPresupuestosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var presupuestos = new cPresupuestos();
            presupuestos.MdiParent = this;
            presupuestos.Show();
        }

        private void ConsultaCategoriasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var categorias = new cCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void ConsultaGastosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var gastos = new cGastos();
            gastos.MdiParent = this;
            gastos.Show();
        }

        private void ConsultaIngresosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var ingresos = new cIngresos();
            ingresos.MdiParent = this;
            ingresos.Show();
        }           

        
        //Eventos registros
        private void RegistroRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var roles = new rRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void RegistroUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var usuarios = new rUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void RegistroPresupuestosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var presupuesto = new rPresupuestos();
            presupuesto.MdiParent = this;
            presupuesto.Show();
        }

        private void RegistroCategoriasToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var categoria = new rCategorias();
            categoria.MdiParent = this;
            categoria.Show();
        }      
        
        private void RegistroGastosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var gastos = new rGastos();
            gastos.MdiParent = this;
            gastos.Show();
        }       

        private void RegistroIngresosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var ingresos = new rIngresos();
            ingresos.MdiParent = this;
            ingresos.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
