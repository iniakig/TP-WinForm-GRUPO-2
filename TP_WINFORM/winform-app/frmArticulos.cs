using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;

        private ImagenNegocio imagenNegocio;

        private void CargarImagen()
        {
            string url = "https://images.samsung.com/is/image/samsung/co-galaxy-s10-sm-g970-sm-g970fzyjcoo-frontcanaryyellow-thumb-149016542";
            imagenNegocio.CargarImagenDesdeURL(url);
        }

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void CargarVista()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                imagenNegocio = new ImagenNegocio(pbxArticulo);
                CargarImagen();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            CargarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articuloSeleccionado;

            try
            {
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Querés eliminar artículo: " + articuloSeleccionado.Nombre + "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(articuloSeleccionado.Id);
                    MessageBox.Show("Artículo eliminado");
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
            frmModificarArticulo ventanaModificarArticulo = new frmModificarArticulo();
            ventanaModificarArticulo.ShowDialog();
        }

        private void lblAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventanaAgregarArticulo = new frmAgregarArticulo();
            ventanaAgregarArticulo.ShowDialog();
        }
    }
}
