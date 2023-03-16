using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas;
        // private ContaPoupanca Poupanca;
        private int numeroDeContas;

        private Dictionary<string, Conta> dicionario;

        public Form1()
        {
            InitializeComponent();
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas.Add(conta);
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
            comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            this.dicionario.Add(conta.Titular.Nome, conta);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dicionario = new Dictionary<string, Conta>();

            this.contas = new List<Conta>();

            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);
            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);
            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            foreach (Conta conta in contas)
            {
                // comboContas.Items.Add(conta.Titular.Nome);
                //comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            }

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = this.contas[indice];
            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Não é possivel sacar um valor negativo");
            }

        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {

            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Valor Depositado");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Valor Invalido");
            }

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceTransferencia = comboDestinoTransferencia.SelectedIndex;
            Conta selecionadaTransferencia = this.contas[indiceTransferencia];
            textoTitular.Text = selecionadaTransferencia.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionadaTransferencia.Saldo);
            textoNumero.Text = Convert.ToString(selecionadaTransferencia.Numero);
        }

        private void botaoTranfereEntreContas_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            int indiceTransferencia = Convert.ToInt32(comboDestinoTransferencia.SelectedIndex);
            double valor = Convert.ToDouble(textoValor.Text);
            Conta selecionada = this.contas[indice];
            Conta selecionadaTransferencia = this.contas[indiceTransferencia];
            contas[indice].Transfere(contas[indiceTransferencia], valor);
            textoSaldo.Text = Convert.ToString(contas[indice].Saldo);

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioCadastro = new FormCadastroConta(this);
            formularioCadastro.ShowDialog();

        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Adiciona(conta);

            MessageBox.Show("Total: " + totalizador.Total);
            totalizador.Adiciona(sv);
            MessageBox.Show("Total SV:" + totalizador.Total);

        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
           
            try
            {
                string nomeTitular = textoBuscaTitular.Text;
                Conta conta = dicionario[nomeTitular];

                textoTitular.Text = conta.Titular.Nome;
                textoNumero.Text = Convert.ToString(conta.Numero);
                textoSaldo.Text = Convert.ToString(conta.Saldo);
                MessageBox.Show("Busca Realizada com Sucesso !");
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Titular Não Localizado");
            }
                        
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }

}

