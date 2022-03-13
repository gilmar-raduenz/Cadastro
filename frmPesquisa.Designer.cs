namespace Teste
{
    partial class frmPesquisa
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
            this.dtgvPesquisa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPesquisa
            // 
            this.dtgvPesquisa.AllowUserToDeleteRows = false;
            this.dtgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPesquisa.Location = new System.Drawing.Point(2, 3);
            this.dtgvPesquisa.Name = "dtgvPesquisa";
            this.dtgvPesquisa.ReadOnly = true;
            this.dtgvPesquisa.Size = new System.Drawing.Size(394, 156);
            this.dtgvPesquisa.TabIndex = 0;
            this.dtgvPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPesquisa_CellClick);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 164);
            this.Controls.Add(this.dtgvPesquisa);
            this.Name = "frmPesquisa";
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPesquisa;
    }
}