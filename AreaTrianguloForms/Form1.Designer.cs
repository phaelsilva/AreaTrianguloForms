namespace AreaTrianguloForms
{
    partial class Form1
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
            this.txbBase = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txbCalcular = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbBase
            // 
            this.txbBase.Location = new System.Drawing.Point(311, 107);
            this.txbBase.Name = "txbBase";
            this.txbBase.Size = new System.Drawing.Size(100, 20);
            this.txbBase.TabIndex = 0;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(311, 145);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(263, 110);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(263, 151);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            // 
            // txbCalcular
            // 
            this.txbCalcular.Location = new System.Drawing.Point(311, 200);
            this.txbCalcular.Name = "txbCalcular";
            this.txbCalcular.Size = new System.Drawing.Size(100, 40);
            this.txbCalcular.TabIndex = 4;
            this.txbCalcular.Text = "Calcular";
            this.txbCalcular.UseVisualStyleBackColor = true;
            this.txbCalcular.Click += new System.EventHandler(this.txbCalcular_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Enabled = false;
            this.txbResultado.Location = new System.Drawing.Point(289, 276);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(148, 20);
            this.txbResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbBase);
            this.Name = "Form1";
            this.Text = "ÁreaTriangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBase;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button txbCalcular;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

