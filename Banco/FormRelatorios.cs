﻿using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banco
{
    public partial class FormRelatorios : Form
    {

        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();

            try
            {
                var resultado = contas
                              .Where(c => c.Saldo > 5000)
                              .OrderBy(c => c.Titular.Nome)
                              .ThenBy(c => c.Numero);


                foreach (var c in resultado)
                {
                    listaResultado.Items.Add(c.Titular.Nome);
                }

                double saldoTotal = resultado.Sum(c => c.Saldo);
                double maiorTotal = resultado.Max(c => c.Saldo);

                labelSaldoTotal.Text = Convert.ToString(saldoTotal);
                labelMaiorSaldo.Text = Convert.ToString(maiorTotal);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Operação sem resultado");
            }
        }

        private void butaoAntigas_Click(object sender, EventArgs e)
        {

            listaResultado.Items.Clear();

            var antigas = contas
                     .Where(c => c.Numero < 10 && c.Saldo > 1000)
                     .OrderBy(c => c.Titular.Nome)
                     .ThenBy(c => c.Numero);

            foreach (var c in antigas)
            {
                listaResultado.Items.Add(c.Titular.Nome);
            }


        }
    }
}
