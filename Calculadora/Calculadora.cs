using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrCalculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada {  get; set; }
        private enum Operacao
        {
           Soma,
           Subtracao,
           Multiplicacao,
           Divisao,
            Percentagem,
        }
        public FrCalculadora()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text +="0";
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void BtnTrês_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            LblOperacao.Text = "";
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fechar();
        }
        private void Fechar()
        {
            if (MessageBox.Show("Deseja sair do Programa?", "Sair", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)return;
            Application.Exit();
        }
        private void BtnDiviSão_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            LblOperacao.Text = "/";
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            LblOperacao.Text = "X";
        }

        private void BtnSubtração_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            LblOperacao.Text = "-";
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Soma;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            LblOperacao.Text = "+";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            decimal valorAtual;
            if (!decimal.TryParse(txtResultado.Text, out valorAtual))
            {
                MessageBox.Show("Entrada inválida. Por favor insira um número válido.");
                return;
            }

            switch (OperacaoSelecionada)
            {
                case Operacao.Soma:
                    Resultado = Valor + valorAtual;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - valorAtual;
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * valorAtual;  // Assume que valorAtual já está na forma decimal se necessário
                    break;
                case Operacao.Divisao:
                    if (valorAtual == 0)
                    {
                        MessageBox.Show("Divisão por zero não permitida.");
                        return;
                    }
                    Resultado = Valor / valorAtual;
                    break;
            }

            txtResultado.Text = Resultado.ToString();
            LblOperacao.Text = "=";
        }

        private decimal ParseDecimalInput(string input)
        {
            // Remove tudo exceto dígitos e vírgula ou ponto
            string normalizedInput = new string(input.Where(c => char.IsDigit(c) || c == ',' || c == '.').ToArray());

            // Substituir vírgula por ponto se necessário, dependendo da cultura
            normalizedInput = normalizedInput.Replace(',', '.');

            try
            {
                return Convert.ToDecimal(normalizedInput, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de número inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Retorna 0 ou algum valor padrão que você decidir
            }
        }


        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
        }

        private void BtnModulo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultado.Text))
            {
                // Converte o número de porcentagem (ex: 23% -> 0.23)
                decimal valorPorcentagem = Convert.ToDecimal(txtResultado.Text) / 100;
                txtResultado.Text = valorPorcentagem.ToString();
                LblOperacao.Text = "%";
            }
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta Calculadora Foi desemvoldida Por Mim em C#\n"+"Autor:DevJoel 2024 ©\n"
                +"Pais:Portugal"
                ,"Autor",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
