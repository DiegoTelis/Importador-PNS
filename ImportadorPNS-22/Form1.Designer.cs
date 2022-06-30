namespace ImportadorPNS_22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTabela = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenhaSQL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIPSQL = new System.Windows.Forms.TextBox();
            this.btnNomeclatura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeclatura = new System.Windows.Forms.TextBox();
            this.btbEstrutura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstrutura = new System.Windows.Forms.TextBox();
            this.btnBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBasePNS = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHist = new System.Windows.Forms.Label();
            this.lblProx = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTabela);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSenhaSQL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIPSQL);
            this.panel1.Controls.Add(this.btnNomeclatura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNomeclatura);
            this.panel1.Controls.Add(this.btbEstrutura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEstrutura);
            this.panel1.Controls.Add(this.btnBase);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBasePNS);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 441);
            this.panel1.TabIndex = 0;
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTabela.Location = new System.Drawing.Point(149, 350);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(60, 21);
            this.lblTabela.TabIndex = 15;
            this.lblTabela.Text = "Tabelas";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(378, 23);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Senha Banco SQL";
            // 
            // txtSenhaSQL
            // 
            this.txtSenhaSQL.Location = new System.Drawing.Point(242, 24);
            this.txtSenhaSQL.Name = "txtSenhaSQL";
            this.txtSenhaSQL.PasswordChar = '*';
            this.txtSenhaSQL.Size = new System.Drawing.Size(131, 23);
            this.txtSenhaSQL.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "IP,Porta (Sql Server)";
            // 
            // txtIPSQL
            // 
            this.txtIPSQL.Location = new System.Drawing.Point(7, 24);
            this.txtIPSQL.Name = "txtIPSQL";
            this.txtIPSQL.Size = new System.Drawing.Size(131, 23);
            this.txtIPSQL.TabIndex = 1;
            // 
            // btnNomeclatura
            // 
            this.btnNomeclatura.Location = new System.Drawing.Point(320, 208);
            this.btnNomeclatura.Name = "btnNomeclatura";
            this.btnNomeclatura.Size = new System.Drawing.Size(75, 23);
            this.btnNomeclatura.TabIndex = 8;
            this.btnNomeclatura.Text = "Selecionar";
            this.btnNomeclatura.UseVisualStyleBackColor = true;
            this.btnNomeclatura.Click += new System.EventHandler(this.btnNomeclatura_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nomeclatura";
            // 
            // txtNomeclatura
            // 
            this.txtNomeclatura.Location = new System.Drawing.Point(7, 209);
            this.txtNomeclatura.Name = "txtNomeclatura";
            this.txtNomeclatura.Size = new System.Drawing.Size(293, 23);
            this.txtNomeclatura.TabIndex = 6;
            // 
            // btbEstrutura
            // 
            this.btbEstrutura.Location = new System.Drawing.Point(320, 146);
            this.btbEstrutura.Name = "btbEstrutura";
            this.btbEstrutura.Size = new System.Drawing.Size(75, 23);
            this.btbEstrutura.TabIndex = 5;
            this.btbEstrutura.Text = "Selecionar";
            this.btbEstrutura.UseVisualStyleBackColor = true;
            this.btbEstrutura.Click += new System.EventHandler(this.btbEstrutura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extrutura (xls)";
            // 
            // txtEstrutura
            // 
            this.txtEstrutura.Location = new System.Drawing.Point(7, 147);
            this.txtEstrutura.Name = "txtEstrutura";
            this.txtEstrutura.Size = new System.Drawing.Size(293, 23);
            this.txtEstrutura.TabIndex = 3;
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(320, 82);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(75, 23);
            this.btnBase.TabIndex = 2;
            this.btnBase.Text = "Selecionar";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base microdados PNS";
            // 
            // txtBasePNS
            // 
            this.txtBasePNS.Location = new System.Drawing.Point(7, 83);
            this.txtBasePNS.Name = "txtBasePNS";
            this.txtBasePNS.Size = new System.Drawing.Size(293, 23);
            this.txtBasePNS.TabIndex = 0;
            // 
            // 
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(420, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 441);
            this.panel2.TabIndex = 1;
            // 
            // lblHist
            // 
            this.lblHist.AutoSize = true;
            this.lblHist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHist.Location = new System.Drawing.Point(21, 155);
            this.lblHist.Name = "lblHist";
            this.lblHist.Size = new System.Drawing.Size(94, 15);
            this.lblHist.TabIndex = 2;
            this.lblHist.Text = "Tabelas prontas: ";
            // 
            // lblProx
            // 
            this.lblProx.AutoSize = true;
            this.lblProx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblProx.Location = new System.Drawing.Point(21, 86);
            this.lblProx.Name = "lblProx";
            this.lblProx.Size = new System.Drawing.Size(0, 15);
            this.lblProx.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtBasePNS;
        private Label label1;
        private Label label4;
        private TextBox txtIPSQL;
        private Button btnNomeclatura;
        private Label label3;
        private TextBox txtNomeclatura;
        private Button btbEstrutura;
        private Label label2;
        private TextBox txtEstrutura;
        private Button btnBase;
        private Label label5;
        private TextBox txtSenhaSQL;
        private ProgressBar progressBar1;
        private Button button1;
        private Panel panel2;
        private Label lblTabela;
        private Label lblHist;
        private Label lblProx;
    }
}