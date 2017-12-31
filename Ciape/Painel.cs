using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ciape.Banco;
using Ciape.Modelo;


namespace Ciape {
    public partial class Painel : UserControl {
        public Painel() {
            InitializeComponent();
            AtualizarDash();
        }

        public void AtualizarDash() {
            lblTotalRevisao.Text = RevisaoDataAccess.RevCountTotal().Rows[0][0].ToString();
            lblLinksCorrigir.Text = RevisaoDataAccess.RevCountCorrigir().Rows[0][0].ToString();
            lblLinksPendentes.Text = RevisaoDataAccess.RevCountPendentes().Rows[0][0].ToString();
            graficoVelocimetro();
        }

        public void graficoVelocimetro() {
            double corrigidos = Convert.ToDouble(RevisaoDataAccess.RevCountLinksCorrigidos().Rows[0][0].ToString());
            double aprovados = Convert.ToDouble(RevisaoDataAccess.RevCountLinksSemCorrecao().Rows[0][0].ToString());
            double resultado = (corrigidos / (corrigidos + aprovados)) * 100;
            estatLinksErro.Value = (int)resultado;
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }

        private void label15_Click(object sender, EventArgs e) {

        }

        private void lblEmPreparacao_Click(object sender, EventArgs e) {
        }

        private void lblPendencias_Click(object sender, EventArgs e) {

        }

        private void label13_Click(object sender, EventArgs e) {

        }

        private void estatLinksErro_Load(object sender, EventArgs e) {
            graficoVelocimetro();
        }
    }
}
