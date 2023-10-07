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
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.Listar();
                cboCategoria.DataSource = categoriaNegocio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo = new Articulo();

            if (txtNombre.Text != "" && txtCodigo.Text != "" && txtPrecio.ToString() != "")
            {
                try
                {
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Marca = (Marca)cboMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    articulo.UrlImagen = txtImagen.Text;


                    articuloNegocio.Agregar(articulo);

                    frmArticulos frmArticulos = Application.OpenForms["frmArticulos"] as frmArticulos;
                    if (frmArticulos != null)
                    {
                        frmArticulos.CargarVista();
                    }
                    
                    MessageBox.Show("Articulo agregado");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Completar todos los campos obligatorios (*)");
            }
        }
    }
}
