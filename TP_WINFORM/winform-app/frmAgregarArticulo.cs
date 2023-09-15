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
    }
}
