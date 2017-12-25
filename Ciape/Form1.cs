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

        //=========Indicador Laranja do MENU============//
        private void MoverIndicador(Button btnMenu) {
            pnIndicador.Location = new Point(pnIndicador.Location.X, btnMenu.Location.Y);
        }

        //=========Painel visível============//
        private void painelVisivel(UserControl pn) {
            pnRevisao.Visible = false;
            pnSobre.Visible = false;
            pnPainel.Visible = false;
            pnUrgente.Visible = false;
            pnEnvios.Visible = false;

            pn.Visible = true;

        }

        //=========MOVER O PROGRAMA PELA BARRA SUPERIOR============//
        private bool BotaoMousePressionado = false;
        private Point PontoInicialFormulario;
        private Point PontoInicialCursor;

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            BotaoMousePressionado = true;
            PontoInicialFormulario = this.Location;
            PontoInicialCursor = Cursor.Position;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e) {
            BotaoMousePressionado = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if(BotaoMousePressionado == true) {
                Point dif = Point.Subtract(Cursor.Position, new Size(PontoInicialCursor));
                this.Location = Point.Add(PontoInicialFormulario, new Size(dif));
            }
        }

    }
}
