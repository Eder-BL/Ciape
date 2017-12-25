namespace Ciape {
    partial class Form1 {
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnIndicador = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnRevisao = new System.Windows.Forms.Button();
            this.btnUrgente = new System.Windows.Forms.Button();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.btnPainel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnPainel = new Ciape.Painel();
            this.pnEnvios = new Ciape.Envios();
            this.pnUrgente = new Ciape.Urgente();
            this.pnRevisao = new Ciape.Revisao();
            this.pnSobre = new Ciape.Sobre();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 12);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.pnIndicador);
            this.panel2.Controls.Add(this.btnSobre);
            this.panel2.Controls.Add(this.btnRevisao);
            this.panel2.Controls.Add(this.btnUrgente);
            this.panel2.Controls.Add(this.btnEnvios);
            this.panel2.Controls.Add(this.btnPainel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 675);
            this.panel2.TabIndex = 0;
            // 
            // pnIndicador
            // 
            this.pnIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.pnIndicador.Location = new System.Drawing.Point(14, 37);
            this.pnIndicador.Name = "pnIndicador";
            this.pnIndicador.Size = new System.Drawing.Size(6, 58);
            this.pnIndicador.TabIndex = 6;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(22, 549);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(156, 58);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnRevisao
            // 
            this.btnRevisao.FlatAppearance.BorderSize = 0;
            this.btnRevisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisao.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnRevisao.ForeColor = System.Drawing.Color.White;
            this.btnRevisao.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisao.Image")));
            this.btnRevisao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevisao.Location = new System.Drawing.Point(22, 421);
            this.btnRevisao.Name = "btnRevisao";
            this.btnRevisao.Size = new System.Drawing.Size(156, 58);
            this.btnRevisao.TabIndex = 3;
            this.btnRevisao.Text = "Revisão";
            this.btnRevisao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevisao.UseVisualStyleBackColor = true;
            this.btnRevisao.Click += new System.EventHandler(this.btnRevisao_Click);
            // 
            // btnUrgente
            // 
            this.btnUrgente.FlatAppearance.BorderSize = 0;
            this.btnUrgente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgente.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnUrgente.ForeColor = System.Drawing.Color.White;
            this.btnUrgente.Image = ((System.Drawing.Image)(resources.GetObject("btnUrgente.Image")));
            this.btnUrgente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrgente.Location = new System.Drawing.Point(22, 165);
            this.btnUrgente.Name = "btnUrgente";
            this.btnUrgente.Size = new System.Drawing.Size(156, 58);
            this.btnUrgente.TabIndex = 2;
            this.btnUrgente.Text = "Urgente";
            this.btnUrgente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrgente.UseVisualStyleBackColor = true;
            this.btnUrgente.Click += new System.EventHandler(this.btnUrgente_Click);
            // 
            // btnEnvios
            // 
            this.btnEnvios.FlatAppearance.BorderSize = 0;
            this.btnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvios.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnEnvios.ForeColor = System.Drawing.Color.White;
            this.btnEnvios.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvios.Image")));
            this.btnEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvios.Location = new System.Drawing.Point(22, 293);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(156, 58);
            this.btnEnvios.TabIndex = 1;
            this.btnEnvios.Text = "Envios";
            this.btnEnvios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnvios.UseVisualStyleBackColor = true;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // btnPainel
            // 
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Image = ((System.Drawing.Image)(resources.GetObject("btnPainel.Image")));
            this.btnPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.Location = new System.Drawing.Point(22, 37);
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Size = new System.Drawing.Size(156, 58);
            this.btnPainel.TabIndex = 0;
            this.btnPainel.Text = "Painel";
            this.btnPainel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPainel.UseVisualStyleBackColor = true;
            this.btnPainel.Click += new System.EventHandler(this.btnPainel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(996, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 31);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnPainel
            // 
            this.pnPainel.BackColor = System.Drawing.Color.White;
            this.pnPainel.Location = new System.Drawing.Point(207, 26);
            this.pnPainel.Name = "pnPainel";
            this.pnPainel.Size = new System.Drawing.Size(806, 658);
            this.pnPainel.TabIndex = 3;
            this.pnPainel.Load += new System.EventHandler(this.painel1_Load);
            // 
            // pnEnvios
            // 
            this.pnEnvios.BackColor = System.Drawing.Color.White;
            this.pnEnvios.Location = new System.Drawing.Point(219, 144);
            this.pnEnvios.Name = "pnEnvios";
            this.pnEnvios.Size = new System.Drawing.Size(806, 540);
            this.pnEnvios.TabIndex = 7;
            // 
            // pnUrgente
            // 
            this.pnUrgente.BackColor = System.Drawing.Color.White;
            this.pnUrgente.Location = new System.Drawing.Point(219, 144);
            this.pnUrgente.Name = "pnUrgente";
            this.pnUrgente.Size = new System.Drawing.Size(806, 540);
            this.pnUrgente.TabIndex = 6;
            // 
            // pnRevisao
            // 
            this.pnRevisao.BackColor = System.Drawing.Color.White;
            this.pnRevisao.Location = new System.Drawing.Point(219, 144);
            this.pnRevisao.Name = "pnRevisao";
            this.pnRevisao.Size = new System.Drawing.Size(806, 540);
            this.pnRevisao.TabIndex = 4;
            // 
            // pnSobre
            // 
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Location = new System.Drawing.Point(216, 144);
            this.pnSobre.Name = "pnSobre";
            this.pnSobre.Size = new System.Drawing.Size(809, 540);
            this.pnSobre.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnPainel);
            this.Controls.Add(this.pnEnvios);
            this.Controls.Add(this.pnUrgente);
            this.Controls.Add(this.pnRevisao);
            this.Controls.Add(this.pnSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRevisao;
        private System.Windows.Forms.Button btnUrgente;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Button btnPainel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSobre;
        private Painel pnPainel;
        private Revisao pnRevisao;
        private Sobre pnSobre;
        private System.Windows.Forms.Panel pnIndicador;
        private Urgente pnUrgente;
        private Envios pnEnvios;
    }
}

