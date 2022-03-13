namespace Teste
{
    partial class frmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.label6 = new System.Windows.Forms.Label();
            this.txtVlTotal = new System.Windows.Forms.TextBox();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.dtgvItem = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoLiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNovo = new System.Windows.Forms.ToolStripButton();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btExcluir = new System.Windows.Forms.ToolStripButton();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.txtDtPedido = new System.Windows.Forms.MaskedTextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtNmCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNrPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Totais:";
            // 
            // txtVlTotal
            // 
            this.txtVlTotal.Location = new System.Drawing.Point(565, 318);
            this.txtVlTotal.Name = "txtVlTotal";
            this.txtVlTotal.ReadOnly = true;
            this.txtVlTotal.Size = new System.Drawing.Size(80, 20);
            this.txtVlTotal.TabIndex = 4;
            this.txtVlTotal.TabStop = false;
            this.txtVlTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(651, 318);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.ReadOnly = true;
            this.txtPesoTotal.Size = new System.Drawing.Size(80, 20);
            this.txtPesoTotal.TabIndex = 5;
            this.txtPesoTotal.TabStop = false;
            this.txtPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtgvItem
            // 
            this.dtgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.PrecoUnitario,
            this.PesoLiq,
            this.PrecoTotal,
            this.PesoTotal});
            this.dtgvItem.Location = new System.Drawing.Point(12, 146);
            this.dtgvItem.Name = "dtgvItem";
            this.dtgvItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvItem.Size = new System.Drawing.Size(734, 166);
            this.dtgvItem.TabIndex = 5;
            this.dtgvItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvItem_CellEndEdit);
            this.dtgvItem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvItem_CellMouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 80F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição do Produto";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descricao.Width = 200;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantidade.FillWeight = 70F;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantidade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantidade.Width = 70;
            // 
            // PrecoUnitario
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PrecoUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecoUnitario.FillWeight = 80F;
            this.PrecoUnitario.HeaderText = "Preco Unitário";
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.ReadOnly = true;
            this.PrecoUnitario.Width = 80;
            // 
            // PesoLiq
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.PesoLiq.DefaultCellStyle = dataGridViewCellStyle3;
            this.PesoLiq.FillWeight = 80F;
            this.PesoLiq.HeaderText = "Peso Liquido";
            this.PesoLiq.Name = "PesoLiq";
            this.PesoLiq.ReadOnly = true;
            this.PesoLiq.Width = 80;
            // 
            // PrecoTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.PrecoTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecoTotal.FillWeight = 80F;
            this.PrecoTotal.HeaderText = "Preço Total";
            this.PrecoTotal.Name = "PrecoTotal";
            this.PrecoTotal.ReadOnly = true;
            this.PrecoTotal.Width = 80;
            // 
            // PesoTotal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.PesoTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.PesoTotal.FillWeight = 80F;
            this.PesoTotal.HeaderText = "Peso Total";
            this.PesoTotal.Name = "PesoTotal";
            this.PesoTotal.ReadOnly = true;
            this.PesoTotal.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovo,
            this.btSalvar,
            this.btExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(753, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btNovo
            // 
            this.btNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(40, 22);
            this.btNovo.Text = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(42, 22);
            this.btSalvar.Text = "Salvar";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(46, 22);
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.btPesquisa);
            this.gbox.Controls.Add(this.txtDtPedido);
            this.gbox.Controls.Add(this.btnConsulta);
            this.gbox.Controls.Add(this.txtNmCliente);
            this.gbox.Controls.Add(this.label4);
            this.gbox.Controls.Add(this.txtCDCliente);
            this.gbox.Controls.Add(this.label2);
            this.gbox.Controls.Add(this.label1);
            this.gbox.Controls.Add(this.txtNrPedido);
            this.gbox.Location = new System.Drawing.Point(12, 28);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(734, 112);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "Pedido";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisa.Image")));
            this.btPesquisa.Location = new System.Drawing.Point(165, 75);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(24, 19);
            this.btPesquisa.TabIndex = 48;
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // txtDtPedido
            // 
            this.txtDtPedido.Location = new System.Drawing.Point(95, 45);
            this.txtDtPedido.Mask = "00/00/0000";
            this.txtDtPedido.Name = "txtDtPedido";
            this.txtDtPedido.Size = new System.Drawing.Size(68, 20);
            this.txtDtPedido.TabIndex = 2;
            this.txtDtPedido.TabStop = false;
            this.txtDtPedido.ValidatingType = typeof(System.DateTime);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(169, 19);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(61, 20);
            this.btnConsulta.TabIndex = 47;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtNmCliente
            // 
            this.txtNmCliente.Enabled = false;
            this.txtNmCliente.Location = new System.Drawing.Point(195, 74);
            this.txtNmCliente.Name = "txtNmCliente";
            this.txtNmCliente.Size = new System.Drawing.Size(496, 20);
            this.txtNmCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Cliente:";
            // 
            // txtCDCliente
            // 
            this.txtCDCliente.Location = new System.Drawing.Point(95, 74);
            this.txtCDCliente.Name = "txtCDCliente";
            this.txtCDCliente.Size = new System.Drawing.Size(68, 20);
            this.txtCDCliente.TabIndex = 3;
            this.txtCDCliente.Leave += new System.EventHandler(this.txtCDCliente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data Emissão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Número:";
            // 
            // txtNrPedido
            // 
            this.txtNrPedido.Enabled = false;
            this.txtNrPedido.Location = new System.Drawing.Point(95, 19);
            this.txtNrPedido.Name = "txtNrPedido";
            this.txtNrPedido.Size = new System.Drawing.Size(68, 20);
            this.txtNrPedido.TabIndex = 1;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 347);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgvItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVlTotal);
            this.Controls.Add(this.txtPesoTotal);
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItem)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVlTotal;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.DataGridView dtgvItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btNovo;
        private System.Windows.Forms.ToolStripButton btSalvar;
        private System.Windows.Forms.ToolStripButton btExcluir;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtNmCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNrPedido;
        private System.Windows.Forms.MaskedTextBox txtDtPedido;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoLiq;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoTotal;
    }
}