using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciape.Modelo;
using System.ComponentModel.DataAnnotations;
using Ciape.Banco;


namespace Ciape {
    public partial class CorrigirOQ : Form  {
        public CorrigirOQ() {
            InitializeComponent();
        }

        private void btnCorrige_Click(object sender, EventArgs e) {

            try {
                string lbl = lblID.Text;
                int id = Convert.ToInt32(lbl);
                string correcao = txtCorrecoes.Text.Trim();
                Banco.RevisaoDataAccess.CorrigirRevisao(id, correcao);

            }
            catch {
                MessageBox.Show("Erro no envio das informações!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void CorrigirOQ_Load(object sender, EventArgs e) {

        }
    }
}
