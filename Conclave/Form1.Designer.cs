﻿namespace Conclave
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Location = new System.Drawing.Point(26, 26);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(188, 85);
            this.btnGerenciar.TabIndex = 0;
            this.btnGerenciar.Text = "&Gerenciar Papáveis";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.Location = new System.Drawing.Point(26, 142);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(188, 85);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "&Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(26, 256);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(188, 85);
            this.btnResultados.TabIndex = 2;
            this.btnResultados.Text = "&Resultados";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(244, 373);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.btnGerenciar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conclave";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnResultados;
    }
}

