namespace Ciape {
    partial class CorrigirOQ {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCorrige = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorrecoes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.White;
            this.btnCorrige.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrige.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrige.ForeColor = System.Drawing.Color.Black;
            this.btnCorrige.Location = new System.Drawing.Point(12, 226);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(356, 41);
            this.btnCorrige.TabIndex = 0;
            this.btnCorrige.Text = "Enviar para corrigir!";
            this.btnCorrige.UseVisualStyleBackColor = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "O que é preciso corrigir?";
            // 
            // txtCorrecoes
            // 
            this.txtCorrecoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrecoes.Location = new System.Drawing.Point(12, 33);
            this.txtCorrecoes.Multiline = true;
            this.txtCorrecoes.Name = "txtCorrecoes";
            this.txtCorrecoes.Size = new System.Drawing.Size(356, 187);
            this.txtCorrecoes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblID.Location = new System.Drawing.Point(304, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 16);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(354, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 31);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // CorrigirOQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(380, 279);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorrecoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCorrige);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CorrigirOQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Corrigir";
            this.Load += new System.EventHandler(this.CorrigirOQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorrecoes;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnFechar;
    }
}