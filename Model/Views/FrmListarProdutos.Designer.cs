namespace Views
{
    partial class FrmListarProdutos
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
            this.dgv_Prod = new System.Windows.Forms.DataGridView();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Prod
            // 
            this.dgv_Prod.AllowUserToAddRows = false;
            this.dgv_Prod.AllowUserToDeleteRows = false;
            this.dgv_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoID,
            this.Nome,
            this.Peso});
            this.dgv_Prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Prod.Location = new System.Drawing.Point(0, 0);
            this.dgv_Prod.Name = "dgv_Prod";
            this.dgv_Prod.ReadOnly = true;
            this.dgv_Prod.Size = new System.Drawing.Size(306, 315);
            this.dgv_Prod.TabIndex = 0;
            this.dgv_Prod.SelectionChanged += new System.EventHandler(this.dgv_Produtos_SelectionChanged);
            // 
            // ProdutoID
            // 
            this.ProdutoID.DataPropertyName = "ProdutoID";
            this.ProdutoID.HeaderText = "ID:";
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome:";
            this.Nome.Name = "Nome";
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso:";
            this.Peso.Name = "Peso";
            // 
            // FrmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 315);
            this.Controls.Add(this.dgv_Prod);
            this.Name = "FrmListarProdutos";
            this.Text = "FrmListarProdutos";
            this.Load += new System.EventHandler(this.FrmListarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
    }
}