using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conclave
{
    public partial class Form1 : Form
    {
        string[][] papaveis;
        public Form1()
        {
            InitializeComponent();
            papaveis = new string[300][];
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            FrmGerenciar f = new FrmGerenciar(this, papaveis);
            f.Show();
            this.Hide();
        }

        public void AtribuirPapaveis(string[][] papaveis)
        {
            this.papaveis = papaveis;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, papaveis);
            f.ShowDialog();
        }

        void ZerarVotos()
        {
            for (int i = 0; i < Functions.Lenght(papaveis); i++)
            {
                papaveis[i][1] = "0";
            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            DialogResult encerrar = MessageBox.Show("Deseja encerrar a votação?", "Resultados", MessageBoxButtons.YesNo);
            if (encerrar == DialogResult.No)
                return;

            int votosTotais = 0;
            
            for (int i = 0; i < Functions.Lenght(papaveis); i++)
            {
                votosTotais += int.Parse(papaveis[i][1]);
            }

            int indice;
            bool vencedor = false;
            for (indice = 0; indice < Functions.Lenght(papaveis); indice++)
            {
                if (int.Parse(papaveis[indice][1]) >= ((double)2/3) * votosTotais)
                {
                    vencedor = true;
                    break;
                }
            }

            if (!vencedor || votosTotais == 0)
            {
                MessageBox.Show("Nenhum cardeal obteve votos suficientes para ser eleito.");
                ZerarVotos();
                return;
            }

            DialogResult aceitar = MessageBox.Show(
                $"O cardeal vitorioso foi {papaveis[indice][0]} com {papaveis[indice][1]} voto(s).\n\nVocê aceita a eleição canônica à Sumo Pontífice?",
                "Resultados",
                MessageBoxButtons.YesNo);

            if (aceitar == DialogResult.No)
            {
                ZerarVotos();
                return;
            }

            MessageBox.Show($"HABEMUS PAPAM");
            Array.Clear(papaveis, 0, papaveis.Length);
        }
    }
}