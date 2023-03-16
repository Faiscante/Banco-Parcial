namespace Banco
{
    partial class FormRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saldoTotal = new System.Windows.Forms.Label();
            this.maiorSaldo = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.botaoAntigas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(31, 403);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(240, 35);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo Maior Que 5000";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaiorSaldo);
            this.groupBox1.Controls.Add(this.labelSaldoTotal);
            this.groupBox1.Controls.Add(this.maiorSaldo);
            this.groupBox1.Controls.Add(this.saldoTotal);
            this.groupBox1.Location = new System.Drawing.Point(31, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // saldoTotal
            // 
            this.saldoTotal.AutoSize = true;
            this.saldoTotal.Location = new System.Drawing.Point(15, 40);
            this.saldoTotal.Name = "saldoTotal";
            this.saldoTotal.Size = new System.Drawing.Size(61, 13);
            this.saldoTotal.TabIndex = 0;
            this.saldoTotal.Text = "Saldo Total";
            // 
            // maiorSaldo
            // 
            this.maiorSaldo.AutoSize = true;
            this.maiorSaldo.Location = new System.Drawing.Point(15, 102);
            this.maiorSaldo.Name = "maiorSaldo";
            this.maiorSaldo.Size = new System.Drawing.Size(63, 13);
            this.maiorSaldo.TabIndex = 1;
            this.maiorSaldo.Text = "Maior Saldo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(424, 40);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(81, 13);
            this.labelSaldoTotal.TabIndex = 2;
            this.labelSaldoTotal.Text = "IabelSaldoTotal";
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(31, 27);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(581, 173);
            this.listaResultado.TabIndex = 4;
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(423, 102);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(82, 13);
            this.labelMaiorSaldo.TabIndex = 3;
            this.labelMaiorSaldo.Text = "labelMaiorSaldo";
            // 
            // botaoAntigas
            // 
            this.botaoAntigas.Location = new System.Drawing.Point(457, 403);
            this.botaoAntigas.Name = "botaoAntigas";
            this.botaoAntigas.Size = new System.Drawing.Size(120, 29);
            this.botaoAntigas.TabIndex = 5;
            this.botaoAntigas.Text = "Antigas";
            this.botaoAntigas.UseVisualStyleBackColor = true;
            this.botaoAntigas.Click += new System.EventHandler(this.butaoAntigas_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoAntigas);
            this.Controls.Add(this.listaResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label maiorSaldo;
        private System.Windows.Forms.Label saldoTotal;
        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Button botaoAntigas;
    }
}