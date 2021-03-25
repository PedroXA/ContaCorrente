using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string numeroConta = txt_contaBancaria.Text;
            string nomeTitular = txt_titular.Text;
            double saldoAtual = double.Parse(txt_saldoAtual.Text);
            double valor = double.Parse(txt_movimentacao.Text);

            //desabilitar dados da conta:

            txt_contaBancaria.Enabled = false;
            txt_titular.Enabled = false;
            txt_saldoAtual.Enabled = false;

            if (rdb_deposito.Checked) { //se o usuário selecionou a opção de Depósito
                saldoAtual = saldoAtual + valor;

            }
            else if (rdb_retirada.Checked)
            {
                saldoAtual = saldoAtual - valor;
            }
            else
            {
                MessageBox.Show("Selecione uma operação.");
            }

            txt_saldoAtual.Text = saldoAtual.ToString();
        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }

        private void btn_novaconta_Click(object sender, EventArgs e)
        {
            txt_contaBancaria.Enabled = true;
            txt_titular.Enabled = true;
            txt_saldoAtual.Enabled = true;
            txt_titular.Clear();
            txt_contaBancaria.Clear();
            txt_saldoAtual.Text = "0";
            rdb_deposito.Checked = false;
            rdb_retirada.Checked = false;
            txt_movimentacao.Text = "0";
        }
    }
}
