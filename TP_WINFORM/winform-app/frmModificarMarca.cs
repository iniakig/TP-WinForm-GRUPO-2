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
using System.Xml.Linq;

namespace winform_app
{
    public partial class frmModificarMarca : Form
    {
        private Marca marca;
        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public frmModificarMarca(Marca MarcaSender)
        {
            marca = MarcaSender;
            InitializeComponent();
        }
        private void frmModificarMarca_Load(object sender, EventArgs e)
        {
            CargarVista();
        }
        
        private void CargarVista()
        {
            try
            {
                txtDescripcion.Text = Marca.Nombre;
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
                if (txtDescripcion.Text.Trim() == "")
                {
                    MessageBox.Show("El campo descripción no puede quedar vacío");
                }
                else
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    Marca.Nombre = txtDescripcion.Text;
                    marcaNegocio.Modificar(Marca);
                    MessageBox.Show("Registro modificado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (txtDescripcion.Text.Trim() == "")
                {
                    CargarVista();
                }
                else
                {
                    Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
