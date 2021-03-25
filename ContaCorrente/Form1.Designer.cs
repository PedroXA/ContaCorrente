
namespace ContaCorrente
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
            this.txt_contaBancaria = new System.Windows.Forms.TextBox();
            this.txt_saldoAtual = new System.Windows.Forms.TextBox();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.lbl_contabancaria = new System.Windows.Forms.Label();
            this.lbl_titular = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.rdb_deposito = new System.Windows.Forms.RadioButton();
            this.rdb_retirada = new System.Windows.Forms.RadioButton();
            this.pnl_movimentacao = new System.Windows.Forms.Panel();
            this.btn_novaconta = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txt_movimentacao = new System.Windows.Forms.TextBox();
            this.pnl_movimentacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_contaBancaria
            // 
            this.txt_contaBancaria.Location = new System.Drawing.Point(143, 28);
            this.txt_contaBancaria.Name = "txt_contaBancaria";
            this.txt_contaBancaria.Size = new System.Drawing.Size(126, 20);
            this.txt_contaBancaria.TabIndex = 0;
            this.txt_contaBancaria.Text = "0";
            // 
            // txt_saldoAtual
            // 
            this.txt_saldoAtual.Location = new System.Drawing.Point(380, 111);
            this.txt_saldoAtual.Name = "txt_saldoAtual";
            this.txt_saldoAtual.Size = new System.Drawing.Size(100, 20);
            this.txt_saldoAtual.TabIndex = 1;
            this.txt_saldoAtual.Text = "0";
            // 
            // txt_titular
            // 
            this.txt_titular.Location = new System.Drawing.Point(143, 67);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(337, 20);
            this.txt_titular.TabIndex = 2;
            // 
            // lbl_contabancaria
            // 
            this.lbl_contabancaria.AutoSize = true;
            this.lbl_contabancaria.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contabancaria.Location = new System.Drawing.Point(1, 28);
            this.lbl_contabancaria.Name = "lbl_contabancaria";
            this.lbl_contabancaria.Size = new System.Drawing.Size(136, 23);
            this.lbl_contabancaria.TabIndex = 3;
            this.lbl_contabancaria.Text = "Conta bancária";
            // 
            // lbl_titular
            // 
            this.lbl_titular.AutoSize = true;
            this.lbl_titular.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titular.Location = new System.Drawing.Point(1, 64);
            this.lbl_titular.Name = "lbl_titular";
            this.lbl_titular.Size = new System.Drawing.Size(136, 23);
            this.lbl_titular.TabIndex = 4;
            this.lbl_titular.Text = "Nome do titular";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(316, 106);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(58, 23);
            this.lbl_saldo.TabIndex = 5;
            this.lbl_saldo.Text = "Saldo";
            this.lbl_saldo.Click += new System.EventHandler(this.lbl_saldo_Click);
            // 
            // rdb_deposito
            // 
            this.rdb_deposito.AutoSize = true;
            this.rdb_deposito.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_deposito.Location = new System.Drawing.Point(21, 9);
            this.rdb_deposito.Name = "rdb_deposito";
            this.rdb_deposito.Size = new System.Drawing.Size(99, 27);
            this.rdb_deposito.TabIndex = 6;
            this.rdb_deposito.TabStop = true;
            this.rdb_deposito.Text = "Deposito";
            this.rdb_deposito.UseVisualStyleBackColor = true;
            // 
            // rdb_retirada
            // 
            this.rdb_retirada.AutoSize = true;
            this.rdb_retirada.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_retirada.Location = new System.Drawing.Point(21, 42);
            this.rdb_retirada.Name = "rdb_retirada";
            this.rdb_retirada.Size = new System.Drawing.Size(101, 27);
            this.rdb_retirada.TabIndex = 7;
            this.rdb_retirada.TabStop = true;
            this.rdb_retirada.Text = "Retirada";
            this.rdb_retirada.UseVisualStyleBackColor = true;
            // 
            // pnl_movimentacao
            // 
            this.pnl_movimentacao.Controls.Add(this.btn_novaconta);
            this.pnl_movimentacao.Controls.Add(this.btn_confirmar);
            this.pnl_movimentacao.Controls.Add(this.txt_movimentacao);
            this.pnl_movimentacao.Controls.Add(this.rdb_deposito);
            this.pnl_movimentacao.Controls.Add(this.rdb_retirada);
            this.pnl_movimentacao.Location = new System.Drawing.Point(12, 186);
            this.pnl_movimentacao.Name = "pnl_movimentacao";
            this.pnl_movimentacao.Size = new System.Drawing.Size(468, 86);
            this.pnl_movimentacao.TabIndex = 8;
            // 
            // btn_novaconta
            // 
            this.btn_novaconta.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novaconta.Location = new System.Drawing.Point(328, 42);
            this.btn_novaconta.Name = "btn_novaconta";
            this.btn_novaconta.Size = new System.Drawing.Size(137, 37);
            this.btn_novaconta.TabIndex = 11;
            this.btn_novaconta.Text = "Nova conta";
            this.btn_novaconta.UseVisualStyleBackColor = true;
            this.btn_novaconta.Click += new System.EventHandler(this.btn_novaconta_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Font = new System.Drawing.Font("Polo Brush MF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.Location = new System.Drawing.Point(328, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(137, 37);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txt_movimentacao
            // 
            this.txt_movimentacao.Location = new System.Drawing.Point(126, 31);
            this.txt_movimentacao.Name = "txt_movimentacao";
            this.txt_movimentacao.Size = new System.Drawing.Size(115, 20);
            this.txt_movimentacao.TabIndex = 9;
            this.txt_movimentacao.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 299);
            this.Controls.Add(this.pnl_movimentacao);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_titular);
            this.Controls.Add(this.lbl_contabancaria);
            this.Controls.Add(this.txt_titular);
            this.Controls.Add(this.txt_saldoAtual);
            this.Controls.Add(this.txt_contaBancaria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_movimentacao.ResumeLayout(false);
            this.pnl_movimentacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_contaBancaria;
        private System.Windows.Forms.TextBox txt_saldoAtual;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.Label lbl_contabancaria;
        private System.Windows.Forms.Label lbl_titular;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.RadioButton rdb_deposito;
        private System.Windows.Forms.RadioButton rdb_retirada;
        private System.Windows.Forms.Panel pnl_movimentacao;
        private System.Windows.Forms.Button btn_novaconta;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox txt_movimentacao;
    }
}

