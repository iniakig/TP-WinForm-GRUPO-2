using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmModificarArticulo : Form
    {
        private ImagenNegocio imagenNegocio;
        private Articulo articulo;
        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        private void CargarImagen()
        {
            string url = Articulo.UrlImagen;
            imagenNegocio.CargarImagenDesdeURL(url);
        }
        public frmModificarArticulo(Articulo articuloSender)
        {
            articulo = articuloSender;
            InitializeComponent();
        }

        private void CargarVista()
        {
            try
            {
                txtCodigo.Text = Articulo.Codigo;
                txtNombre.Text = Articulo.Nombre;
                txtDescripcion.Text = Articulo.Descripcion;
                
                imagenNegocio = new ImagenNegocio(pbxArticulo);
                CargarImagen();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmModificarArticulo_Load(object sender, EventArgs e)
        {
            CargarVista();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
