using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciape {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            painelVisivel(pnPainel);
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void painel1_Load(object sender, EventArgs e) {

        }

        private void btnEnvios_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            painelVisivel(pnEnvios);
        }

        private void btnUrgente_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            painelVisivel(pnUrgente);
        }

        private void btnRevisao_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            painelVisivel(pnRevisao);
        }

        private void btnSobre_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            painelVisivel(pnSobre);
        }

        private void btnPainel_Click(object sender, EventArgs e) {
            MoverIndicador((Button)sender);
            painelVisivel(pnPainel);
        }

        private void MoverIndicador(Button btnMenu) {
            pnIndicador.Location = new Point(pnIndicador.Location.X, btnMenu.Location.Y);
        }

        private void painelVisivel(UserControl pn) {
            pnRevisao.Visible = false;
            pnSobre.Visible = false;
            pnPainel.Visible = false;
            pnUrgente.Visible = false;
            pnEnvios.Visible = false;

            pn.Visible = true;

        }
    }
}
