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
    public partial class frmModificarCategoria : Form
    {
        private Categoria categoria;
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public frmModificarCategoria(Categoria categoriaSender)
        {
            categoria = categoriaSender;
            InitializeComponent();
        }
        private void frmModificarCategoria_Load(object sender, EventArgs e)
        {
            CargarVista();
        }
        private void CargarVista()
        {
            try
            {
                txtDescripcion.Text = Categoria.Descripcion;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("El campo descripción no puede quedar vacío");
                }
                else
                {
                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    categoria.Descripcion = txtDescripcion.Text;
                    categoriaNegocio.Modificar(categoria);
                    MessageBox.Show("Registro modificado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (txtDescripcion.Text != "")
                {
                    Close();
                }
                else
                {
                    CargarVista();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
