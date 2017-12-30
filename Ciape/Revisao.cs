using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciape.Modelo;
using System.ComponentModel.DataAnnotations;
using Ciape.Banco;

namespace Ciape {
    public partial class Revisao : UserControl {

        public Revisao() {
            InitializeComponent();

            //---Tirar Gerador automatico de colunas para escolher tamanhos--//
            dgvCorrigir.AutoGenerateColumns = false;
            dgvRevisao.AutoGenerateColumns = false;
            dgvAprovado.AutoGenerateColumns = false;
            //---------------------------------------------------------------//

            AtualizarTabela();
        }

        public void AtualizarTabela() {
            dgvRevisao.DataSource = Banco.RevisaoDataAccess.PegarRevisoes();
            dgvCorrigir.DataSource = Banco.RevisaoDataAccess.PegarCorrecoes();
            dgvAprovado.DataSource = Banco.RevisaoDataAccess.PegarAprovados();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void Revisao_Load(object sender, EventArgs e) {

        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            //Mover
            Revisoes revisao = new Revisoes();
            revisao.Descricao = txtDescricao.Text.Trim();
            revisao.Link = txtLink.Text.Trim();
            revisao.Status = "Pendente";
            revisao.DataCadastro = DateTime.Now;

            //Validar
            List<ValidationResult> listErros = new List<ValidationResult>();
            ValidationContext contexto = new ValidationContext(revisao);
            bool validado = Validator.TryValidateObject(revisao, contexto, listErros, true);
            if (validado) {
                //Validação ok
                //Salvar os dados
                //Fechar e atualizar tela
                if (RevisaoDataAccess.SalvarLink(revisao)) {

                    txtDescricao.Text = "Descrição"; txtDescricao.ForeColor = Color.Silver;
                    txtLink.Text = "Link"; txtLink.ForeColor = Color.Silver;

                    AtualizarTabela();
                }
                else {
                    lblErros.Text = "Erro na insersão - Banco!";
                }
            }
            else {
                //erro na validação
                StringBuilder sb = new StringBuilder();
                foreach (ValidationResult erro in listErros) {
                    sb.Append(erro.ErrorMessage + "\n");
                }
                lblErros.Text = sb.ToString();
            }
        }

        private void CorrigirAction(object sender, EventArgs e) {

            CorrigirOQ corr = new CorrigirOQ();
            corr.lblID.Text = this.dgvRevisao.CurrentRow.Cells[0].Value.ToString();
            corr.ShowDialog();
            AtualizarTabela();

        }

        private void btnAprovar_Click(object sender, EventArgs e) {
            int id = (int)dgvRevisao.SelectedRows[0].Cells[0].Value;
            Banco.RevisaoDataAccess.AprovadoRev(id);
            AtualizarTabela();
        }

        private void ExcluirAction(object sender, EventArgs e) {

            int id = (int)dgvRevisao.SelectedRows[0].Cells[0].Value;
            Banco.RevisaoDataAccess.ExcluirRevisao(id);
            AtualizarTabela();

        }

        //===================TEXTBOX DE SALVAR LINK=====================//

        private void txtDescricao_Enter(object sender, EventArgs e) {
            if (txtDescricao.Text == "Descrição") {
                txtDescricao.Text = "";
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e) {
            if (txtDescricao.Text == "") {
                txtDescricao.Text = "Descrição";
                txtDescricao.ForeColor = Color.Silver;
            }
        }

        private void txtLink_Enter(object sender, EventArgs e) {
            if (txtLink.Text == "Link") {
                txtLink.Text = "";
                txtLink.ForeColor = Color.Black;
            }
        }

        private void txtLink_Leave(object sender, EventArgs e) {
            if (txtLink.Text == "") {
                txtLink.Text = "Link";
                txtLink.ForeColor = Color.Silver;
            }
        }
        //===================TAB CORRIGIR BOTAO ENVIAR PARA APROVAÇÃO=====================//

        private void btnPendente_Click(object sender, EventArgs e) {
            try {
                int id = (int)dgvCorrigir.SelectedRows[0].Cells[0].Value;
                Banco.RevisaoDataAccess.CorrigidoRev(id);
                AtualizarTabela();

            }
            catch {
                MessageBox.Show("Erro no envio das informações!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //===================PEGAR DADOS DO DGV PARA CORRIGIR=====================//
        private void dgvRevisao_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvAprovado_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }


        private void btnATT_Click(object sender, EventArgs e) {
            AtualizarTabela();
        }

        private void dgvCorrigir_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        //===================DUPLO CLIQUE NA LINHA DA TAB CORRIGIR=====================//
        private void dgvCorrigir_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            pegaCorrecao pec = new pegaCorrecao();
            pec.txtPegaCorr.Text = this.dgvCorrigir.CurrentRow.Cells[3].Value.ToString().Trim();
            pec.ShowDialog();
            AtualizarTabela();

        }

        private void dgvRevisao_DoubleClick(object sender, EventArgs e) {

            pegaCorrecao pec = new pegaCorrecao();
            pec.txtPegaCorr.Text = this.dgvRevisao.CurrentRow.Cells[3].Value.ToString().Trim();
            pec.ShowDialog();
            AtualizarTabela();

        }

        private void tabRevisao_SelectedIndexChanged(object sender, EventArgs e) {

        }

    }
}
