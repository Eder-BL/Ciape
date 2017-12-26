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
            AtualizarTabela();
        }

        public void AtualizarTabela() {
            dgvRevisao.DataSource = Banco.RevisaoDataAccess.PegarRevisoes();
            dgvCorrigir.DataSource = Banco.RevisaoDataAccess.PegarCorrecoes();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void Revisao_Load(object sender, EventArgs e) {

        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            //Mover
            Revisoes revisao = new Revisoes();
            revisao.Descricao = txtDescricao.Text;
            revisao.Link = txtLink.Text;
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

        }


        private void ExcluirAction(object sender, EventArgs e) {

            int id = (int)dgvRevisao.SelectedRows[0].Cells[0].Value;
            Banco.RevisaoDataAccess.ExcluirRevisao(id);
            AtualizarTabela();

        }

        private void txtDescricao_Enter(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "Descrição") {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "") {
                campo.Text = "Descrição";
                campo.ForeColor = Color.Silver;
            }
        }

        private void txtLink_Enter(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "Link") {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
        }

        private void txtLink_Leave(object sender, EventArgs e) {
            var campo = (TextBox)sender;
            if (campo.Text == "") {
                campo.Text = "Link";
                campo.ForeColor = Color.Silver;
            }
        }


    //===================PEGAR DADOS DO DGV PARA CORRIGIR=====================//
        private void dgvRevisao_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      
        }
    }
}
