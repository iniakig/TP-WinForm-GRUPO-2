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
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        private ImagenNegocio imagenNegocio;
        private List<string> UrlImagenesArticulo;
        private int IndiceImagen;
        public Articulo Articulo { get; set; }

        private void CargarImagen()
        {
            UrlImagenesArticulo = imagenNegocio.GetImagenesNegocio(Articulo);
            imagenNegocio.CargarImagenDesdeURL(UrlImagenesArticulo[IndiceImagen]);
        }

        public frmDetalleArticulo(Articulo articuloSender)
        {
            Articulo = articuloSender;
            IndiceImagen = 0;
            InitializeComponent();
            btnImagenAnterior.Enabled = false;
            btnImagenSiguiente.Enabled = false;
        }

        private void CargarVista()
        {
            try
            {
                txtId.Text = Articulo.Id.ToString();
                txtId.ReadOnly = true;
                txtCodigo.Text = Articulo.Codigo;
                txtCodigo.ReadOnly = true;
                txtNombre.Text = Articulo.Nombre;
                txtNombre.ReadOnly = true;
                txtDescripcion.Text = Articulo.Descripcion;
                txtDescripcion.ReadOnly = true; 
                txtMarca.Text = Articulo.Marca.Nombre;
                txtMarca.ReadOnly = true;
                txtCategoria.Text = Articulo.Categoria.Descripcion;
                txtCategoria.ReadOnly = true;
                txtPrecio.Text = Articulo.Precio.ToString();
                txtPrecio.ReadOnly = true;

                imagenNegocio = new ImagenNegocio(pbxArticulo);
                CargarImagen();

                if (UrlImagenesArticulo.Count > 1)
                {
                    btnImagenAnterior.Enabled = true;
                    btnImagenSiguiente.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            CargarVista();
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            if (UrlImagenesArticulo != null)
            {
                if (IndiceImagen > 0)
                {
                    IndiceImagen--;
                }
                CargarImagen();
            }
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            if (UrlImagenesArticulo != null)
            {
                if (IndiceImagen < UrlImagenesArticulo.Count - 1)
                {
                    IndiceImagen++;
                }
                CargarImagen();
            }
        }
    }
}
