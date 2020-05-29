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
    public partial class Usuarios : Form
    {
        Form voltar;
        private bool xClicked = true;
        Boolean arquivoEmUso = false;
        object codigo_usuario;
        string codigo_usuario_criar;
        Boolean criar_usuario = false;
        Validacao validar = new Validacao();
        CamadaNegocios funcao = new CamadaNegocios();

        //Esta lista representa os administradores
        string[] lista_administradores = new string[2];


        public Usuarios(Form inicio, object classe_usuario, int x, int y)
        {
            this.Location = new Point(x, y);
            codigo_usuario = classe_usuario;
            voltar = inicio;
            InitializeComponent();

            //Coloque aqui os administradores
            lista_administradores[0] = "0001";
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            //Verificando se o usuário tem permissão para criar 

            Boolean permissao_admin = false;

            for (int i = 0; i < lista_administradores.Length; i++)
            {
                if (codigo_usuario.ToString() == lista_administradores[i])
                    permissao_admin = true;
            }

            if (permissao_admin == false)
                MessageBox.Show("Você não possui permissão para criar usuários");

            //Verificando se há alguém criando um usuário no momento
            else if ((funcao.CriarUsuarioEmUso(codigo_usuario.ToString(), true)) == true)
            {
                //Obtendo o código de usuário a ser usado
                codigo_usuario_criar = funcao.ObterProximoCodigoUsuario();

                //Validando o código
                Boolean statusCodigoUsuario = validar.CodigoUsuario(codigo_usuario.ToString());

                if (statusCodigoUsuario == true)
                {
                    gpbUsuario.Visible = true;

                    btnCriarUsuario.Visible = false;
                    btnEditarUsuario.Visible = false;
                    lblModo.Visible = true;

                    arquivoEmUso = true;

                    //Indicando que está no modo de criação de usuário
                    criar_usuario = true;
                    lblModo.Text = "Criar usuário";
                    txtCodigo.Text = codigo_usuario_criar;
                    txtNome.Focus();
                }

                else
                {
                    MessageBox.Show("Código de usuários corrompido");

                    //Liberando os recursos
                    Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso("CriarUsuario", false);

                    if (statusLiberarRecurso == false)
                    {
                        MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo CriarUsuario.emuso");
                    }
                    arquivoEmUso = false;
                }
            }

            else
            {
                if (DialogResult.Yes == MessageBox.Show("Há outra pessoa criando usuários. Deseja forçar a criação?", "Criação de Usuários em uso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    if (DialogResult.Yes == MessageBox.Show("Atenção, forçar a criação pode causar perda de dados, sendo recomendado apenas em caso de falta de energia." +
                        " Deseja mesmo forçar a criação de usuários?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        //MessageBox.Show(txtNomeProcedimento.Text.ToString());
                        Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso("CriarUsuario", false);

                        if (statusLiberarRecurso == true)
                            btnCriarUsuario.PerformClick();
                        else
                            MessageBox.Show("Não foi possível liberar o recurso");
                    }
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            //Verificando se há alguém criando um usuário no momento
            Boolean statusEditarUsuario = funcao.CriarUsuarioEmUso(codigo_usuario.ToString(), false);

            if (statusEditarUsuario == true)
            {
                gpbUsuario.Visible = true;

                btnEditarUsuario.Visible = false;
                btnCriarUsuario.Visible = false;
                lblModo.Visible = true;

                //Indicando que está no modo de edição de usuário
                criar_usuario = false;
                arquivoEmUso = true;
                lblModo.Text = "Editar usuário";
                txtCodigo.Text = codigo_usuario.ToString().ToString();
                txtNome.Focus();
            }

            else
            {
                if (DialogResult.Yes == MessageBox.Show("Há outra pessoa editando seu usuário no momento. Deseja forçar a edição?", "Edição de Usuário em uso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    if (DialogResult.Yes == MessageBox.Show("Atenção, forçar a edição pode causar perda de dados, sendo recomendado apenas em caso de falta de energia." +
                        " Deseja mesmo forçar a edição de seu usuários", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        //MessageBox.Show(txtNomeProcedimento.Text.ToString());
                        Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso(codigo_usuario.ToString(), false);

                        if (statusLiberarRecurso == true)
                            btnCriarUsuario.PerformClick();
                        else
                            MessageBox.Show("Não foi possível liberar o recurso");
                    }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();
        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arquivoEmUso == true)
            {
                //Caso o usuário clique em sair enquanto faz uma edição

                Boolean statusLiberarRecurso;

                if (criar_usuario == true)
                    statusLiberarRecurso = funcao.ExcluirArquivoEmUso("CriarUsuario", false);
                else
                    statusLiberarRecurso = funcao.ExcluirArquivoEmUso(codigo_usuario.ToString(), false);

                if (statusLiberarRecurso == false)
                {
                    MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo CriarUsuario.emuso");
                }
                arquivoEmUso = false;
            }

            if (xClicked == true)
                voltar.Close();
            else
            {
                voltar.Location = this.Location;
                voltar.Show();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.ToString() == txtConfirmarSenha.Text.ToString())
            {
                //Fazendo a validação da senha
                string senha = txtSenha.Text.ToString();
                Boolean statusSenha = validar.senhaUsuario(senha);

                if (statusSenha == true)
                {
                    //Fazendo a validação do nome
                    string nome = txtNome.Text.ToString();
                    Boolean statusNome = validar.nomeUsuario(nome);

                    if (statusNome == true)
                    {
                        //Criptografando a senha
                        string senha_criptografada = validar.Criptografar(senha);

                        Boolean statusAdicionarUsuario;
                        if (criar_usuario == false)
                            statusAdicionarUsuario = funcao.AdicionarUsuario(codigo_usuario.ToString(), nome, senha_criptografada);
                        else
                            statusAdicionarUsuario = funcao.AdicionarUsuario(codigo_usuario_criar, nome, senha_criptografada);

                        if (statusAdicionarUsuario == true)
                        {                           
                            txtNome.Text = "";
                            txtSenha.Text = "";
                            txtConfirmarSenha.Text = "";

                            txtNome.Focus();

                            if (criar_usuario == true)
                            {
                                MessageBox.Show("Usuário adicionado com sucesso");
                                //Adicionando o codigo atual para novos usuários
                                string codigo_incrementado = validar.IncrementarCodigo(codigo_usuario_criar);
                                Boolean statusAtualizarCodigo = funcao.AtualizarCodigoUsuario(codigo_incrementado);
                                codigo_usuario_criar = codigo_incrementado;
                                txtCodigo.Text = codigo_incrementado;

                                if (statusAtualizarCodigo == false)
                                    MessageBox.Show("Não foi possível atualizar o registro de usuários. \n" +
                                                    "Atualize o arquivo 'CodigoUsuario.txt' colocando dentro dele, na primeira linha, o código '" + codigo_incrementado + "'"); ;
                            }

                            else
                            {
                                MessageBox.Show("Usuário editado com sucesso");
                                btnCancelar.PerformClick();
                            }
                        }

                        else
                            MessageBox.Show("Não foi possível fazer a solicitação");

                    }

                    else
                        MessageBox.Show("O nome do usuário deve ter entre 3 e 30 caracteres");
                }

                else
                    MessageBox.Show("A senha deve ter entre 3 e 20 caracteres");
            }

            else
                MessageBox.Show("Senhas não coincidem!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Boolean statusLiberarRecurso;

            if (criar_usuario == true)
                statusLiberarRecurso = funcao.ExcluirArquivoEmUso("CriarUsuario", false);
            else
                statusLiberarRecurso = funcao.ExcluirArquivoEmUso(codigo_usuario.ToString(), false);

            if (statusLiberarRecurso == false)
            {
                if (criar_usuario == true)
                    MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo CriarUsuario.emuso");
                else
                    MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo " + codigo_usuario.ToString() + ".emuso");
            }

            arquivoEmUso = false;

            gpbUsuario.Visible = false;

            btnCriarUsuario.Visible = true;
            btnEditarUsuario.Visible = true;
            lblModo.Visible = false;
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            Tuple<Boolean, string> tupla = funcao.ConsultarUsuario(codigo_usuario.ToString());

            Boolean statusConsultaUsuario = tupla.Item1;
            string nome_usuario = tupla.Item2;

            if (statusConsultaUsuario == true)
            {
                Boolean statusNomeUsuario = validar.nomeUsuario(nome_usuario);

                if (statusNomeUsuario == true)
                {
                    txtNome.Text = nome_usuario;
                }

                else
                    MessageBox.Show("O arquivo de seu usuário talvez tenha sido corrompido. \n" +
                                    "O nome de usuário não atende aos requisitos1");
            }

            else
                MessageBox.Show("Não foi possível editar seu usuário");
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
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

                txtConfirmarSenha.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtNome.Focus();
            }
        }

        private void txtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnSalvar.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtSenha.Focus();
            }
        }
    }
}

