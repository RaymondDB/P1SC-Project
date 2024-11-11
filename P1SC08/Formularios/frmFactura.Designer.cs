namespace P1SC08
{
    partial class frmFactura
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTotalLn = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVENCTE = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnInsertarLn = new System.Windows.Forms.Button();
            this.btnEditarLn = new System.Windows.Forms.Button();
            this.btnLimpiarLn = new System.Windows.Forms.Button();
            this.btnBorrarLn = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtImpuestoFact = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPagaImpuesto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 446);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1649, 307);
            this.dgv.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SkyBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1524, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 32);
            this.label10.TabIndex = 66;
            this.label10.Text = "Total Ln";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1351, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 32);
            this.label9.TabIndex = 65;
            this.label9.Text = "Impuesto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1179, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 64;
            this.label8.Text = "Precio";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(846, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 32);
            this.label7.TabIndex = 63;
            this.label7.Text = "Cantidad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(978, 411);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 30);
            this.txtCantidad.TabIndex = 62;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(1151, 411);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(168, 30);
            this.txtPrecio.TabIndex = 61;
            // 
            // txtTotalLn
            // 
            this.txtTotalLn.Location = new System.Drawing.Point(1496, 411);
            this.txtTotalLn.Multiline = true;
            this.txtTotalLn.Name = "txtTotalLn";
            this.txtTotalLn.Size = new System.Drawing.Size(168, 30);
            this.txtTotalLn.TabIndex = 59;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(252, 411);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(721, 30);
            this.txtDescripcion.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(239, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 32);
            this.label6.TabIndex = 58;
            this.label6.Text = "Descripcion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(15, 411);
            this.txtArticulo.Multiline = true;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(168, 30);
            this.txtArticulo.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1652, 44);
            this.label5.TabIndex = 55;
            this.label5.Text = "Articulo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(310, 323);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(168, 30);
            this.txtFecha.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 32);
            this.label4.TabIndex = 53;
            this.label4.Text = "Fecha Factura";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(310, 176);
            this.txtIDcliente.Multiline = true;
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(168, 30);
            this.txtIDcliente.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Cliente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(310, 134);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(168, 30);
            this.txtFactura.TabIndex = 45;
            this.txtFactura.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 32);
            this.label2.TabIndex = 47;
            this.label2.Text = "Número Factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1110, 96);
            this.label1.TabIndex = 40;
            this.label1.Text = "Facturacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Image = global::P1SC08.Properties.Resources._16__Search_;
            this.button2.Location = new System.Drawing.Point(187, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 56;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVENCTE
            // 
            this.btnVENCTE.Image = global::P1SC08.Properties.Resources._16__Search_;
            this.btnVENCTE.Location = new System.Drawing.Point(478, 175);
            this.btnVENCTE.Name = "btnVENCTE";
            this.btnVENCTE.Size = new System.Drawing.Size(64, 33);
            this.btnVENCTE.TabIndex = 49;
            this.btnVENCTE.UseVisualStyleBackColor = true;
            this.btnVENCTE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Image = global::P1SC08.Properties.Resources._16__Search_;
            this.btnProducto.Location = new System.Drawing.Point(478, 133);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(64, 33);
            this.btnProducto.TabIndex = 46;
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::P1SC08.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1544, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 96);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::P1SC08.Properties.Resources.editdelete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(1408, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(136, 96);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::P1SC08.Properties.Resources.filenew;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(1272, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 96);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::P1SC08.Properties.Resources.filesave;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(1136, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 96);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnInsertarLn
            // 
            this.btnInsertarLn.Location = new System.Drawing.Point(15, 770);
            this.btnInsertarLn.Name = "btnInsertarLn";
            this.btnInsertarLn.Size = new System.Drawing.Size(133, 68);
            this.btnInsertarLn.TabIndex = 68;
            this.btnInsertarLn.Text = "Insertar Linea";
            this.btnInsertarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnInsertarLn.UseVisualStyleBackColor = true;
            this.btnInsertarLn.Click += new System.EventHandler(this.btnInsertarLn_Click);
            // 
            // btnEditarLn
            // 
            this.btnEditarLn.Location = new System.Drawing.Point(154, 770);
            this.btnEditarLn.Name = "btnEditarLn";
            this.btnEditarLn.Size = new System.Drawing.Size(133, 68);
            this.btnEditarLn.TabIndex = 69;
            this.btnEditarLn.Text = "Editar Linea";
            this.btnEditarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEditarLn.UseVisualStyleBackColor = true;
            this.btnEditarLn.Click += new System.EventHandler(this.btnEditarLn_Click);
            // 
            // btnLimpiarLn
            // 
            this.btnLimpiarLn.Location = new System.Drawing.Point(465, 770);
            this.btnLimpiarLn.Name = "btnLimpiarLn";
            this.btnLimpiarLn.Size = new System.Drawing.Size(146, 68);
            this.btnLimpiarLn.TabIndex = 70;
            this.btnLimpiarLn.Text = "Limpiar Detalle";
            this.btnLimpiarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiarLn.UseVisualStyleBackColor = true;
            this.btnLimpiarLn.Click += new System.EventHandler(this.btnLimpiarLn_Click);
            // 
            // btnBorrarLn
            // 
            this.btnBorrarLn.Location = new System.Drawing.Point(293, 770);
            this.btnBorrarLn.Name = "btnBorrarLn";
            this.btnBorrarLn.Size = new System.Drawing.Size(156, 68);
            this.btnBorrarLn.TabIndex = 71;
            this.btnBorrarLn.Text = "Borrar Linea";
            this.btnBorrarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrarLn.UseVisualStyleBackColor = true;
            this.btnBorrarLn.Click += new System.EventHandler(this.btnBorrarLn_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1497, 842);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(168, 30);
            this.txtTotal.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SkyBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1203, 842);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 32);
            this.label11.TabIndex = 73;
            this.label11.Text = "Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.SkyBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1203, 806);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 32);
            this.label12.TabIndex = 75;
            this.label12.Text = "Impuesto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(1497, 770);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(170, 30);
            this.txtSubtotal.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.SkyBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1203, 770);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(288, 32);
            this.label13.TabIndex = 77;
            this.label13.Text = "Sub Total";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(1686, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 96);
            this.btnImprimir.TabIndex = 78;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtImpuestoFact
            // 
            this.txtImpuestoFact.Location = new System.Drawing.Point(1497, 808);
            this.txtImpuestoFact.Multiline = true;
            this.txtImpuestoFact.Name = "txtImpuestoFact";
            this.txtImpuestoFact.Size = new System.Drawing.Size(170, 30);
            this.txtImpuestoFact.TabIndex = 79;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(1325, 411);
            this.txtImpuesto.Multiline = true;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(170, 30);
            this.txtImpuesto.TabIndex = 80;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(310, 214);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(520, 30);
            this.txtNombre.TabIndex = 81;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(310, 250);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(520, 30);
            this.txtDireccion.TabIndex = 82;
            // 
            // txtPagaImpuesto
            // 
            this.txtPagaImpuesto.Location = new System.Drawing.Point(310, 286);
            this.txtPagaImpuesto.Multiline = true;
            this.txtPagaImpuesto.Name = "txtPagaImpuesto";
            this.txtPagaImpuesto.Size = new System.Drawing.Size(244, 30);
            this.txtPagaImpuesto.TabIndex = 83;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 884);
            this.Controls.Add(this.txtPagaImpuesto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtImpuestoFact);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnBorrarLn);
            this.Controls.Add(this.btnLimpiarLn);
            this.Controls.Add(this.btnEditarLn);
            this.Controls.Add(this.btnInsertarLn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTotalLn);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVENCTE);
            this.Controls.Add(this.txtIDcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.Text = "f";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTotalLn;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVENCTE;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarLn;
        private System.Windows.Forms.Button btnEditarLn;
        private System.Windows.Forms.Button btnLimpiarLn;
        private System.Windows.Forms.Button btnBorrarLn;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtImpuestoFact;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPagaImpuesto;
    }
}