﻿using dominio;
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
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca.Nombre = txtDescripcion.Text;
                marcaNegocio.Modificar(Marca);
                MessageBox.Show("Registro modificado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}