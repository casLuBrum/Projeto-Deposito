namespace Views
{
    partial class FrmBuscarNoArmazem
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
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Busca = new System.Windows.Forms.DataGridView();
            this.ArmazenarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prateleira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Item:";
            // 
            // Codigo_txt
            // 
            this.Codigo_txt.Location = new System.Drawing.Point(134, 62);
            this.Codigo_txt.Name = "Codigo_txt";
            this.Codigo_txt.Size = new System.Drawing.Size(194, 20);
            this.Codigo_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar Items";
            // 
            // dgv_Busca
            // 
            this.dgv_Busca.AllowUserToAddRows = false;
            this.dgv_Busca.AllowUserToDeleteRows = false;
            this.dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Busca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArmazenarID,
            this.Nome,
            this.ProdutoID,
            this.Prateleira,
            this.Coluna});
            this.dgv_Busca.Location = new System.Drawing.Point(24, 131);
            this.dgv_Busca.Name = "dgv_Busca";
            this.dgv_Busca.ReadOnly = true;
            this.dgv_Busca.Size = new System.Drawing.Size(453, 137);
            this.dgv_Busca.TabIndex = 3;
            // 
            // ArmazenarID
            // 
            this.ArmazenarID.DataPropertyName = "ArmazenarID";
            this.ArmazenarID.HeaderText = "ArmazenarID";
            this.ArmazenarID.Name = "ArmazenarID";
            this.ArmazenarID.ReadOnly = true;
            this.ArmazenarID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "ClienteID";
            this.Nome.HeaderText = "Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // ProdutoID
            // 
            this.ProdutoID.DataPropertyName = "ProdutoID";
            this.ProdutoID.HeaderText = "Codigo";
            this.ProdutoID.Name = "ProdutoID";
            this.ProdutoID.ReadOnly = true;
            // 
            // Prateleira
            // 
            this.Prateleira.DataPropertyName = "Prateleira";
            this.Prateleira.HeaderText = "Prateleira";
            this.Prateleira.Name = "Prateleira";
            this.Prateleira.ReadOnly = true;
            // 
            // Coluna
            // 
            this.Coluna.DataPropertyName = "Coluna";
            this.Coluna.HeaderText = "Coluna";
            this.Coluna.Name = "Coluna";
            this.Coluna.ReadOnly = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(348, 56);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(78, 30);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // FrmBuscarNoArmazem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 298);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dgv_Busca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigo_txt);
            this.Controls.Add(this.label1);
            this.Name = "FrmBuscarNoArmazem";
            this.Text = "Buscar Item";
            this.Load += new System.EventHandler(this.FrmBuscarNoArmazem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Busca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Codigo_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Busca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmazenarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prateleira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna;
        private System.Windows.Forms.Button btn_Buscar;
    }
}