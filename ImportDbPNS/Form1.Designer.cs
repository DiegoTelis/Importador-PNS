namespace ImportDbPNS
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMicroDados = new System.Windows.Forms.TextBox();
            this.txtArqEstrutural = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArqEstrutural = new System.Windows.Forms.Button();
            this.lblValidaEstrutura = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNomeclatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNomeclatura = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenhaBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(12, 58);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Seleciar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione Arquivo do Microdados .txt";
            // 
            // txtMicroDados
            // 
            this.txtMicroDados.Location = new System.Drawing.Point(12, 30);
            this.txtMicroDados.Name = "txtMicroDados";
            this.txtMicroDados.Size = new System.Drawing.Size(196, 20);
            this.txtMicroDados.TabIndex = 1;
            this.txtMicroDados.TabStop = false;
            // 
            // txtArqEstrutural
            // 
            this.txtArqEstrutural.Location = new System.Drawing.Point(12, 121);
            this.txtArqEstrutural.Name = "txtArqEstrutural";
            this.txtArqEstrutural.Size = new System.Drawing.Size(196, 20);
            this.txtArqEstrutural.TabIndex = 2;
            this.txtArqEstrutural.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione Arquivo Extrutural .xls";
            // 
            // btnArqEstrutural
            // 
            this.btnArqEstrutural.Location = new System.Drawing.Point(12, 149);
            this.btnArqEstrutural.Name = "btnArqEstrutural";
            this.btnArqEstrutural.Size = new System.Drawing.Size(75, 23);
            this.btnArqEstrutural.TabIndex = 3;
            this.btnArqEstrutural.Text = "Carregar";
            this.btnArqEstrutural.UseVisualStyleBackColor = true;
            this.btnArqEstrutural.Click += new System.EventHandler(this.btnArqEstrutural_Click);
            // 
            // lblValidaEstrutura
            // 
            this.lblValidaEstrutura.AutoSize = true;
            this.lblValidaEstrutura.Location = new System.Drawing.Point(228, 125);
            this.lblValidaEstrutura.Name = "lblValidaEstrutura";
            this.lblValidaEstrutura.Size = new System.Drawing.Size(65, 13);
            this.lblValidaEstrutura.TabIndex = 6;
            this.lblValidaEstrutura.Text = "Label Valida";
            this.lblValidaEstrutura.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(361, 225);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Realizar Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(382, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // txtNomeclatura
            // 
            this.txtNomeclatura.Location = new System.Drawing.Point(12, 246);
            this.txtNomeclatura.Name = "txtNomeclatura";
            this.txtNomeclatura.Size = new System.Drawing.Size(196, 20);
            this.txtNomeclatura.TabIndex = 11;
            this.txtNomeclatura.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Importar Nomeclatura .xls";
            // 
            // btnNomeclatura
            // 
            this.btnNomeclatura.Location = new System.Drawing.Point(12, 274);
            this.btnNomeclatura.Name = "btnNomeclatura";
            this.btnNomeclatura.Size = new System.Drawing.Size(75, 23);
            this.btnNomeclatura.TabIndex = 4;
            this.btnNomeclatura.Text = "Carregar";
            this.btnNomeclatura.UseVisualStyleBackColor = true;
            this.btnNomeclatura.Click += new System.EventHandler(this.btnNomeclatura_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(361, 30);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(133, 20);
            this.txtEndereco.TabIndex = 0;
            this.txtEndereco.Text = "192.168.10.51,3739";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Endereço BD SQL";
            // 
            // txtSenhaBD
            // 
            this.txtSenhaBD.Location = new System.Drawing.Point(361, 93);
            this.txtSenhaBD.Name = "txtSenhaBD";
            this.txtSenhaBD.PasswordChar = '*';
            this.txtSenhaBD.Size = new System.Drawing.Size(133, 20);
            this.txtSenhaBD.TabIndex = 1;
            this.txtSenhaBD.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Senha BD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 323);
            this.Controls.Add(this.txtSenhaBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeclatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNomeclatura);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblValidaEstrutura);
            this.Controls.Add(this.txtArqEstrutural);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArqEstrutural);
            this.Controls.Add(this.txtMicroDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelecionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMicroDados;
        private System.Windows.Forms.TextBox txtArqEstrutural;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArqEstrutural;
        private System.Windows.Forms.Label lblValidaEstrutura;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNomeclatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNomeclatura;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaBD;
        private System.Windows.Forms.Label label5;
    }
}

