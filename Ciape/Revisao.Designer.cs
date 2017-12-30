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
            this.dgvAprovado = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLink = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corrigir1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAtualização = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corrigir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevisao)).BeginInit();
            this.tabRevisao.SuspendLayout();
            this.tabCorrigir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorrigir)).BeginInit();
            this.tabPendentes.SuspendLayout();
            this.tabAprovados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 32F);
            this.label1.Location = new System.Drawing.Point(20, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revisão";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(652, 152);
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
            this.dgvRevisao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevisao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevisao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id1,
            this.Descricao1,
            this.Link1,
            this.Corrigir1,
            this.DataCadastro1});
            this.dgvRevisao.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRevisao.Location = new System.Drawing.Point(3, 3);
            this.dgvRevisao.Name = "dgvRevisao";
            this.dgvRevisao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevisao.Size = new System.Drawing.Size(738, 285);
            this.dgvRevisao.TabIndex = 4;
            this.dgvRevisao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevisao_CellContentClick);
            this.dgvRevisao.DoubleClick += new System.EventHandler(this.dgvRevisao_DoubleClick);
            // 
            // btnAprovar
            // 
            this.btnAprovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnAprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprovar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.ForeColor = System.Drawing.Color.White;
            this.btnAprovar.Location = new System.Drawing.Point(619, 294);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(118, 36);
            this.btnAprovar.TabIndex = 5;
            this.btnAprovar.Text = "Aprovar";
            this.btnAprovar.UseVisualStyleBackColor = false;
            this.btnAprovar.Click += new System.EventHandler(this.btnAprovar_Click);
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblErros.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblErros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.lblErros.Location = new System.Drawing.Point(33, 165);
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
            this.tabRevisao.Location = new System.Drawing.Point(29, 278);
            this.tabRevisao.Margin = new System.Windows.Forms.Padding(0);
            this.tabRevisao.Name = "tabRevisao";
            this.tabRevisao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabRevisao.SelectedIndex = 0;
            this.tabRevisao.Size = new System.Drawing.Size(751, 366);
            this.tabRevisao.TabIndex = 7;
            this.tabRevisao.SelectedIndexChanged += new System.EventHandler(this.tabRevisao_SelectedIndexChanged);
            // 
            // tabCorrigir
            // 
            this.tabCorrigir.BackColor = System.Drawing.Color.White;
            this.tabCorrigir.Controls.Add(this.btnPendente);
            this.tabCorrigir.Controls.Add(this.dgvCorrigir);
            this.tabCorrigir.ForeColor = System.Drawing.Color.Black;
            this.tabCorrigir.Location = new System.Drawing.Point(4, 26);
            this.tabCorrigir.Name = "tabCorrigir";
            this.tabCorrigir.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorrigir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCorrigir.Size = new System.Drawing.Size(743, 336);
            this.tabCorrigir.TabIndex = 2;
            this.tabCorrigir.Text = "Corrigir";
            // 
            // btnPendente
            // 
            this.btnPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnPendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendente.ForeColor = System.Drawing.Color.White;
            this.btnPendente.Location = new System.Drawing.Point(423, 294);
            this.btnPendente.Name = "btnPendente";
            this.btnPendente.Size = new System.Drawing.Size(314, 36);
            this.btnPendente.TabIndex = 8;
            this.btnPendente.Text = "Enviar para aprovação";
            this.btnPendente.UseVisualStyleBackColor = false;
            this.btnPendente.Click += new System.EventHandler(this.btnPendente_Click);
            // 
            // dgvCorrigir
            // 
            this.dgvCorrigir.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorrigir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCorrigir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorrigir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Link,
            this.Corrigir,
            this.DataCadastro});
            this.dgvCorrigir.Location = new System.Drawing.Point(3, 3);
            this.dgvCorrigir.Name = "dgvCorrigir";
            this.dgvCorrigir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCorrigir.Size = new System.Drawing.Size(736, 285);
            this.dgvCorrigir.TabIndex = 0;
            this.dgvCorrigir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorrigir_CellContentClick);
            this.dgvCorrigir.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorrigir_CellDoubleClick);
            // 
            // tabPendentes
            // 
            this.tabPendentes.BackColor = System.Drawing.Color.White;
            this.tabPendentes.Controls.Add(this.btnExcluir);
            this.tabPendentes.Controls.Add(this.btnCorrigir);
            this.tabPendentes.Controls.Add(this.dgvRevisao);
            this.tabPendentes.Controls.Add(this.btnAprovar);
            this.tabPendentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPendentes.Location = new System.Drawing.Point(4, 26);
            this.tabPendentes.Name = "tabPendentes";
            this.tabPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPendentes.Size = new System.Drawing.Size(743, 336);
            this.tabPendentes.TabIndex = 0;
            this.tabPendentes.Text = "Pendentes";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(8, 294);
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
            this.btnCorrigir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrigir.ForeColor = System.Drawing.Color.White;
            this.btnCorrigir.Location = new System.Drawing.Point(495, 294);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(118, 36);
            this.btnCorrigir.TabIndex = 6;
            this.btnCorrigir.Text = "Corrigir";
            this.btnCorrigir.UseVisualStyleBackColor = false;
            this.btnCorrigir.Click += new System.EventHandler(this.CorrigirAction);
            // 
            // tabAprovados
            // 
            this.tabAprovados.BackColor = System.Drawing.Color.White;
            this.tabAprovados.Controls.Add(this.dgvAprovado);
            this.tabAprovados.Location = new System.Drawing.Point(4, 26);
            this.tabAprovados.Name = "tabAprovados";
            this.tabAprovados.Padding = new System.Windows.Forms.Padding(3);
            this.tabAprovados.Size = new System.Drawing.Size(743, 336);
            this.tabAprovados.TabIndex = 1;
            this.tabAprovados.Text = "Aprovados";
            // 
            // dgvAprovado
            // 
            this.dgvAprovado.AllowUserToOrderColumns = true;
            this.dgvAprovado.BackgroundColor = System.Drawing.Color.White;
            this.dgvAprovado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAprovado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAprovado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao2,
            this.Link2,
            this.DataCadastro2,
            this.DataAtualização});
            this.dgvAprovado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAprovado.Location = new System.Drawing.Point(3, 3);
            this.dgvAprovado.Name = "dgvAprovado";
            this.dgvAprovado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAprovado.Size = new System.Drawing.Size(737, 330);
            this.dgvAprovado.TabIndex = 1;
            this.dgvAprovado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAprovado_CellContentClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Silver;
            this.txtDescricao.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescricao.HintText = "";
            this.txtDescricao.isPassword = false;
            this.txtDescricao.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.txtDescricao.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescricao.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.txtDescricao.LineThickness = 4;
            this.txtDescricao.Location = new System.Drawing.Point(391, 36);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(379, 36);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.Text = "Descrição";
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // txtLink
            // 
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLink.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.ForeColor = System.Drawing.Color.Silver;
            this.txtLink.HintForeColor = System.Drawing.Color.Empty;
            this.txtLink.HintText = "";
            this.txtLink.isPassword = false;
            this.txtLink.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.txtLink.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLink.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.txtLink.LineThickness = 4;
            this.txtLink.Location = new System.Drawing.Point(391, 94);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(379, 36);
            this.txtLink.TabIndex = 9;
            this.txtLink.Text = "Link";
            this.txtLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLink.Enter += new System.EventHandler(this.txtLink_Enter);
            this.txtLink.Leave += new System.EventHandler(this.txtLink_Leave);
            // 
            // Id1
            // 
            this.Id1.DataPropertyName = "Id";
            this.Id1.HeaderText = "Id";
            this.Id1.Name = "Id1";
            this.Id1.Visible = false;
            // 
            // Descricao1
            // 
            this.Descricao1.DataPropertyName = "Descrição";
            this.Descricao1.HeaderText = "Descrição";
            this.Descricao1.Name = "Descricao1";
            this.Descricao1.Width = 250;
            // 
            // Link1
            // 
            this.Link1.DataPropertyName = "Link";
            this.Link1.HeaderText = "Link";
            this.Link1.Name = "Link1";
            this.Link1.Width = 310;
            // 
            // Corrigir1
            // 
            this.Corrigir1.DataPropertyName = "Corrigir";
            this.Corrigir1.HeaderText = "Corrigir";
            this.Corrigir1.Name = "Corrigir1";
            this.Corrigir1.Visible = false;
            this.Corrigir1.Width = 150;
            // 
            // DataCadastro1
            // 
            this.DataCadastro1.DataPropertyName = "Cadastro";
            this.DataCadastro1.HeaderText = "Cadastro";
            this.DataCadastro1.Name = "DataCadastro1";
            this.DataCadastro1.Width = 120;
            // 
            // Descricao2
            // 
            this.Descricao2.DataPropertyName = "Descrição";
            this.Descricao2.HeaderText = "Descrição";
            this.Descricao2.Name = "Descricao2";
            this.Descricao2.Width = 190;
            // 
            // Link2
            // 
            this.Link2.DataPropertyName = "Link";
            this.Link2.HeaderText = "Link";
            this.Link2.Name = "Link2";
            this.Link2.Width = 250;
            // 
            // DataCadastro2
            // 
            this.DataCadastro2.DataPropertyName = "Cadastro";
            this.DataCadastro2.HeaderText = "Cadastro";
            this.DataCadastro2.Name = "DataCadastro2";
            this.DataCadastro2.Width = 120;
            // 
            // DataAtualização
            // 
            this.DataAtualização.DataPropertyName = "Atualização";
            this.DataAtualização.HeaderText = "Aprovação";
            this.DataAtualização.Name = "DataAtualização";
            this.DataAtualização.Width = 120;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 30;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descrição";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 190;
            // 
            // Link
            // 
            this.Link.DataPropertyName = "Link";
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 250;
            // 
            // Corrigir
            // 
            this.Corrigir.DataPropertyName = "Corrigir";
            this.Corrigir.HeaderText = "Corrigir";
            this.Corrigir.Name = "Corrigir";
            this.Corrigir.Width = 120;
            // 
            // DataCadastro
            // 
            this.DataCadastro.DataPropertyName = "Cadastro";
            this.DataCadastro.HeaderText = "Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Width = 120;
            // 
            // Revisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.tabRevisao);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.btnSalvar);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAprovado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvRevisao;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.TabPage tabPendentes;
        private System.Windows.Forms.TabPage tabAprovados;
        private System.Windows.Forms.Button btnPendente;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.DataGridView dgvAprovado;
        public System.Windows.Forms.TabControl tabRevisao;
        public System.Windows.Forms.TabPage tabCorrigir;
        public System.Windows.Forms.DataGridView dgvCorrigir;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescricao;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corrigir1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAtualização;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corrigir;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
    }
}
