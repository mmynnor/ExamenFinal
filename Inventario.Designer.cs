namespace Final_150402003
{
    partial class Inventario
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
            this.txb_idmaterial = new System.Windows.Forms.TextBox();
            this.txtb_material = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_defectosvisualesd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_dimension = new System.Windows.Forms.Label();
            this.cb_dimensioninsp = new System.Windows.Forms.ComboBox();
            this.lbl_inspeccion = new System.Windows.Forms.Label();
            this.lbl_aceptable = new System.Windows.Forms.Label();
            this.cb_aceptable = new System.Windows.Forms.ComboBox();
            this.mostrar_reporte = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtb_categoria = new System.Windows.Forms.TextBox();
            this.txtb_proveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_idmaterial
            // 
            this.txb_idmaterial.Location = new System.Drawing.Point(80, 126);
            this.txb_idmaterial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txb_idmaterial.Name = "txb_idmaterial";
            this.txb_idmaterial.Size = new System.Drawing.Size(290, 51);
            this.txb_idmaterial.TabIndex = 0;
            // 
            // txtb_material
            // 
            this.txtb_material.Location = new System.Drawing.Point(79, 248);
            this.txtb_material.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtb_material.Name = "txtb_material";
            this.txtb_material.Size = new System.Drawing.Size(291, 51);
            this.txtb_material.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material";
            // 
            // cb_defectosvisualesd
            // 
            this.cb_defectosvisualesd.FormattingEnabled = true;
            this.cb_defectosvisualesd.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cb_defectosvisualesd.Location = new System.Drawing.Point(988, 309);
            this.cb_defectosvisualesd.Name = "cb_defectosvisualesd";
            this.cb_defectosvisualesd.Size = new System.Drawing.Size(113, 51);
            this.cb_defectosvisualesd.TabIndex = 4;
            this.cb_defectosvisualesd.SelectedIndexChanged += new System.EventHandler(this.Cb_defectosvisualesd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inspección visual";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 43);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿Defectos Visuales?";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lbl_dimension
            // 
            this.lbl_dimension.AutoSize = true;
            this.lbl_dimension.Location = new System.Drawing.Point(318, 389);
            this.lbl_dimension.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_dimension.Name = "lbl_dimension";
            this.lbl_dimension.Size = new System.Drawing.Size(637, 43);
            this.lbl_dimension.TabIndex = 8;
            this.lbl_dimension.Text = "¿Requiere inspección de dimension?";
            this.lbl_dimension.Visible = false;
            this.lbl_dimension.Click += new System.EventHandler(this.Label5_Click);
            // 
            // cb_dimensioninsp
            // 
            this.cb_dimensioninsp.FormattingEnabled = true;
            this.cb_dimensioninsp.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cb_dimensioninsp.Location = new System.Drawing.Point(988, 381);
            this.cb_dimensioninsp.Name = "cb_dimensioninsp";
            this.cb_dimensioninsp.Size = new System.Drawing.Size(113, 51);
            this.cb_dimensioninsp.TabIndex = 7;
            this.cb_dimensioninsp.Visible = false;
            this.cb_dimensioninsp.SelectedIndexChanged += new System.EventHandler(this.Cb_dimensioninsp_SelectedIndexChanged);
            // 
            // lbl_inspeccion
            // 
            this.lbl_inspeccion.AutoSize = true;
            this.lbl_inspeccion.Location = new System.Drawing.Point(687, 477);
            this.lbl_inspeccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_inspeccion.Name = "lbl_inspeccion";
            this.lbl_inspeccion.Size = new System.Drawing.Size(422, 43);
            this.lbl_inspeccion.TabIndex = 9;
            this.lbl_inspeccion.Text = "Inspección dimensional";
            this.lbl_inspeccion.Visible = false;
            this.lbl_inspeccion.Click += new System.EventHandler(this.Label6_Click);
            // 
            // lbl_aceptable
            // 
            this.lbl_aceptable.AutoSize = true;
            this.lbl_aceptable.Location = new System.Drawing.Point(747, 549);
            this.lbl_aceptable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_aceptable.Name = "lbl_aceptable";
            this.lbl_aceptable.Size = new System.Drawing.Size(223, 43);
            this.lbl_aceptable.TabIndex = 11;
            this.lbl_aceptable.Text = "¿Aceptable?";
            this.lbl_aceptable.Visible = false;
            // 
            // cb_aceptable
            // 
            this.cb_aceptable.FormattingEnabled = true;
            this.cb_aceptable.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cb_aceptable.Location = new System.Drawing.Point(988, 546);
            this.cb_aceptable.Name = "cb_aceptable";
            this.cb_aceptable.Size = new System.Drawing.Size(113, 51);
            this.cb_aceptable.TabIndex = 10;
            this.cb_aceptable.Visible = false;
            this.cb_aceptable.SelectedIndexChanged += new System.EventHandler(this.Cb_aceptable_SelectedIndexChanged);
            // 
            // mostrar_reporte
            // 
            this.mostrar_reporte.BackColor = System.Drawing.Color.MidnightBlue;
            this.mostrar_reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostrar_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrar_reporte.ForeColor = System.Drawing.Color.White;
            this.mostrar_reporte.Location = new System.Drawing.Point(70, 532);
            this.mostrar_reporte.Name = "mostrar_reporte";
            this.mostrar_reporte.Size = new System.Drawing.Size(247, 109);
            this.mostrar_reporte.TabIndex = 12;
            this.mostrar_reporte.Text = "Mostrar Reporte";
            this.mostrar_reporte.UseVisualStyleBackColor = false;
            this.mostrar_reporte.Click += new System.EventHandler(this.Mostrar_reporte_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 43);
            this.label8.TabIndex = 16;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 43);
            this.label9.TabIndex = 15;
            this.label9.Text = "Id Proveedor";
            // 
            // txtb_categoria
            // 
            this.txtb_categoria.Location = new System.Drawing.Point(422, 248);
            this.txtb_categoria.Margin = new System.Windows.Forms.Padding(5);
            this.txtb_categoria.Name = "txtb_categoria";
            this.txtb_categoria.Size = new System.Drawing.Size(291, 51);
            this.txtb_categoria.TabIndex = 14;
            // 
            // txtb_proveedor
            // 
            this.txtb_proveedor.Location = new System.Drawing.Point(423, 126);
            this.txtb_proveedor.Margin = new System.Windows.Forms.Padding(5);
            this.txtb_proveedor.Name = "txtb_proveedor";
            this.txtb_proveedor.Size = new System.Drawing.Size(290, 51);
            this.txtb_proveedor.TabIndex = 13;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 689);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtb_categoria);
            this.Controls.Add(this.txtb_proveedor);
            this.Controls.Add(this.mostrar_reporte);
            this.Controls.Add(this.lbl_aceptable);
            this.Controls.Add(this.cb_aceptable);
            this.Controls.Add(this.lbl_inspeccion);
            this.Controls.Add(this.lbl_dimension);
            this.Controls.Add(this.cb_dimensioninsp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_defectosvisualesd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_material);
            this.Controls.Add(this.txb_idmaterial);
            this.Font = new System.Drawing.Font("Cambria", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Inventario";
            this.Text = "Control inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_idmaterial;
        private System.Windows.Forms.TextBox txtb_material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_defectosvisualesd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_dimension;
        private System.Windows.Forms.ComboBox cb_dimensioninsp;
        private System.Windows.Forms.Label lbl_inspeccion;
        private System.Windows.Forms.Label lbl_aceptable;
        private System.Windows.Forms.ComboBox cb_aceptable;
        private System.Windows.Forms.Button mostrar_reporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtb_categoria;
        private System.Windows.Forms.TextBox txtb_proveedor;
    }
}

