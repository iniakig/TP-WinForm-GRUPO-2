
namespace winform_app
{
    partial class frmMenuPrinc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrinc));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.pbxMarcas = new System.Windows.Forms.PictureBox();
            this.pbxCategorias = new System.Windows.Forms.PictureBox();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(104, 30);
            this.lblTituloPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(596, 81);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "Gestión de catálogo";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxArticulo.Image = ((System.Drawing.Image)(resources.GetObject("pbxArticulo.Image")));
            this.pbxArticulo.Location = new System.Drawing.Point(119, 233);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulo.MaximumSize = new System.Drawing.Size(200, 185);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(200, 185);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // pbxMarcas
            // 
            this.pbxMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMarcas.Image = ((System.Drawing.Image)(resources.GetObject("pbxMarcas.Image")));
            this.pbxMarcas.Location = new System.Drawing.Point(491, 233);
            this.pbxMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxMarcas.MaximumSize = new System.Drawing.Size(200, 185);
            this.pbxMarcas.Name = "pbxMarcas";
            this.pbxMarcas.Size = new System.Drawing.Size(200, 185);
            this.pbxMarcas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMarcas.TabIndex = 2;
            this.pbxMarcas.TabStop = false;
            this.pbxMarcas.Click += new System.EventHandler(this.pbxMarcas_Click);
            // 
            // pbxCategorias
            // 
            this.pbxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCategorias.Image = ((System.Drawing.Image)(resources.GetObject("pbxCategorias.Image")));
            this.pbxCategorias.Location = new System.Drawing.Point(861, 233);
            this.pbxCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxCategorias.MaximumSize = new System.Drawing.Size(200, 185);
            this.pbxCategorias.Name = "pbxCategorias";
            this.pbxCategorias.Size = new System.Drawing.Size(200, 185);
            this.pbxCategorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCategorias.TabIndex = 3;
            this.pbxCategorias.TabStop = false;
            this.pbxCategorias.Click += new System.EventHandler(this.pbxCategorias_Click);
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.Location = new System.Drawing.Point(153, 421);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(127, 37);
            this.lblArticulos.TabIndex = 4;
            this.lblArticulos.Text = "Artículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marcas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(888, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categorías";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(661, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aplicación de gestión de artículos, marcas y categorías";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(493, 555);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(541, 28);
            this.lblFooter.TabIndex = 8;
            this.lblFooter.Text = "Grupo 2 - Actividad 2 - Programación II - TUP - UTN FRGP";
            // 
            // frmMenuPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1188, 624);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.pbxCategorias);
            this.Controls.Add(this.pbxMarcas);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenuPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de catálogo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.PictureBox pbxMarcas;
        private System.Windows.Forms.PictureBox pbxCategorias;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFooter;
    }
}

