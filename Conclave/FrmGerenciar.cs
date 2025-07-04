﻿using System;
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

        void Atualizar()
        {
            dgvPapaveis.Rows.Clear();
            for (int i = 0; i < Functions.Lenght(papaveis); i++)
            {
                DataGridViewRow linha = new DataGridViewRow();
                linha.CreateCells(dgvPapaveis);
                linha.Cells[0].Value = papaveis[i][0];
                dgvPapaveis.Rows.Add(linha);
            }
            txtNome.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Functions.Lenght(papaveis) == papaveis.Length)
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

            if (Functions.Buscar(papaveis, nome) > -1)
            {
                MessageBox.Show("Nome já cadastrado.");
                return;
            }

            papaveis[Functions.Lenght(papaveis)] = new string[] { nome, "0"};

            Atualizar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPapaveis.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um papável para excluir.");
                return;
            }

            string nome = dgvPapaveis.SelectedCells[0].Value.ToString();
            int indice = Functions.Buscar(papaveis, nome);

            DialogResult r = MessageBox.Show($"Tem certeza que deseja excluir {papaveis[indice][0]}?", "Confirmação", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                for (int i = indice; i < Functions.Lenght(papaveis) - 1; i++)
                {
                    papaveis[i] = papaveis[i + 1];
                }
                papaveis[Functions.Lenght(papaveis) - 1] = null;
                
                Atualizar();
            }
        }
    }
}
