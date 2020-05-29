namespace Procedimentos
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbProcedimentos = new System.Windows.Forms.GroupBox();
            this.btnExcluirProcedimento = new System.Windows.Forms.Button();
            this.btnInterrogacao = new System.Windows.Forms.Button();
            this.txtNovoPasso = new System.Windows.Forms.TextBox();
            this.txtNomeProcedimento = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.lstboxPassos = new System.Windows.Forms.ListBox();
            this.btnConsultarProcedimento = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lstboxProcedimentos = new System.Windows.Forms.ListBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.gpbProcedimentos.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(39, 42);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 33);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gpbProcedimentos
            // 
            this.gpbProcedimentos.BackColor = System.Drawing.Color.DimGray;
            this.gpbProcedimentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbProcedimentos.Controls.Add(this.btnExcluirProcedimento);
            this.gpbProcedimentos.Controls.Add(this.btnInterrogacao);
            this.gpbProcedimentos.Controls.Add(this.txtNovoPasso);
            this.gpbProcedimentos.Controls.Add(this.txtNomeProcedimento);
            this.gpbProcedimentos.Controls.Add(this.btnMais);
            this.gpbProcedimentos.Controls.Add(this.btnLixeira);
            this.gpbProcedimentos.Controls.Add(this.btnBaixo);
            this.gpbProcedimentos.Controls.Add(this.btnCima);
            this.gpbProcedimentos.Controls.Add(this.btnCancelar);
            this.gpbProcedimentos.Controls.Add(this.btnSalvar);
            this.gpbProcedimentos.Controls.Add(this.btnEditar);
            this.gpbProcedimentos.Controls.Add(this.btnEsquerda);
            this.gpbProcedimentos.Controls.Add(this.lstboxPassos);
            this.gpbProcedimentos.Controls.Add(this.btnConsultarProcedimento);
            this.gpbProcedimentos.Controls.Add(this.lblTitulo);
            this.gpbProcedimentos.Controls.Add(this.txtTitulo);
            this.gpbProcedimentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbProcedimentos.Location = new System.Drawing.Point(95, 112);
            this.gpbProcedimentos.Name = "gpbProcedimentos";
            this.gpbProcedimentos.Size = new System.Drawing.Size(741, 380);
            this.gpbProcedimentos.TabIndex = 5;
            this.gpbProcedimentos.TabStop = false;
            this.gpbProcedimentos.Enter += new System.EventHandler(this.gpbProcedimentos_Enter);
            // 
            // btnExcluirProcedimento
            // 
            this.btnExcluirProcedimento.BackColor = System.Drawing.Color.Black;
            this.btnExcluirProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProcedimento.ForeColor = System.Drawing.Color.White;
            this.btnExcluirProcedimento.Location = new System.Drawing.Point(487, 335);
            this.btnExcluirProcedimento.Name = "btnExcluirProcedimento";
            this.btnExcluirProcedimento.Size = new System.Drawing.Size(174, 32);
            this.btnExcluirProcedimento.TabIndex = 21;
            this.btnExcluirProcedimento.Text = "Excluir Procedimento";
            this.btnExcluirProcedimento.UseVisualStyleBackColor = false;
            this.btnExcluirProcedimento.Visible = false;
            this.btnExcluirProcedimento.Click += new System.EventHandler(this.btnExcluirProcedimento_Click);
            // 
            // btnInterrogacao
            // 
            this.btnInterrogacao.BackgroundImage = global::Procedimentos.Properties.Resources.Interrogacao;
            this.btnInterrogacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInterrogacao.Location = new System.Drawing.Point(23, 189);
            this.btnInterrogacao.Name = "btnInterrogacao";
            this.btnInterrogacao.Size = new System.Drawing.Size(40, 27);
            this.btnInterrogacao.TabIndex = 20;
            this.btnInterrogacao.UseVisualStyleBackColor = true;
            this.btnInterrogacao.Visible = false;
            this.btnInterrogacao.Click += new System.EventHandler(this.btnInterrogacao_Click);
            // 
            // txtNovoPasso
            // 
            this.txtNovoPasso.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoPasso.Location = new System.Drawing.Point(78, 337);
            this.txtNovoPasso.Name = "txtNovoPasso";
            this.txtNovoPasso.Size = new System.Drawing.Size(207, 27);
            this.txtNovoPasso.TabIndex = 19;
            this.txtNovoPasso.Visible = false;
            this.txtNovoPasso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNovoPasso_KeyDown);
            this.txtNovoPasso.Leave += new System.EventHandler(this.txtNovoPasso_Leave);
            // 
            // txtNomeProcedimento
            // 
            this.txtNomeProcedimento.BackColor = System.Drawing.Color.White;
            this.txtNomeProcedimento.Enabled = false;
            this.txtNomeProcedimento.Font = new System.Drawing.Font("Noto Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProcedimento.ForeColor = System.Drawing.Color.Black;
            this.txtNomeProcedimento.Location = new System.Drawing.Point(106, 53);
            this.txtNomeProcedimento.Name = "txtNomeProcedimento";
            this.txtNomeProcedimento.Size = new System.Drawing.Size(536, 33);
            this.txtNomeProcedimento.TabIndex = 18;
            this.txtNomeProcedimento.Text = "Titulo";
            this.txtNomeProcedimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeProcedimento.Visible = false;
            this.txtNomeProcedimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeProcedimento_KeyDown);
            // 
            // btnMais
            // 
            this.btnMais.BackgroundImage = global::Procedimentos.Properties.Resources.Mais;
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMais.Location = new System.Drawing.Point(23, 218);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(40, 27);
            this.btnMais.TabIndex = 16;
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Visible = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLixeira.BackgroundImage")));
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLixeira.Location = new System.Drawing.Point(23, 251);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 27);
            this.btnLixeira.TabIndex = 15;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaixo.BackgroundImage")));
            this.btnBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBaixo.Location = new System.Drawing.Point(23, 161);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(40, 27);
            this.btnBaixo.TabIndex = 14;
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Visible = false;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // btnCima
            // 
            this.btnCima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCima.BackgroundImage")));
            this.btnCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCima.Location = new System.Drawing.Point(23, 128);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(40, 27);
            this.btnCima.TabIndex = 13;
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Visible = false;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(365, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 43);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "x";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Font = new System.Drawing.Font("Bowlby One SC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(309, 331);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 43);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "✓";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(348, 331);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 27);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsquerda.BackgroundImage")));
            this.btnEsquerda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEsquerda.Location = new System.Drawing.Point(23, 101);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(40, 27);
            this.btnEsquerda.TabIndex = 9;
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Visible = false;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // lstboxPassos
            // 
            this.lstboxPassos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPassos.FormattingEnabled = true;
            this.lstboxPassos.ItemHeight = 20;
            this.lstboxPassos.Location = new System.Drawing.Point(77, 101);
            this.lstboxPassos.Name = "lstboxPassos";
            this.lstboxPassos.Size = new System.Drawing.Size(597, 224);
            this.lstboxPassos.TabIndex = 9;
            this.lstboxPassos.Visible = false;
            this.lstboxPassos.DoubleClick += new System.EventHandler(this.lstboxTeste_DoubleClick);
            this.lstboxPassos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstboxTeste_KeyDown);
            // 
            // btnConsultarProcedimento
            // 
            this.btnConsultarProcedimento.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConsultarProcedimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProcedimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProcedimento.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProcedimento.Location = new System.Drawing.Point(453, 48);
            this.btnConsultarProcedimento.Name = "btnConsultarProcedimento";
            this.btnConsultarProcedimento.Size = new System.Drawing.Size(190, 28);
            this.btnConsultarProcedimento.TabIndex = 4;
            this.btnConsultarProcedimento.Text = "Consultar Procedimento";
            this.btnConsultarProcedimento.UseVisualStyleBackColor = false;
            this.btnConsultarProcedimento.Click += new System.EventHandler(this.btnConsultarProcedimento_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Gray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblTitulo.Size = new System.Drawing.Size(100, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(156, 48);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(258, 26);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitulo_KeyDown_1);
            // 
            // lstboxProcedimentos
            // 
            this.lstboxProcedimentos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxProcedimentos.FormattingEnabled = true;
            this.lstboxProcedimentos.ItemHeight = 20;
            this.lstboxProcedimentos.Location = new System.Drawing.Point(173, 213);
            this.lstboxProcedimentos.Name = "lstboxProcedimentos";
            this.lstboxProcedimentos.Size = new System.Drawing.Size(597, 224);
            this.lstboxProcedimentos.TabIndex = 8;
            this.lstboxProcedimentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstboxProcedimentos_KeyDown);
            this.lstboxProcedimentos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxProcedimentos_MouseDoubleClick);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Location = new System.Drawing.Point(856, 480);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(65, 33);
            this.panelLogo.TabIndex = 9;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Kalam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(9, 6);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(43, 25);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "Logo";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Procedimentos.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.lstboxProcedimentos);
            this.Controls.Add(this.gpbProcedimentos);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultar_FormClosing);
            this.gpbProcedimentos.ResumeLayout(false);
            this.gpbProcedimentos.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbProcedimentos;
        private System.Windows.Forms.Button btnConsultarProcedimento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ListBox lstboxProcedimentos;
        private System.Windows.Forms.ListBox lstboxPassos;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.TextBox txtNomeProcedimento;
        private System.Windows.Forms.TextBox txtNovoPasso;
        private System.Windows.Forms.Button btnInterrogacao;
        private System.Windows.Forms.Button btnExcluirProcedimento;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
    }
}