namespace WS02._1
{
    partial class FrmBuscaCEP
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
            this.btnCEP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(216, 10);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(75, 23);
            this.btnCEP.TabIndex = 0;
            this.btnCEP.Text = "Buscar";
            this.btnCEP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(88, 12);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 2;
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(12, 48);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(0, 13);
            this.lblLocalidade.TabIndex = 3;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(12, 73);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(0, 13);
            this.lblUF.TabIndex = 4;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(12, 96);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(0, 13);
            this.lblLogradouro.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 120);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(0, 13);
            this.lblBairro.TabIndex = 6;
            // 
            // FrmBuscaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblLocalidade);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCEP);
            this.Name = "FrmBuscaCEP";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblBairro;
    }
}

