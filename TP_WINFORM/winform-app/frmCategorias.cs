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
            CategoriaNegocio categoria = new negocio.CategoriaNegocio();
            listaCategoria = categoria.Listar();
            dgvCategorias.DataSource = listaCategoria;
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if(txtAgregarCategoria.Text != "")
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                Categoria nuevaCategoria = new Categoria();

                if(txtAgregarCategoria.Text != "")
                {
                    try
                    {
                        nuevaCategoria.Descripcion = txtAgregarCategoria.Text;

                        negocio.Agregar(nuevaCategoria);
                        MessageBox.Show("CATEGORÍA AGREGADA");
                        listaCategoria = negocio.Listar();
                        dgvCategorias.DataSource = listaCategoria;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }
    }
}
