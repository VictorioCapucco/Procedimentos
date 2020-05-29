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

namespace Procedimentos
{
    public partial class Autenticacao : Form
    {
        CamadaNegocios funcao = new CamadaNegocios();
        Validacao validacoes = new Validacao();

        public Autenticacao()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtSenha.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnCancelar.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnEntrar.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtCodigo.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.ToString();
            codigo = codigo.Trim();

            //Verificando se o código é valido
            Boolean statusCodigo = validacoes.CodigoUsuario(codigo);

            if (statusCodigo == true)
            {
                while (codigo.Length != 4)
                    codigo = '0' + codigo;

                //Verificando se o usuário existe
                statusCodigo = funcao.ExisteUsuario(codigo);

                if (statusCodigo == true)
                {
                    //Caso o usuário exista
                    string senha = txtSenha.Text.ToString();

                    //Criptografando a senha para enviar para a autenticação
                    senha = validacoes.Criptografar(senha);

                    //Autenticando
                    statusCodigo = funcao.AutenticarUsuario(codigo, senha);

                    if (statusCodigo == true)
                    {
                        this.Hide();

                        Usuario classe_usuario = new Usuario();
                        classe_usuario.Codigo = codigo;

                        Form inicio_programa = new Inicio(classe_usuario.Codigo, this);

                        inicio_programa.StartPosition = FormStartPosition.CenterScreen;
                        inicio_programa.Show();
                    }

                    else
                        MessageBox.Show("Código de usuário ou senha incorretos");
                    
                }

                else
                    MessageBox.Show("Código de usuário ou senha incorretos");
            }

            else
                MessageBox.Show("Código de usuário ou senha incorretos");
        }
    }
}
