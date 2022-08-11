namespace aula220822
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_exibir = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subt = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_raiz = new System.Windows.Forms.Button();
            this.btn_potencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(31, 253);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_exibir.TabIndex = 4;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(311, 120);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_msg.TabIndex = 5;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(141, 253);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(256, 253);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(150, 61);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 8;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(96, 64);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Location = new System.Drawing.Point(78, 96);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(56, 13);
            this.lbl_num1.TabIndex = 10;
            this.lbl_num1.Text = "Número 1:";
            this.lbl_num1.Click += new System.EventHandler(this.lbl_num1_Click);
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(78, 120);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(56, 13);
            this.lbl_num2.TabIndex = 12;
            this.lbl_num2.Text = "Número 2:";
            this.lbl_num2.Click += new System.EventHandler(this.lbl_num2_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(150, 120);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 13;
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(150, 93);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 14;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(31, 204);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(30, 30);
            this.btn_soma.TabIndex = 15;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subt
            // 
            this.btn_subt.Location = new System.Drawing.Point(81, 204);
            this.btn_subt.Name = "btn_subt";
            this.btn_subt.Size = new System.Drawing.Size(30, 30);
            this.btn_subt.TabIndex = 16;
            this.btn_subt.Text = "-";
            this.btn_subt.UseVisualStyleBackColor = true;
            this.btn_subt.Click += new System.EventHandler(this.btn_subt_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(132, 204);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(30, 30);
            this.btn_mult.TabIndex = 17;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(186, 204);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(30, 30);
            this.btn_div.TabIndex = 18;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_raiz
            // 
            this.btn_raiz.Location = new System.Drawing.Point(278, 204);
            this.btn_raiz.Name = "btn_raiz";
            this.btn_raiz.Size = new System.Drawing.Size(53, 30);
            this.btn_raiz.TabIndex = 19;
            this.btn_raiz.Text = "Raiz";
            this.btn_raiz.UseVisualStyleBackColor = true;
            this.btn_raiz.Click += new System.EventHandler(this.btn_raiz_Click);
            // 
            // btn_potencia
            // 
            this.btn_potencia.Location = new System.Drawing.Point(236, 204);
            this.btn_potencia.Name = "btn_potencia";
            this.btn_potencia.Size = new System.Drawing.Size(30, 30);
            this.btn_potencia.TabIndex = 20;
            this.btn_potencia.Text = "^";
            this.btn_potencia.UseVisualStyleBackColor = true;
            this.btn_potencia.Click += new System.EventHandler(this.btn_potencia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(532, 355);
            this.Controls.Add(this.btn_potencia);
            this.Controls.Add(this.btn_raiz);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_subt);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_exibir);
            this.Name = "Form1";
            this.Text = "Aula1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subt;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_raiz;
        private System.Windows.Forms.Button btn_potencia;
    }
}

