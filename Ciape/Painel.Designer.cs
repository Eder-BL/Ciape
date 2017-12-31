namespace Ciape {
    partial class Painel {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.lblTotalRevisao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAtrasados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmPreparacao = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUltimoContato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblLinksCorrigir = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblLinksPendentes = new System.Windows.Forms.Label();
            this.estatLinksErro = new Bunifu.Framework.UI.BunifuGauge();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalRevisao
            // 
            this.lblTotalRevisao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRevisao.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblTotalRevisao.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRevisao.Location = new System.Drawing.Point(93, 257);
            this.lblTotalRevisao.Name = "lblTotalRevisao";
            this.lblTotalRevisao.Size = new System.Drawing.Size(186, 78);
            this.lblTotalRevisao.TabIndex = 0;
            this.lblTotalRevisao.Text = "0";
            this.lblTotalRevisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalRevisao.Click += new System.EventHandler(this.lblPendencias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(125, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total de links";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(155, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Revisão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(485, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Envios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(459, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Atrasados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAtrasados
            // 
            this.lblAtrasados.AutoSize = true;
            this.lblAtrasados.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblAtrasados.ForeColor = System.Drawing.Color.Red;
            this.lblAtrasados.Location = new System.Drawing.Point(476, 13);
            this.lblAtrasados.Name = "lblAtrasados";
            this.lblAtrasados.Size = new System.Drawing.Size(68, 78);
            this.lblAtrasados.TabIndex = 3;
            this.lblAtrasados.Text = "4";
            this.lblAtrasados.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(379, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Envios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(327, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Em preparação";
            // 
            // lblEmPreparacao
            // 
            this.lblEmPreparacao.AutoSize = true;
            this.lblEmPreparacao.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblEmPreparacao.ForeColor = System.Drawing.Color.Black;
            this.lblEmPreparacao.Location = new System.Drawing.Point(353, 257);
            this.lblEmPreparacao.Name = "lblEmPreparacao";
            this.lblEmPreparacao.Size = new System.Drawing.Size(103, 78);
            this.lblEmPreparacao.TabIndex = 6;
            this.lblEmPreparacao.Text = "12";
            this.lblEmPreparacao.Click += new System.EventHandler(this.lblEmPreparacao_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(584, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Urgente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label11.Location = new System.Drawing.Point(543, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Último contato";
            // 
            // lblUltimoContato
            // 
            this.lblUltimoContato.AutoSize = true;
            this.lblUltimoContato.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblUltimoContato.ForeColor = System.Drawing.Color.Black;
            this.lblUltimoContato.Location = new System.Drawing.Point(515, 257);
            this.lblUltimoContato.Name = "lblUltimoContato";
            this.lblUltimoContato.Size = new System.Drawing.Size(201, 78);
            this.lblUltimoContato.TabIndex = 9;
            this.lblUltimoContato.Text = "15/12";
            this.lblUltimoContato.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(303, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Urgente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(276, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pendências";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(280, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 78);
            this.label9.TabIndex = 12;
            this.label9.Text = "9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.Location = new System.Drawing.Point(154, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 17;
            this.label12.Text = "Revisão";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label13.Location = new System.Drawing.Point(102, 575);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Links para corrigir";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblLinksCorrigir
            // 
            this.lblLinksCorrigir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinksCorrigir.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblLinksCorrigir.ForeColor = System.Drawing.Color.Red;
            this.lblLinksCorrigir.Location = new System.Drawing.Point(92, 493);
            this.lblLinksCorrigir.Name = "lblLinksCorrigir";
            this.lblLinksCorrigir.Size = new System.Drawing.Size(186, 78);
            this.lblLinksCorrigir.TabIndex = 15;
            this.lblLinksCorrigir.Text = "0";
            this.lblLinksCorrigir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.Location = new System.Drawing.Point(374, 601);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 19);
            this.label15.TabIndex = 20;
            this.label15.Text = "Revisão";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.label16.Location = new System.Drawing.Point(327, 575);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 22);
            this.label16.TabIndex = 19;
            this.label16.Text = "Links pendentes";
            // 
            // lblLinksPendentes
            // 
            this.lblLinksPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLinksPendentes.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblLinksPendentes.ForeColor = System.Drawing.Color.Black;
            this.lblLinksPendentes.Location = new System.Drawing.Point(312, 493);
            this.lblLinksPendentes.Name = "lblLinksPendentes";
            this.lblLinksPendentes.Size = new System.Drawing.Size(186, 78);
            this.lblLinksPendentes.TabIndex = 18;
            this.lblLinksPendentes.Text = "0";
            this.lblLinksPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estatLinksErro
            // 
            this.estatLinksErro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("estatLinksErro.BackgroundImage")));
            this.estatLinksErro.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.estatLinksErro.Location = new System.Drawing.Point(547, 493);
            this.estatLinksErro.Margin = new System.Windows.Forms.Padding(6);
            this.estatLinksErro.Name = "estatLinksErro";
            this.estatLinksErro.ProgressBgColor = System.Drawing.Color.Gray;
            this.estatLinksErro.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.estatLinksErro.ProgressColor2 = System.Drawing.Color.Tomato;
            this.estatLinksErro.Size = new System.Drawing.Size(174, 117);
            this.estatLinksErro.Suffix = "";
            this.estatLinksErro.TabIndex = 21;
            this.estatLinksErro.Thickness = 30;
            this.estatLinksErro.Value = 0;
            this.estatLinksErro.Load += new System.EventHandler(this.estatLinksErro_Load);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(559, 601);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Percentual correção";
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.estatLinksErro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblLinksPendentes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLinksCorrigir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblUltimoContato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmPreparacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAtrasados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalRevisao);
            this.Name = "Painel";
            this.Size = new System.Drawing.Size(806, 658);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAtrasados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmPreparacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUltimoContato;
        public System.Windows.Forms.Label lblTotalRevisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lblLinksCorrigir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label lblLinksPendentes;
        private Bunifu.Framework.UI.BunifuGauge estatLinksErro;
        private System.Windows.Forms.Label label14;
    }
}
