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
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CategoriasIdNumericUpDown.Value = 0;
            NombreTextBox.Clear();
            CategoriasErrorProvider.Clear();
        }

        private void LlenaCampos(Categorias categoria)
        {
            CategoriasIdNumericUpDown.Value = categoria.CategoriaId;
            NombreTextBox.Text = categoria.NombreCategoria;
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();

            categoria.CategoriaId = (int)CategoriasIdNumericUpDown.Value;
            categoria.NombreCategoria = NombreTextBox.Text;

            return categoria;
        }

        private bool Validar()
        {
            bool paso = true;

            if (NombreTextBox.Text == "")
            {
                CategoriasErrorProvider.SetError(NombreTextBox, "Obligatorio");
                paso = false;
            }
           
            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = (int)CategoriasIdNumericUpDown.Value;

            Limpiar();

            var categotias = CategoriasBLL.Buscar(id);

            if (categotias != null)
                LlenaCampos(categotias);
            else
                MessageBox.Show("Categoría no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Categorias categorias;

            if (!Validar())
                return;

            categorias = LlenaClase();
            var paso = CategoriasBLL.Guardar(categorias);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("La categoría ha sido guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("La categoría no ha sido guardado con exito", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            CategoriasErrorProvider.Clear();
            int id = (int)CategoriasIdNumericUpDown.Value;

            Limpiar();

            if (CategoriasBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                CategoriasErrorProvider.SetError(CategoriasIdNumericUpDown, "No se puede eliminar un categoría que no existe");
        }
    }
}
