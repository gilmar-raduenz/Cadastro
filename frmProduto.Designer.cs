namespace Teste
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDsProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCdProduto = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btNovo = new System.Windows.Forms.ToolStripButton();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtVlPesoLiq = new System.Windows.Forms.TextBox();
            this.txtVlUnitario = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Preço Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Peso Líquido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descrição:";
            // 
            // txtDsProduto
            // 
            this.txtDsProduto.Location = new System.Drawing.Point(89, 77);
            this.txtDsProduto.Name = "txtDsProduto";
            this.txtDsProduto.Size = new System.Drawing.Size(420, 20);
            this.txtDsProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // txtCdProduto
            // 
            this.txtCdProduto.Enabled = false;
            this.txtCdProduto.Location = new System.Drawing.Point(89, 51);
            this.txtCdProduto.Name = "txtCdProduto";
            this.txtCdProduto.Size = new System.Drawing.Size(55, 20);
            this.txtCdProduto.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovo,
            this.btSalvar,
            this.btExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 20;
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
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(150, 51);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(61, 20);
            this.btnConsulta.TabIndex = 21;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtVlPesoLiq
            // 
            this.txtVlPesoLiq.Location = new System.Drawing.Point(89, 106);
            this.txtVlPesoLiq.Name = "txtVlPesoLiq";
            this.txtVlPesoLiq.Size = new System.Drawing.Size(71, 20);
            this.txtVlPesoLiq.TabIndex = 2;
            this.txtVlPesoLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlPesoLiq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlPesoLiq_KeyPress);
            // 
            // txtVlUnitario
            // 
            this.txtVlUnitario.Location = new System.Drawing.Point(288, 109);
            this.txtVlUnitario.Name = "txtVlUnitario";
            this.txtVlUnitario.Size = new System.Drawing.Size(81, 20);
            this.txtVlUnitario.TabIndex = 3;
            this.txtVlUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVlUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlUnitario_KeyPress);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 144);
            this.Controls.Add(this.txtVlUnitario);
            this.Controls.Add(this.txtVlPesoLiq);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDsProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCdProduto);
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDsProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCdProduto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btSalvar;
        private System.Windows.Forms.ToolStripButton btExcluir;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ToolStripButton btNovo;
        private System.Windows.Forms.TextBox txtVlPesoLiq;
        private System.Windows.Forms.TextBox txtVlUnitario;
    }
}