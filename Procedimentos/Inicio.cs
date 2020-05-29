using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Ionic.Zip;
using System.IO;
using System.Threading;

namespace Procedimentos
{
    public partial class Inicio : Form
    {
        object codigo_usuario;
        Form form_autenticacao;
        CamadaNegocios funcao = new CamadaNegocios();

        public Inicio(object classe_usuario, Form autenticacacao)
        {
            form_autenticacao = autenticacacao;
            codigo_usuario = classe_usuario;

            InitializeComponent();
        }

        public void Resultado(string valor)
        {
            MessageBox.Show(valor);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnCriarProcedimento_Click(object sender, EventArgs e)
        {
            Point Posicao = new Point(100, 100);
            Posicao = this.Location;

            Form criar = new Criar(this, codigo_usuario, Posicao.X, Posicao.Y);
            this.Hide();
            criar.Show();
        }

        private void btnConsultarProcedimento_Click(object sender, EventArgs e)
        {
            Point Posicao = new Point(100, 100);
            Posicao = this.Location;

            Form consultar = new Consultar(this, codigo_usuario, Posicao.X, Posicao.Y);
            this.Hide();
            consultar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point Posicao = new Point(100, 100);
            Posicao = this.Location;

            Form usuario = new Usuarios(this, codigo_usuario, Posicao.X, Posicao.Y);
            this.Hide();
            usuario.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_autenticacao.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFazerBackup_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Atenção. É necessário que todos tenham saído do sistema. \n Confirma o backup?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                pgbarBackup.Visible = true;

                pgbarBackup.Value = pgbarBackup.Value + 30;

                Thread.Sleep(1000);

                try
                {
                    using (ZipFile zip = new ZipFile())
                    {
                        zip.AddDirectory(@"Procedimentos", new DirectoryInfo(@"Procedimentos").Name);
                        zip.AddDirectory(@"Usuarios", new DirectoryInfo(@"Usuarios").Name);
                        pgbarBackup.Value = pgbarBackup.Value + 30;
                        Thread.Sleep(1000);

                        // Salva o arquivo zip para o destino
                        try
                        {
                            pgbarBackup.Value = pgbarBackup.Value + 30;
                            zip.Save("Backup.zip");

                            Thread.Sleep(1000);

                            pgbarBackup.Value = pgbarBackup.Value + 10;

                            //Resetando o valor do progressBar
                            pgbarBackup.Value = 0;

                            MessageBox.Show("Backup realizado com sucesso");
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível fazer o backup");
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Não foi possível fazer o backup");
                }

                pgbarBackup.Visible = false;
            }
        }
    }
}
