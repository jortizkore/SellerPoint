namespace J_SellPoint.Forms.Maintenances
{
    partial class FrmProducts
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
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtFilterProducts = new System.Windows.Forms.TextBox();
            this.GrdProduct = new System.Windows.Forms.DataGridView();
            this.RefreshProd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TxtCancel = new System.Windows.Forms.Button();
            this.TxtSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TxtPriceDetails = new System.Windows.Forms.TextBox();
            this.LblCosto = new System.Windows.Forms.Label();
            this.LblDesc = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CdmAddOne = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProduct)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtFilterProducts);
            this.tabPage2.Controls.Add(this.GrdProduct);
            this.tabPage2.Controls.Add(this.RefreshProd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products in Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtFilterProducts
            // 
            this.TxtFilterProducts.Location = new System.Drawing.Point(100, 7);
            this.TxtFilterProducts.Name = "TxtFilterProducts";
            this.TxtFilterProducts.Size = new System.Drawing.Size(166, 20);
            this.TxtFilterProducts.TabIndex = 3;
            this.TxtFilterProducts.TextChanged += new System.EventHandler(this.TxtFilterProducts_TextChanged);
            // 
            // GrdProduct
            // 
            this.GrdProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProduct.Location = new System.Drawing.Point(6, 35);
            this.GrdProduct.Name = "GrdProduct";
            this.GrdProduct.ReadOnly = true;
            this.GrdProduct.Size = new System.Drawing.Size(530, 195);
            this.GrdProduct.TabIndex = 2;
            this.GrdProduct.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdProduct_CellMouseDoubleClick);
            // 
            // RefreshProd
            // 
            this.RefreshProd.Location = new System.Drawing.Point(6, 6);
            this.RefreshProd.Name = "RefreshProd";
            this.RefreshProd.Size = new System.Drawing.Size(88, 23);
            this.RefreshProd.TabIndex = 1;
            this.RefreshProd.Text = "Refresh";
            this.RefreshProd.UseVisualStyleBackColor = true;
            this.RefreshProd.Click += new System.EventHandler(this.RefreshProd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxtCancel);
            this.tabPage1.Controls.Add(this.TxtSave);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TxtDescripcion);
            this.tabPage1.Controls.Add(this.TxtCosto);
            this.tabPage1.Controls.Add(this.TxtPrecio);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtCancel
            // 
            this.TxtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCancel.Location = new System.Drawing.Point(457, 192);
            this.TxtCancel.Name = "TxtCancel";
            this.TxtCancel.Size = new System.Drawing.Size(79, 38);
            this.TxtCancel.TabIndex = 9;
            this.TxtCancel.Text = "Cancel";
            this.TxtCancel.UseVisualStyleBackColor = true;
            this.TxtCancel.Click += new System.EventHandler(this.TxtCancel_Click);
            // 
            // TxtSave
            // 
            this.TxtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSave.Location = new System.Drawing.Point(9, 192);
            this.TxtSave.Name = "TxtSave";
            this.TxtSave.Size = new System.Drawing.Size(71, 38);
            this.TxtSave.TabIndex = 8;
            this.TxtSave.Text = "Save";
            this.TxtSave.UseVisualStyleBackColor = true;
            this.TxtSave.Click += new System.EventHandler(this.TxtSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre [Descripcion]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio (Venta)";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(9, 42);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(147, 20);
            this.TxtDescripcion.TabIndex = 0;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(9, 93);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(147, 20);
            this.TxtCosto.TabIndex = 1;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(9, 145);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(147, 20);
            this.TxtPrecio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Costo";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 262);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CdmAddOne);
            this.tabPage3.Controls.Add(this.LblQuantity);
            this.tabPage3.Controls.Add(this.TxtPriceDetails);
            this.tabPage3.Controls.Add(this.LblCosto);
            this.tabPage3.Controls.Add(this.LblDesc);
            this.tabPage3.Controls.Add(this.TxtID);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(542, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LblQuantity
            // 
            this.LblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(477, 24);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(13, 13);
            this.LblQuantity.TabIndex = 9;
            this.LblQuantity.Text = "0";
            // 
            // TxtPriceDetails
            // 
            this.TxtPriceDetails.Location = new System.Drawing.Point(54, 183);
            this.TxtPriceDetails.Name = "TxtPriceDetails";
            this.TxtPriceDetails.Size = new System.Drawing.Size(112, 20);
            this.TxtPriceDetails.TabIndex = 8;
            this.TxtPriceDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            // 
            // LblCosto
            // 
            this.LblCosto.AutoSize = true;
            this.LblCosto.Location = new System.Drawing.Point(20, 153);
            this.LblCosto.Name = "LblCosto";
            this.LblCosto.Size = new System.Drawing.Size(13, 13);
            this.LblCosto.TabIndex = 7;
            this.LblCosto.Text = "--";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Location = new System.Drawing.Point(20, 89);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(13, 13);
            this.LblDesc.TabIndex = 6;
            this.LblDesc.Text = "--";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(44, 17);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(75, 20);
            this.TxtID.TabIndex = 5;
            this.TxtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CdmAddOne
            // 
            this.CdmAddOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CdmAddOne.Location = new System.Drawing.Point(430, 40);
            this.CdmAddOne.Name = "CdmAddOne";
            this.CdmAddOne.Size = new System.Drawing.Size(43, 23);
            this.CdmAddOne.TabIndex = 10;
            this.CdmAddOne.Text = "+1";
            this.CdmAddOne.UseVisualStyleBackColor = true;
            this.CdmAddOne.Click += new System.EventHandler(this.CdmAddOne_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 284);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmProducts";
            this.Text = "Product Maintenance";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProduct)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button TxtCancel;
        private System.Windows.Forms.Button TxtSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button RefreshProd;
        private System.Windows.Forms.DataGridView GrdProduct;
        private System.Windows.Forms.TextBox TxtFilterProducts;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TxtPriceDetails;
        private System.Windows.Forms.Label LblCosto;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button CdmAddOne;
    }
}