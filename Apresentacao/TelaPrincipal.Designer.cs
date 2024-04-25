namespace WindowsFormsApp3
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.pnltela = new System.Windows.Forms.Panel();
            this.btncliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncliente);
            this.panel1.Controls.Add(this.btnfornecedor);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Location = new System.Drawing.Point(15, 10);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(213, 56);
            this.btnfornecedor.TabIndex = 0;
            this.btnfornecedor.Text = "Fornecedor";
            this.btnfornecedor.UseVisualStyleBackColor = true;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // pnltela
            // 
            this.pnltela.Location = new System.Drawing.Point(3, 89);
            this.pnltela.Name = "pnltela";
            this.pnltela.Size = new System.Drawing.Size(1017, 490);
            this.pnltela.TabIndex = 1;
            // 
            // btncliente
            // 
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Location = new System.Drawing.Point(234, 10);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(213, 56);
            this.btncliente.TabIndex = 1;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 591);
            this.Controls.Add(this.pnltela);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Panel pnltela;
        private System.Windows.Forms.Button btncliente;
    }
}

