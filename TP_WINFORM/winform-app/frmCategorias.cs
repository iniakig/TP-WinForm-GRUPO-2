﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Microsoft.Win32;
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
            CargarVista();
        }

        public void CargarVista()
        {
            try
            {
                CategoriaNegocio categoria = new negocio.CategoriaNegocio();
                listaCategoria = categoria.Listar();
                dgvCategorias.DataSource = listaCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (txtAgregarCategoria.Text.Trim() != "")
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                Categoria nuevaCategoria = new Categoria();

                if (txtAgregarCategoria.Text.Trim() != "")
                {
                    try
                    {
                        nuevaCategoria.Descripcion = txtAgregarCategoria.Text;

                        negocio.Agregar(nuevaCategoria);
                        MessageBox.Show("Categoría " + "\"" + txtAgregarCategoria.Text + "\"" + " agregada");
                        CargarVista();
                        txtAgregarCategoria.Text = "";
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
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;

            try
            {
                seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                if (!negocio.ExistenRegistrosAsociados(seleccionada))
                {
                    DialogResult respuesta = MessageBox.Show("¿Querés eliminar categoría: " + seleccionada.Descripcion + "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.Eliminar(seleccionada.Id);
                        MessageBox.Show("Categoría eliminada");
                        CargarVista();

                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el registro.\nExisten artículos asociados a la categoría que desea eliminar.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;

            try
            {
                seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                
                frmModificarCategoria frmModificarCategoria = new frmModificarCategoria(seleccionada);
                frmModificarCategoria.ShowDialog();
                CargarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCategorias.Rows[e.RowIndex];

                Categoria categoria = new Categoria();
                categoria.Id = (int)selectedRow.Cells[0].Value;
                categoria.Descripcion = selectedRow.Cells[1].Value.ToString();

                if (categoria != null)
                {
                    frmModificarCategoria frmModificarCategoria = new frmModificarCategoria(categoria);
                    frmModificarCategoria.ShowDialog();
                    CargarVista();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Categoria> listaCategoriasFiltradas;
            string filtro = txtBuscar.Text;

            if (filtro != "")
            {
                listaCategoriasFiltradas = listaCategoria.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaCategoriasFiltradas = listaCategoria;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaCategoriasFiltradas;
        }
    }
}
