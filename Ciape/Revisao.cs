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
                foreach(ValidationResult erro in listErros) {
                    sb.Append(erro.ErrorMessage + "\n");
                }
                lblErros.Text = sb.ToString();
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e) {

        }
    }
}
