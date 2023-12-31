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

namespace winform_app
{
    public partial class frmMenuPrinc : Form
    {
        public frmMenuPrinc()
        {
            InitializeComponent();
        }

        private void pbxCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias ventanaCategorias = new frmCategorias();
            ventanaCategorias.ShowDialog();
        }

        private void pbxMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas ventanaMarcas = new frmMarcas();
            ventanaMarcas.ShowDialog();
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {
            frmArticulos ventanaArticulos = new frmArticulos();
            ventanaArticulos.ShowDialog();
        }
    }
}
