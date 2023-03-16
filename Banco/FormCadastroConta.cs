using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Busca;
using Banco.Contas;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;

        private Form1 formPrincipal; 
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }
                    
        public void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool ehDevedor = false;
            for (int i = 0; i < 30000; i++)
            {
                 ehDevedor = this.devedores.Contains(titular);
            }
            if (!ehDevedor)
            {
                Conta novaConta;

                if (comboTipoConta.SelectedIndex == 0)
                {
                    novaConta = new ContaCorrente();
                    MessageBox.Show("Conta Corrente Criada");
                }
                else
                {
                    novaConta = new ContaPoupanca();
                    MessageBox.Show("Conta Poupanca Criada");
                }
                novaConta.Titular = new Cliente(textoTitular.Text);
                //  novaConta.Numero = Convert.ToInt32(TextoNumero.Text);

                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                MessageBox.Show("Devedor");
            }
                                       
               
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            TextoNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
    }

