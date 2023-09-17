namespace winform_app
{
    partial class frmCategorias
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
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.txtAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblOtrasAcciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(49, 23);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(268, 65);
            this.lblTituloPrincipal.TabIndex = 1;
            this.lblTituloPrincipal.Text = "Categorías";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(60, 125);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(432, 412);
            this.dgvCategorias.TabIndex = 2;
            this.dgvCategorias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentDoubleClick);
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(516, 123);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(183, 28);
            this.lblAgregarCategoria.TabIndex = 3;
            this.lblAgregarCategoria.Text = "Agregar categoría";
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.Location = new System.Drawing.Point(520, 159);
            this.txtAgregarCategoria.MaxLength = 50;
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(202, 20);
            this.txtAgregarCategoria.TabIndex = 4;
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(728, 157);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCategoria.TabIndex = 6;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(520, 54);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(202, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.Tag = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(729, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(601, 234);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(521, 234);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblOtrasAcciones
            // 
            this.lblOtrasAcciones.AutoSize = true;
            this.lblOtrasAcciones.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtrasAcciones.ForeColor = System.Drawing.Color.Black;
            this.lblOtrasAcciones.Location = new System.Drawing.Point(516, 197);
            this.lblOtrasAcciones.Name = "lblOtrasAcciones";
            this.lblOtrasAcciones.Size = new System.Drawing.Size(153, 28);
            this.lblOtrasAcciones.TabIndex = 12;
            this.lblOtrasAcciones.Text = "Otras Acciones";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 590);
            this.Controls.Add(this.lblOtrasAcciones);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de categorías";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblOtrasAcciones;
    }
}