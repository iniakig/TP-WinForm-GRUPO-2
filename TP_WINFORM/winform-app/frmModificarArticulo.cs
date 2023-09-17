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
        private List<string> UrlImagenesArticulo;
        private int IndiceImagen;
        private Articulo articulo;
        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        private void CargarImagen()
        {
            UrlImagenesArticulo = imagenNegocio.GetImagenesNegocio(Articulo);
            imagenNegocio.CargarImagenDesdeURL(UrlImagenesArticulo[IndiceImagen]);
        }
        public frmModificarArticulo(Articulo articuloSender)
        {
            articulo = articuloSender;
            IndiceImagen = 0;
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

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            if (IndiceImagen < UrlImagenesArticulo.Count - 1)
            {
                IndiceImagen++;
            }
            CargarImagen();
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            if (IndiceImagen > 0)
            {
                IndiceImagen--;
            }
            CargarImagen();
        }
    }
}
