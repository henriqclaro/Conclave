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
    public partial class FrmGerenciar : Form
    {
        Form1 anterior;
        string[][] papaveis;
        public FrmGerenciar(Form1 anterior, string[][] papaveis)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.papaveis = papaveis;
            Atualizar();
        }

        private void FrmGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPapaveis(papaveis);
            anterior.Show();
        }

        int Lenght(string[][] vet)
        {
            int q = 0;
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] != null)
                    q++;
            }

            return q;
        }

        int Buscar(string nome)
        {
            int indice = 0;
            for (indice = 0; indice < Lenght(papaveis) && papaveis[indice][1] != nome; indice++) ;
            
            if (indice < Lenght(papaveis))
                return indice;
            return -1;
        }

        void Atualizar()
        {
            for (int i = 0; i < Lenght(papaveis); i++)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvPapaveis);
                for (int j = 0; j < papaveis[i].Length; j++)
                    linha.Cells[j].Value = papaveis[i][j];
                dgvPapaveis.Rows.Add(linha);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Lenght(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Lista cheia.");
                return;
            }

            string nome = txtNome.Text.Trim();
            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Indique um nome.");
                return;
            }

            if (Buscar(nome) > -1)
            {
                MessageBox.Show("Nome já cadastrado.");
                return;
            }

            int id = 1;
            if (Lenght(papaveis) > 0)
                id = int.Parse(papaveis[Lenght(papaveis) - 1][0]) + 1;

            papaveis[Lenght(papaveis)] = new string[] { id.ToString(), nome };
            MessageBox.Show("Adicionado.");
            Atualizar();
        }
    }
}
