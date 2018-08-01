namespace J_SellPoint.Forms.Process
{
    partial class FrmVentaFacturar
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
            this.CmbProducts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.GrdVentas = new System.Windows.Forms.DataGridView();
            this.CmdFacturar = new System.Windows.Forms.Button();
            this.CmdImprimirCotizacion = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblDescuentos = new System.Windows.Forms.Label();
            this.LblCantidadEnCarrito = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.CmdAddToProductList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbProducts
            // 
            this.CmbProducts.FormattingEnabled = true;
            this.CmbProducts.Location = new System.Drawing.Point(12, 45);
            this.CmbProducts.Name = "CmbProducts";
            this.CmbProducts.Size = new System.Drawing.Size(195, 21);
            this.CmbProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "En inventario:";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.ForeColor = System.Drawing.Color.Red;
            this.LblStock.Location = new System.Drawing.Point(147, 29);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(14, 13);
            this.LblStock.TabIndex = 2;
            this.LblStock.Text = "0";
            // 
            // GrdVentas
            // 
            this.GrdVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdVentas.Location = new System.Drawing.Point(15, 104);
            this.GrdVentas.Name = "GrdVentas";
            this.GrdVentas.Size = new System.Drawing.Size(579, 140);
            this.GrdVentas.TabIndex = 3;
            // 
            // CmdFacturar
            // 
            this.CmdFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdFacturar.Location = new System.Drawing.Point(15, 276);
            this.CmdFacturar.Name = "CmdFacturar";
            this.CmdFacturar.Size = new System.Drawing.Size(90, 45);
            this.CmdFacturar.TabIndex = 4;
            this.CmdFacturar.Text = "Facturar";
            this.CmdFacturar.UseVisualStyleBackColor = true;
            // 
            // CmdImprimirCotizacion
            // 
            this.CmdImprimirCotizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdImprimirCotizacion.Location = new System.Drawing.Point(125, 276);
            this.CmdImprimirCotizacion.Name = "CmdImprimirCotizacion";
            this.CmdImprimirCotizacion.Size = new System.Drawing.Size(90, 45);
            this.CmdImprimirCotizacion.TabIndex = 4;
            this.CmdImprimirCotizacion.Text = "Cotización";
            this.CmdImprimirCotizacion.UseVisualStyleBackColor = true;
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCancelar.Location = new System.Drawing.Point(504, 276);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(90, 45);
            this.CmdCancelar.TabIndex = 4;
            this.CmdCancelar.Text = "Cancelar";
            this.CmdCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sub total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(208, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad en carrito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(413, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descuentos";
            // 
            // LblDescuentos
            // 
            this.LblDescuentos.AutoSize = true;
            this.LblDescuentos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDescuentos.Location = new System.Drawing.Point(483, 77);
            this.LblDescuentos.Name = "LblDescuentos";
            this.LblDescuentos.Size = new System.Drawing.Size(13, 13);
            this.LblDescuentos.TabIndex = 5;
            this.LblDescuentos.Text = "0";
            // 
            // LblCantidadEnCarrito
            // 
            this.LblCantidadEnCarrito.AutoSize = true;
            this.LblCantidadEnCarrito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCantidadEnCarrito.Location = new System.Drawing.Point(310, 77);
            this.LblCantidadEnCarrito.Name = "LblCantidadEnCarrito";
            this.LblCantidadEnCarrito.Size = new System.Drawing.Size(13, 13);
            this.LblCantidadEnCarrito.TabIndex = 5;
            this.LblCantidadEnCarrito.Text = "0";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSubTotal.Location = new System.Drawing.Point(67, 77);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(13, 13);
            this.LblSubTotal.TabIndex = 5;
            this.LblSubTotal.Text = "0";
            // 
            // CmdAddToProductList
            // 
            this.CmdAddToProductList.Location = new System.Drawing.Point(213, 45);
            this.CmdAddToProductList.Name = "CmdAddToProductList";
            this.CmdAddToProductList.Size = new System.Drawing.Size(75, 23);
            this.CmdAddToProductList.TabIndex = 6;
            this.CmdAddToProductList.Text = "Add";
            this.CmdAddToProductList.UseVisualStyleBackColor = true;
            this.CmdAddToProductList.Click += new System.EventHandler(this.CmdAddToProductList_Click);
            // 
            // FrmVentaFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(606, 345);
            this.Controls.Add(this.CmdAddToProductList);
            this.Controls.Add(this.LblDescuentos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblCantidadEnCarrito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdImprimirCotizacion);
            this.Controls.Add(this.CmdFacturar);
            this.Controls.Add(this.GrdVentas);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbProducts);
            this.Name = "FrmVentaFacturar";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.FrmVentaFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.DataGridView GrdVentas;
        private System.Windows.Forms.Button CmdFacturar;
        private System.Windows.Forms.Button CmdImprimirCotizacion;
        private System.Windows.Forms.Button CmdCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblDescuentos;
        private System.Windows.Forms.Label LblCantidadEnCarrito;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Button CmdAddToProductList;
    }
}