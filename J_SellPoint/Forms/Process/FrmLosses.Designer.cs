namespace J_SellPoint.Forms.Process
{
    partial class FrmLosses
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TxtCostoPerdida = new System.Windows.Forms.TextBox();
            this.TxtTotalPerdido = new System.Windows.Forms.TextBox();
            this.TxtComentarioPerdida = new System.Windows.Forms.TextBox();
            this.CmbProductosPerdidas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CmdBuscarPerdidas = new System.Windows.Forms.Button();
            this.grdPerdiasConsulta = new System.Windows.Forms.DataGridView();
            this.Cmd = new System.Windows.Forms.Button();
            this.CmdCalcel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerdiasConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 256);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CmdCalcel);
            this.tabPage1.Controls.Add(this.Cmd);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.asd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CmbProductosPerdidas);
            this.tabPage1.Controls.Add(this.TxtComentarioPerdida);
            this.tabPage1.Controls.Add(this.TxtTotalPerdido);
            this.tabPage1.Controls.Add(this.TxtCostoPerdida);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdPerdiasConsulta);
            this.tabPage2.Controls.Add(this.CmdBuscarPerdidas);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(519, 206);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TxtCostoPerdida
            // 
            this.TxtCostoPerdida.Enabled = false;
            this.TxtCostoPerdida.Location = new System.Drawing.Point(8, 84);
            this.TxtCostoPerdida.Name = "TxtCostoPerdida";
            this.TxtCostoPerdida.Size = new System.Drawing.Size(168, 20);
            this.TxtCostoPerdida.TabIndex = 0;
            // 
            // TxtTotalPerdido
            // 
            this.TxtTotalPerdido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalPerdido.Enabled = false;
            this.TxtTotalPerdido.Location = new System.Drawing.Point(320, 33);
            this.TxtTotalPerdido.Name = "TxtTotalPerdido";
            this.TxtTotalPerdido.Size = new System.Drawing.Size(116, 20);
            this.TxtTotalPerdido.TabIndex = 0;
            // 
            // TxtComentarioPerdida
            // 
            this.TxtComentarioPerdida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtComentarioPerdida.Location = new System.Drawing.Point(320, 86);
            this.TxtComentarioPerdida.Multiline = true;
            this.TxtComentarioPerdida.Name = "TxtComentarioPerdida";
            this.TxtComentarioPerdida.Size = new System.Drawing.Size(175, 58);
            this.TxtComentarioPerdida.TabIndex = 0;
            // 
            // CmbProductosPerdidas
            // 
            this.CmbProductosPerdidas.FormattingEnabled = true;
            this.CmbProductosPerdidas.Location = new System.Drawing.Point(8, 33);
            this.CmbProductosPerdidas.Name = "CmbProductosPerdidas";
            this.CmbProductosPerdidas.Size = new System.Drawing.Size(168, 21);
            this.CmbProductosPerdidas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(8, 68);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(34, 13);
            this.asd.TabIndex = 2;
            this.asd.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad Perdida";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Comentario";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Perdido";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 133);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 0;
            // 
            // CmdBuscarPerdidas
            // 
            this.CmdBuscarPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdBuscarPerdidas.Location = new System.Drawing.Point(438, 12);
            this.CmdBuscarPerdidas.Name = "CmdBuscarPerdidas";
            this.CmdBuscarPerdidas.Size = new System.Drawing.Size(75, 23);
            this.CmdBuscarPerdidas.TabIndex = 1;
            this.CmdBuscarPerdidas.Text = "Buscar";
            this.CmdBuscarPerdidas.UseVisualStyleBackColor = true;
            // 
            // grdPerdiasConsulta
            // 
            this.grdPerdiasConsulta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdPerdiasConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPerdiasConsulta.Location = new System.Drawing.Point(8, 48);
            this.grdPerdiasConsulta.Name = "grdPerdiasConsulta";
            this.grdPerdiasConsulta.Size = new System.Drawing.Size(505, 150);
            this.grdPerdiasConsulta.TabIndex = 2;
            // 
            // Cmd
            // 
            this.Cmd.Location = new System.Drawing.Point(8, 182);
            this.Cmd.Name = "Cmd";
            this.Cmd.Size = new System.Drawing.Size(94, 40);
            this.Cmd.TabIndex = 4;
            this.Cmd.Text = "Guardar";
            this.Cmd.UseVisualStyleBackColor = true;
            // 
            // CmdCalcel
            // 
            this.CmdCalcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCalcel.Location = new System.Drawing.Point(401, 182);
            this.CmdCalcel.Name = "CmdCalcel";
            this.CmdCalcel.Size = new System.Drawing.Size(94, 40);
            this.CmdCalcel.TabIndex = 4;
            this.CmdCalcel.Text = "Salir";
            this.CmdCalcel.UseVisualStyleBackColor = true;
            // 
            // FrmLosses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 257);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmLosses";
            this.Text = "Perdidas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPerdiasConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbProductosPerdidas;
        private System.Windows.Forms.TextBox TxtComentarioPerdida;
        private System.Windows.Forms.TextBox TxtTotalPerdido;
        private System.Windows.Forms.TextBox TxtCostoPerdida;
        private System.Windows.Forms.Button CmdCalcel;
        private System.Windows.Forms.Button Cmd;
        private System.Windows.Forms.DataGridView grdPerdiasConsulta;
        private System.Windows.Forms.Button CmdBuscarPerdidas;
        private System.Windows.Forms.TextBox textBox1;
    }
}