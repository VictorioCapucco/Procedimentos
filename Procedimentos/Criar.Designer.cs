namespace Procedimentos
{
    partial class Criar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionarPasso = new System.Windows.Forms.Button();
            this.lblPasso = new System.Windows.Forms.Label();
            this.txtPasso = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTituLo = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPassos = new System.Windows.Forms.Label();
            this.lstboxPassos = new System.Windows.Forms.ListBox();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnLixeira = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAdicionarPasso);
            this.groupBox1.Controls.Add(this.lblPasso);
            this.groupBox1.Controls.Add(this.txtPasso);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.txtTituLo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(33, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(252, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(174, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(55, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(174, 32);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdicionarPasso
            // 
            this.btnAdicionarPasso.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionarPasso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPasso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPasso.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarPasso.Location = new System.Drawing.Point(172, 161);
            this.btnAdicionarPasso.Name = "btnAdicionarPasso";
            this.btnAdicionarPasso.Size = new System.Drawing.Size(138, 30);
            this.btnAdicionarPasso.TabIndex = 4;
            this.btnAdicionarPasso.Text = "Adicionar Passo";
            this.btnAdicionarPasso.UseVisualStyleBackColor = false;
            this.btnAdicionarPasso.Click += new System.EventHandler(this.btnAdicionarPasso_Click);
            // 
            // lblPasso
            // 
            this.lblPasso.AutoSize = true;
            this.lblPasso.BackColor = System.Drawing.Color.Gray;
            this.lblPasso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasso.ForeColor = System.Drawing.Color.White;
            this.lblPasso.Location = new System.Drawing.Point(40, 111);
            this.lblPasso.Name = "lblPasso";
            this.lblPasso.Size = new System.Drawing.Size(67, 25);
            this.lblPasso.TabIndex = 3;
            this.lblPasso.Text = "Passo";
            // 
            // txtPasso
            // 
            this.txtPasso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasso.Location = new System.Drawing.Point(125, 110);
            this.txtPasso.Name = "txtPasso";
            this.txtPasso.Size = new System.Drawing.Size(258, 26);
            this.txtPasso.TabIndex = 2;
            this.txtPasso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasso_KeyDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Gray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // txtTituLo
            // 
            this.txtTituLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituLo.Location = new System.Drawing.Point(125, 47);
            this.txtTituLo.Name = "txtTituLo";
            this.txtTituLo.Size = new System.Drawing.Size(258, 26);
            this.txtTituLo.TabIndex = 0;
            this.txtTituLo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTituLo_KeyDown);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(38, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 33);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblPassos
            // 
            this.lblPassos.AutoSize = true;
            this.lblPassos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassos.Location = new System.Drawing.Point(691, 70);
            this.lblPassos.Name = "lblPassos";
            this.lblPassos.Size = new System.Drawing.Size(70, 24);
            this.lblPassos.TabIndex = 0;
            this.lblPassos.Text = "Passos";
            this.lblPassos.Visible = false;
            // 
            // lstboxPassos
            // 
            this.lstboxPassos.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPassos.FormattingEnabled = true;
            this.lstboxPassos.ItemHeight = 20;
            this.lstboxPassos.Location = new System.Drawing.Point(547, 98);
            this.lstboxPassos.Name = "lstboxPassos";
            this.lstboxPassos.Size = new System.Drawing.Size(363, 304);
            this.lstboxPassos.TabIndex = 7;
            this.lstboxPassos.Visible = false;
            this.lstboxPassos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstboxPassos_KeyDown);
            // 
            // btnCima
            // 
            this.btnCima.BackgroundImage = global::Procedimentos.Properties.Resources.Seta_Cima;
            this.btnCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCima.Location = new System.Drawing.Point(658, 408);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(40, 27);
            this.btnCima.TabIndex = 8;
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Visible = false;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.BackgroundImage = global::Procedimentos.Properties.Resources.Seta_Baixo;
            this.btnBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBaixo.Location = new System.Drawing.Point(704, 408);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(40, 27);
            this.btnBaixo.TabIndex = 9;
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Visible = false;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // btnLixeira
            // 
            this.btnLixeira.BackgroundImage = global::Procedimentos.Properties.Resources.Lixeira;
            this.btnLixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLixeira.Location = new System.Drawing.Point(764, 408);
            this.btnLixeira.Name = "btnLixeira";
            this.btnLixeira.Size = new System.Drawing.Size(40, 27);
            this.btnLixeira.TabIndex = 10;
            this.btnLixeira.UseVisualStyleBackColor = true;
            this.btnLixeira.Visible = false;
            this.btnLixeira.Click += new System.EventHandler(this.btnLixeira_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Location = new System.Drawing.Point(856, 480);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(65, 33);
            this.panelLogo.TabIndex = 12;
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
            // Criar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Procedimentos.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.btnLixeira);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnCima);
            this.Controls.Add(this.lstboxPassos);
            this.Controls.Add(this.lblPassos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Criar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Criar_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAdicionarPasso;
        private System.Windows.Forms.Label lblPasso;
        private System.Windows.Forms.TextBox txtPasso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTituLo;
        private System.Windows.Forms.Label lblPassos;
        private System.Windows.Forms.ListBox lstboxPassos;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Button btnLixeira;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
    }
}