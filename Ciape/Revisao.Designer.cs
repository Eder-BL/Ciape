namespace Ciape {
    partial class Revisao {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvRevisao = new System.Windows.Forms.DataGridView();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.lblErros = new System.Windows.Forms.Label();
            this.tabRevisao = new System.Windows.Forms.TabControl();
            this.tabCorrigir = new System.Windows.Forms.TabPage();
            this.btnPendente = new System.Windows.Forms.Button();
            this.dgvCorrigir = new System.Windows.Forms.DataGridView();
            this.tabPendentes = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.tabAprovados = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisao)).BeginInit();
            this.tabRevisao.SuspendLayout();
            this.tabCorrigir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrigir)).BeginInit();
            this.tabPendentes.SuspendLayout();
            this.tabAprovados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(19, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revisão";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtLink.ForeColor = System.Drawing.Color.Silver;
            this.txtLink.Location = new System.Drawing.Point(381, 166);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(392, 30);
            this.txtLink.TabIndex = 1;
            this.txtLink.Text = "Link";
            this.txtLink.Enter += new System.EventHandler(this.txtLink_Enter);
            this.txtLink.Leave += new System.EventHandler(this.txtLink_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtDescricao.ForeColor = System.Drawing.Color.Silver;
            this.txtDescricao.Location = new System.Drawing.Point(33, 166);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(342, 30);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "Descrição";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(655, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvRevisao
            // 
            this.dgvRevisao.AllowUserToOrderColumns = true;
            this.dgvRevisao.BackgroundColor = System.Drawing.Color.White;
            this.dgvRevisao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevisao.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRevisao.Location = new System.Drawing.Point(1, 3);
            this.dgvRevisao.Name = "dgvRevisao";
            this.dgvRevisao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevisao.Size = new System.Drawing.Size(738, 236);
            this.dgvRevisao.TabIndex = 4;
            this.dgvRevisao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevisao_CellContentClick);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnAprovar.ForeColor = System.Drawing.Color.White;
            this.btnAprovar.Location = new System.Drawing.Point(617, 245);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(118, 36);
            this.btnAprovar.TabIndex = 5;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblErros.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblErros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.lblErros.Location = new System.Drawing.Point(30, 239);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(0, 16);
            this.lblErros.TabIndex = 6;
            // 
            // tabRevisao
            // 
            this.tabRevisao.Controls.Add(this.tabCorrigir);
            this.tabRevisao.Controls.Add(this.tabPendentes);
            this.tabRevisao.Controls.Add(this.tabAprovados);
            this.tabRevisao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRevisao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabRevisao.Location = new System.Drawing.Point(29, 325);
            this.tabRevisao.Name = "tabRevisao";
            this.tabRevisao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabRevisao.SelectedIndex = 0;
            this.tabRevisao.Size = new System.Drawing.Size(751, 319);
            this.tabRevisao.TabIndex = 7;
            // 
            // tabCorrigir
            // 
            this.tabCorrigir.Controls.Add(this.btnPendente);
            this.tabCorrigir.Controls.Add(this.dgvCorrigir);
            this.tabCorrigir.ForeColor = System.Drawing.Color.Black;
            this.tabCorrigir.Location = new System.Drawing.Point(4, 26);
            this.tabCorrigir.Name = "tabCorrigir";
            this.tabCorrigir.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorrigir.Size = new System.Drawing.Size(743, 289);
            this.tabCorrigir.TabIndex = 2;
            this.tabCorrigir.Text = "Corrigir";
            this.tabCorrigir.UseVisualStyleBackColor = true;
            // 
            // btnPendente
            // 
            this.btnPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnPendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendente.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnPendente.ForeColor = System.Drawing.Color.White;
            this.btnPendente.Location = new System.Drawing.Point(423, 247);
            this.btnPendente.Name = "btnPendente";
            this.btnPendente.Size = new System.Drawing.Size(314, 36);
            this.btnPendente.TabIndex = 8;
            this.btnPendente.Text = "Enviar para aprovação";
            this.btnPendente.UseVisualStyleBackColor = false;
            // 
            // dgvCorrigir
            // 
            this.dgvCorrigir.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorrigir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrigir.Location = new System.Drawing.Point(3, 6);
            this.dgvCorrigir.Name = "dgvCorrigir";
            this.dgvCorrigir.Size = new System.Drawing.Size(736, 236);
            this.dgvCorrigir.TabIndex = 0;
            // 
            // tabPendentes
            // 
            this.tabPendentes.BackColor = System.Drawing.Color.Transparent;
            this.tabPendentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPendentes.Controls.Add(this.btnExcluir);
            this.tabPendentes.Controls.Add(this.btnCorrigir);
            this.tabPendentes.Controls.Add(this.dgvRevisao);
            this.tabPendentes.Controls.Add(this.btnAprovar);
            this.tabPendentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPendentes.Location = new System.Drawing.Point(4, 26);
            this.tabPendentes.Name = "tabPendentes";
            this.tabPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendentes.Size = new System.Drawing.Size(743, 289);
            this.tabPendentes.TabIndex = 0;
            this.tabPendentes.Text = "Pendentes";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(6, 245);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 36);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.ExcluirAction);
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCorrigir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrigir.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnCorrigir.ForeColor = System.Drawing.Color.White;
            this.btnCorrigir.Location = new System.Drawing.Point(493, 245);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(118, 36);
            this.btnCorrigir.TabIndex = 6;
            this.btnCorrigir.Text = "Corrigir";
            this.btnCorrigir.UseVisualStyleBackColor = false;
            this.btnCorrigir.Click += new System.EventHandler(this.CorrigirAction);
            // 
            // tabAprovados
            // 
            this.tabAprovados.Controls.Add(this.dataGridView1);
            this.tabAprovados.Location = new System.Drawing.Point(4, 26);
            this.tabAprovados.Name = "tabAprovados";
            this.tabAprovados.Padding = new System.Windows.Forms.Padding(3);
            this.tabAprovados.Size = new System.Drawing.Size(743, 289);
            this.tabAprovados.TabIndex = 1;
            this.tabAprovados.Text = "Aprovados";
            this.tabAprovados.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // Revisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabRevisao);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label1);
            this.Name = "Revisao";
            this.Size = new System.Drawing.Size(806, 658);
            this.Load += new System.EventHandler(this.Revisao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisao)).EndInit();
            this.tabRevisao.ResumeLayout(false);
            this.tabCorrigir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrigir)).EndInit();
            this.tabPendentes.ResumeLayout(false);
            this.tabAprovados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvRevisao;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.TabControl tabRevisao;
        private System.Windows.Forms.TabPage tabPendentes;
        private System.Windows.Forms.TabPage tabAprovados;
        private System.Windows.Forms.TabPage tabCorrigir;
        private System.Windows.Forms.Button btnPendente;
        private System.Windows.Forms.DataGridView dgvCorrigir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
