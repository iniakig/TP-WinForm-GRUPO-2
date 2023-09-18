namespace winform_app
{
    partial class frmDetalleArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(600, 389);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(23, 23);
            this.btnImagenSiguiente.TabIndex = 54;
            this.btnImagenSiguiente.Text = ">";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(401, 389);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(23, 23);
            this.btnImagenAnterior.TabIndex = 53;
            this.btnImagenAnterior.Text = "<";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(362, 74);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(300, 300);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 52;
            this.pbxArticulo.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 74);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 51;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(53, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "Id";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(136, 389);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 20);
            this.txtPrecio.TabIndex = 49;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(53, 392);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 46;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(53, 347);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 45;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(53, 303);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 44;
            this.lblMarca.Text = "Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcion.Location = new System.Drawing.Point(136, 213);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 64);
            this.txtDescripcion.TabIndex = 43;
            this.txtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(53, 213);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 42;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 41;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 166);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(136, 117);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(180, 20);
            this.txtCodigo.TabIndex = 39;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(53, 120);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "Código";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(136, 300);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(180, 20);
            this.txtMarca.TabIndex = 55;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(136, 344);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(180, 20);
            this.txtCategoria.TabIndex = 56;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 486);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmDetalleArticulo";
            this.Text = "Detalle de artículo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
    }
}