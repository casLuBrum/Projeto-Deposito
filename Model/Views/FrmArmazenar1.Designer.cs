namespace Views
{
    partial class FrmArmazenar1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.cb_Itens = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prateleira_txt = new System.Windows.Forms.TextBox();
            this.Coluna_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Iten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prateleira:";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(73, 39);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(237, 21);
            this.cb_Cliente.TabIndex = 3;
            this.cb_Cliente.SelectedIndexChanged += new System.EventHandler(this.cb_Cliente_SelectedIndexChanged);
            // 
            // cb_Itens
            // 
            this.cb_Itens.FormattingEnabled = true;
            this.cb_Itens.Location = new System.Drawing.Point(73, 70);
            this.cb_Itens.Name = "cb_Itens";
            this.cb_Itens.Size = new System.Drawing.Size(237, 21);
            this.cb_Itens.TabIndex = 4;
            this.cb_Itens.SelectedIndexChanged += new System.EventHandler(this.cb_Itens_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coluna:";
            // 
            // Prateleira_txt
            // 
            this.Prateleira_txt.Location = new System.Drawing.Point(85, 104);
            this.Prateleira_txt.Name = "Prateleira_txt";
            this.Prateleira_txt.Size = new System.Drawing.Size(84, 20);
            this.Prateleira_txt.TabIndex = 6;
            // 
            // Coluna_txt
            // 
            this.Coluna_txt.Location = new System.Drawing.Point(226, 105);
            this.Coluna_txt.Name = "Coluna_txt";
            this.Coluna_txt.Size = new System.Drawing.Size(84, 20);
            this.Coluna_txt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmArmazenar1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 210);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Coluna_txt);
            this.Controls.Add(this.Prateleira_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Itens);
            this.Controls.Add(this.cb_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmArmazenar1";
            this.Text = "FrmArmazenar1";
            this.Load += new System.EventHandler(this.FrmArmazenar1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.ComboBox cb_Itens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Prateleira_txt;
        private System.Windows.Forms.TextBox Coluna_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}