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
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            CargarVista();
        }

        public void CargarVista()
        {
            try
            {
                MarcaNegocio negocio = new negocio.MarcaNegocio();
                listaMarcas = negocio.Listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if (txtAgregarMarca.Text != "")
            {
                MarcaNegocio negocio = new MarcaNegocio();
                Marca nuevaMarca = new Marca();

                if (txtAgregarMarca.Text != "")
                {
                    try
                    {
                        nuevaMarca.Nombre = txtAgregarMarca.Text;

                        negocio.Agregar(nuevaMarca);
                        MessageBox.Show("Marca " + "\"" + txtAgregarMarca.Text + "\"" + " agregada");
                        CargarVista();
                        txtAgregarMarca.Text = "";
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
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;

            try
            {
                seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Querés eliminar marca: " + seleccionada.Nombre + "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(seleccionada.Id);
                    MessageBox.Show("Marca eliminada");
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
            Marca seleccionada;

            try
            {
                seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

                frmModificarMarca frmModificarMarca = new frmModificarMarca(seleccionada);
                frmModificarMarca.ShowDialog();
                CargarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarcas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvMarcas.Rows[e.RowIndex];

                Marca marca = new Marca();
                marca.Id = (int)selectedRow.Cells[0].Value;
                marca.Nombre = selectedRow.Cells[1].Value.ToString();

                if (marca != null)
                {
                    frmModificarMarca frmModificarMarca = new frmModificarMarca(marca);
                    frmModificarMarca.ShowDialog();
                    CargarVista();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Marca> listaMarcasFiltradas;
            string filtro = txtBuscar.Text;

            if (filtro != "")
            {
                listaMarcasFiltradas = listaMarcas.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaMarcasFiltradas = listaMarcas;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaMarcasFiltradas;
        }
    }
}
