using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategoria;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarVista();
        }

        private void CargarVista()
        {
            try
            {
                CategoriaNegocio categoria = new negocio.CategoriaNegocio();
                listaCategoria = categoria.Listar();
                dgvCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (txtAgregarCategoria.Text != "")
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                Categoria nuevaCategoria = new Categoria();

                if (txtAgregarCategoria.Text != "")
                {
                    try
                    {
                        nuevaCategoria.Descripcion = txtAgregarCategoria.Text;

                        negocio.Agregar(nuevaCategoria);
                        MessageBox.Show("CATEGORÍA AGREGADA");
                        CargarVista();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;

            try
            {
                seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Querés eliminar categoía:" + seleccionada.Descripcion + "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(seleccionada.Id);
                    CargarVista();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;

            try
            {
                seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                
                frmModificarCategoria frmModificarCategoria = new frmModificarCategoria(seleccionada);
                frmModificarCategoria.ShowDialog();
                CargarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCategorias.Rows[e.RowIndex];

                Categoria categoria = new Categoria();
                categoria.Id = (int)selectedRow.Cells[0].Value;
                categoria.Descripcion = selectedRow.Cells[1].Value.ToString();

                if (categoria != null)
                {
                    frmModificarCategoria frmModificarCategoria = new frmModificarCategoria(categoria);
                    frmModificarCategoria.ShowDialog();
                    CargarVista();
                }
            }
        }
    }
}
