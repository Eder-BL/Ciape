using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciape.Banco;


namespace Ciape {
    public partial class CorrigirOQ : Form {
        public CorrigirOQ() {
            InitializeComponent();
        }

        private void btnCorrige_Click(object sender, EventArgs e) {
         //   try {
         //       int id = (int)RevisaoDataAccess.dgvRevisao.SelectedRows[0].Cells[0].Value;
         //      Banco.RevisaoDataAccess.CorrigirRevisao(id);
         //      Revisao.AtualizarTabela();
          //  }
         //   catch {
          //      MessageBox.Show("Não há nada para corrigir nessa linha", "Erro - Sem ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
        }
    }
}
