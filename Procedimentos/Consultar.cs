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
    public partial class Consultar : Form
    {   
        string dados_criacao;
        string titulo_antigo;
        string arquivoEmUso = "";
        object codigo_usuario;

        Form voltar;
        Validacao validar = new Validacao();
        CamadaNegocios funcao = new CamadaNegocios();

        public Consultar(Form Inicio, object classe_usuario, int x, int y)
        {
            this.Location = new Point(x, y);
            codigo_usuario = classe_usuario;
            voltar = Inicio;
            InitializeComponent();
        }

        private bool xClicked = true;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            xClicked = false;
            this.Close();
        }

        private void Consultar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arquivoEmUso != "" && arquivoEmUso != null)
            {
                //Caso o usuário clique em sair enquanto faz uma edição

                Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso(arquivoEmUso, true);

                if (statusLiberarRecurso == false)
                {
                    MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo " + arquivoEmUso + ".emuso");
                }
                arquivoEmUso = "";
            }

            if (xClicked == true)
                voltar.Close();
            else
            {
                voltar.Location = this.Location;
                voltar.Show();
            }
        }

        private void btnConsultarProcedimento_Click(object sender, EventArgs e)
        {
            lstboxProcedimentos.Items.Clear();
            string titulo = txtTitulo.Text.ToString();

            List <string> lista_arquivos = new List<string>();

            lista_arquivos = funcao.ConsultarProcedimentos(titulo);
            
            for (int i = 0; i < lista_arquivos.Count; i++)
            {
                if (lista_arquivos[i] != null && lista_arquivos[i] != "")
                lstboxProcedimentos.Items.Add("   " + lista_arquivos[i]);
            }
        }

        private void lstboxProcedimentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AcessarProcedimento();
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            dados_criacao = "";
            lstboxPassos.Visible = false;
            btnEsquerda.Visible = false;
            btnEditar.Visible = false;
            txtNomeProcedimento.Visible = false;
            btnInterrogacao.Visible = false;

            lstboxProcedimentos.Visible = true;
            txtTitulo.Visible = true;
            lblTitulo.Visible = true;
            btnConsultarProcedimento.Visible = true;

            lstboxPassos.Items.Clear();
            btnConsultarProcedimento.PerformClick();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean permissaoEditar = funcao.CriarArquivoEmUso(txtNomeProcedimento.Text.ToString(), codigo_usuario.ToString());

                if (permissaoEditar == true)
                {
                    arquivoEmUso = txtNomeProcedimento.Text.ToString();
                    titulo_antigo = txtNomeProcedimento.Text.ToString();
                    btnEditar.Visible = false;
                    btnEsquerda.Visible = false;
                    btnInterrogacao.Visible = false;

                    btnSalvar.Visible = true;
                    btnCancelar.Visible = true;
                    btnMais.Visible = true;
                    btnCima.Visible = true;
                    btnBaixo.Visible = true;
                    btnLixeira.Visible = true;
                    btnExcluirProcedimento.Visible = true;
                    txtNomeProcedimento.Enabled = true;
                }

                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Este procedimento está atualmente em uso. Deseja forçar a edição?", "Procedimento em uso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        if (DialogResult.Yes == MessageBox.Show("Atenção, forçar a edição pode causar perda de dados, sendo recomendado apenas em caso de falta de energia." +
                            " Deseja mesmo forçar a edição de " + txtNomeProcedimento.Text.ToString() + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso(txtNomeProcedimento.Text.ToString(), true);

                            if (statusLiberarRecurso == true)
                                btnEditar.PerformClick();
                            else
                                MessageBox.Show("Não foi possível liberar o recurso");
                        }
                }
            }

            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnMais.Visible = false;
            btnCima.Visible = false;
            btnBaixo.Visible = false;
            btnLixeira.Visible = false;
            lstboxPassos.Visible = false;

            lstboxProcedimentos.Visible = true;
            lblTitulo.Visible = true;
            txtTitulo.Visible = true;
            btnConsultarProcedimento.Visible = true;
            btnExcluirProcedimento.Visible = false;
            txtNomeProcedimento.Visible = false;
            txtNomeProcedimento.Enabled = false;
            dados_criacao = "";

            //Liberando o arquivo para outras pessoas editarem
            Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso(arquivoEmUso, true);

            if (statusLiberarRecurso == false)
            {
                MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo " + arquivoEmUso + ".emuso");
            }

            btnConsultarProcedimento.PerformClick();
            arquivoEmUso = "";
        }

        private void gpbProcedimentos_Enter(object sender, EventArgs e)
        {

        }

        private void txtTitulo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            var index = lstboxPassos.SelectedIndex;

            //Caso o item já esteja no topo
            if (index - 1 < 0)
                return;

            var item = lstboxPassos.Items[index];

            //Removendo o item
            lstboxPassos.Items.Remove(item);

            //Inserindo-o na nova posição
            lstboxPassos.Items.Insert(index - 1, item);

            //Selecionando-o novamente para caso seja subida consecutiva
            lstboxPassos.SelectedIndex = index - 1;
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            int index = lstboxPassos.SelectedIndex;

            //Caso o item já seja o ultimo
            if (index + 1 > lstboxPassos.Items.Count - 1 || index == -1)
                return;

            else
            {
                var item = lstboxPassos.Items[index];

                //Removendo o item
                lstboxPassos.Items.Remove(item);

                //Inserindo-o na nova posição
                lstboxPassos.Items.Insert(index + 1, item);

                //Selecionando-o para caso seja descida consecutiva
                lstboxPassos.SelectedIndex = index + 1;
            }
        }

        private void btnLixeira_Click(object sender, EventArgs e)
        {
            if (lstboxPassos.SelectedIndex != -1)
            {
                var item = lstboxPassos.Items[lstboxPassos.SelectedIndex];
                lstboxPassos.Items.Remove(item);
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtNovoPasso.Text = "";
            txtNovoPasso.Visible = true;
            txtNovoPasso.Focus();
        }

        private void txtNovoPasso_Leave(object sender, EventArgs e)
        {
            txtNovoPasso.Visible = false;
        }

        private void txtNovoPasso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                //Fazendo a validação dos dados
                string novoPasso = txtNovoPasso.Text = txtNovoPasso.Text.ToString();
                novoPasso = novoPasso.Trim();
                Boolean statusValidacaoPasso = validar.PassoProcedimento(novoPasso);

                if (statusValidacaoPasso == true)
                {
                    //Validando a quantidade de passos já cadastrada
                    Boolean statusValidarQuantidadeMaximaPassos = validar.QuantidadeMaximaPassos(lstboxPassos.Items.Count);

                    if (statusValidarQuantidadeMaximaPassos == true)
                    {
                        lstboxPassos.Items.Add(' ' + novoPasso);

                        txtNovoPasso.Text = "";
                        lstboxPassos.SelectedIndex = lstboxPassos.Items.Count - 1;
                    }

                    else
                        MessageBox.Show("Limite máximo de passos é 150");

                }

                else
                    MessageBox.Show("Passo inválido. Ele deve: \n\n" +
                        "Ter entre 1 e 40 caracteres");

                
            }

            else if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtNovoPasso.Visible = false;
                btnMais.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtNomeProcedimento.Text.ToString();
            titulo = titulo.Trim();

            //Validando os dados
            Boolean statusTituloProcedimento = validar.TituloProcedimento(titulo);

            if (statusTituloProcedimento == true)
            {
                //Verificando se existe já um procedimento com este nome
                Boolean existeTituloProcedimento = funcao.ExisteProcedimento(titulo);

                //Fazendo a validação para quantidade mínima de items na listbox
                Boolean statusQuantidadeMinimaPassos = validar.QuantidadeMinimaPassos(lstboxPassos.Items.Count);

                if (existeTituloProcedimento == true && titulo != titulo_antigo) 
                {
                    MessageBox.Show("Já existe um procedimento com este título");
                    txtNomeProcedimento.Focus();
                }
                
                else if (statusQuantidadeMinimaPassos == true)
                {
                    string[] passos = new string[150];

                    //Adicionando os passos no vetor
                    for (int i = 0; i < lstboxPassos.Items.Count; i++)
                    {
                        passos[i] = lstboxPassos.Items[i].ToString();
                    }


                    Boolean statusEdicao;
                    statusEdicao = funcao.EditarProcedimento(titulo_antigo, titulo, passos, codigo_usuario.ToString(), dados_criacao);

                    if (statusEdicao == true)
                    {
                        MessageBox.Show("Procedimento editado com sucesso!");
                        btnSalvar.Visible = false;
                        btnCancelar.Visible = false;
                        btnMais.Visible = false;
                        btnCima.Visible = false;
                        btnBaixo.Visible = false;
                        btnLixeira.Visible = false;
                        lstboxPassos.Visible = false;

                        lstboxProcedimentos.Visible = true;
                        lblTitulo.Visible = true;
                        txtTitulo.Visible = true;
                        btnConsultarProcedimento.Visible = true;
                        txtNomeProcedimento.Visible = false;
                        txtNomeProcedimento.Enabled = false;
                        btnExcluirProcedimento.Visible = false;
                        btnConsultarProcedimento.PerformClick();
                        dados_criacao = "";

                        //Liberando o arquivo para outras pessoas editarem
                        Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso(arquivoEmUso, true);

                        if (statusLiberarRecurso == false)
                            MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo " + arquivoEmUso + ".emuso");
                        arquivoEmUso = "";
                    }

                    else
                        MessageBox.Show("Não foi possível salvar. Tente novamente");
                }

                else
                    MessageBox.Show("É necessário ter pelo menos 2 passos no procedimento");
            }

            else
            {
                MessageBox.Show("Titulo inválido. Ele deve: \n\n" +
                                "Ter entre 3 e 35 caracteres \n" +
                                "Não ter o caractere '.'");

                txtNomeProcedimento.Focus();
            }
        }


        private void btnInterrogacao_Click(object sender, EventArgs e)
        {
            if (dados_criacao.Length == 18)
            {
                string ano_criacao = dados_criacao.Substring(0, 4);
                string mes_criacao = dados_criacao.Substring(4, 2);
                string dia_criacao = dados_criacao.Substring(6, 2);
                string hora_criacao = dados_criacao.Substring(8, 2);
                string minuto_criacao = dados_criacao.Substring(10, 2);
                string segundo_criacao = dados_criacao.Substring(12, 2);
                string usuario_criacao = dados_criacao.Substring(14);

                //Obtendo o nome do usuário que criou
                string nome_usuario_criacao = funcao.ObterNomeUsuario(usuario_criacao);

                if (nome_usuario_criacao != "")
                    MessageBox.Show("Criado em: " + dia_criacao + '/' + mes_criacao + '/' + ano_criacao + " por: " + nome_usuario_criacao);
                else
                    MessageBox.Show("Não foi possível obter os dados do procedimento");
            }

            else if (dados_criacao.Length == 36)
            {
                string ano_criacao = dados_criacao.Substring(0, 4);
                string mes_criacao = dados_criacao.Substring(4, 2);
                string dia_criacao = dados_criacao.Substring(6, 2);
                string hora_criacao = dados_criacao.Substring(8, 2);
                string minuto_criacao = dados_criacao.Substring(10, 2);
                string segundo_criacao = dados_criacao.Substring(12, 2);
                string usuario_criacao = dados_criacao.Substring(14, 4);

                string ano_edicao = dados_criacao.Substring(18, 4);
                string mes_edicao = dados_criacao.Substring(22, 2);
                string dia_edicao = dados_criacao.Substring(24, 2);
                string hora_edicao = dados_criacao.Substring(26, 2);
                string minuto_edicao = dados_criacao.Substring(28, 2);
                string segundo_edicao = dados_criacao.Substring(30, 2);
                string usuario_edicao = dados_criacao.Substring(32);

                //Obtendo o nome do usuário que criou e editou
                string nome_usuario_criacao = funcao.ObterNomeUsuario(usuario_criacao);
                string nome_usuario_edicao = funcao.ObterNomeUsuario(usuario_edicao);

                if (nome_usuario_criacao != "" && nome_usuario_edicao != "")
                    MessageBox.Show("Criado em: " + dia_criacao + '/' + mes_criacao + '/' + ano_criacao + " por: " + nome_usuario_criacao
                                    + "\n\n" + "Editado por último em: " + dia_edicao + '/' + mes_edicao + '/' + ano_edicao + " por: " + nome_usuario_edicao);
                else
                    MessageBox.Show("Não foi possível obter os dados do procedimento");
            }

            else
            {
                MessageBox.Show("Não foi possível obter os dados do procedimento");
            }
        }

        private void txtTitulo_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnConsultarProcedimento.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnVoltar.PerformClick();
            }

        }

        private void txtNomeProcedimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnCancelar.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnExcluirProcedimento_Click(object sender, EventArgs e)
        {
            //Confirmando se realmente deeja excluir o procedimento
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o procedimento " + titulo_antigo + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Boolean statusExclusao = funcao.ExcluirProcedimento(titulo_antigo);

                if (statusExclusao == true)
                {
                    MessageBox.Show("Procedimento excluido com sucesso!");
                    btnSalvar.Visible = false;
                    btnCancelar.Visible = false;
                    btnMais.Visible = false;
                    btnCima.Visible = false;
                    btnBaixo.Visible = false;
                    btnLixeira.Visible = false;
                    lstboxPassos.Visible = false;

                    lstboxProcedimentos.Visible = true;
                    lblTitulo.Visible = true;
                    txtTitulo.Visible = true;
                    btnConsultarProcedimento.Visible = true;
                    txtNomeProcedimento.Visible = false;
                    txtNomeProcedimento.Enabled = false;
                    btnExcluirProcedimento.Visible = false;
                    btnConsultarProcedimento.PerformClick();
                    dados_criacao = "";

                    //Liberando o arquivo para outras pessoas editarem
                    Boolean statusLiberarRecurso = funcao.ExcluirArquivoEmUso(arquivoEmUso, true);

                    if (statusLiberarRecurso == false)
                        MessageBox.Show("Não foi possível liberar o recurso. Tente apagar (se ainda houver) manualmente o arquivo " + arquivoEmUso + ".emuso");
                    arquivoEmUso = "";
                }

                else
                    MessageBox.Show("Não foi possível excluir o procedimento!");
            }
        }

        private void lstboxTeste_DoubleClick(object sender, EventArgs e)
        {
            btnEditar.PerformClick();
        }

        private void lstboxProcedimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                AcessarProcedimento();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnVoltar.Focus();
            }
        }

        private void AcessarProcedimento()
        {
            lstboxPassos.Items.Clear();
            try
            {
                string titulo = lstboxProcedimentos.Items[lstboxProcedimentos.SelectedIndex].ToString();
                titulo = titulo.Substring(3);
                txtNomeProcedimento.Text = titulo;

                string[] passos = new string[150];
                Boolean statusConsulta;

                //Criando uma tupla e obtendo o status da consulta e os passos do procedimento
                Tuple<Boolean, string[]> tupla = funcao.ConsultarPassos(titulo);
                statusConsulta = tupla.Item1;
                passos = tupla.Item2;

                if (statusConsulta == true)
                {
                    lstboxProcedimentos.Visible = false;
                    lstboxPassos.Visible = true;
                    btnEsquerda.Visible = true;
                    btnEditar.Visible = true;
                    btnInterrogacao.Visible = true;

                    if (passos[0] != null)
                        if (passos[0].Trim() != "")
                            if (passos[0].Length == 18 || passos[0].Length == 36)
                                dados_criacao = passos[0];
                            else
                                dados_criacao = "";

                    for (int i = 1; i < passos.Length - 1; i++)
                    {
                        if (passos[i] != null)
                            if (passos[i].Trim() != "")
                                lstboxPassos.Items.Add(passos[i]);
                    }

                    lblTitulo.Visible = false;
                    txtTitulo.Visible = false;
                    btnConsultarProcedimento.Visible = false;
                    txtNomeProcedimento.Visible = true;
                }

                else
                    MessageBox.Show("Não foi possível consultar o procedimento");
            }

            catch

            {
                
            }
        }

        private void lstboxTeste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnLixeira.PerformClick();
            }
        }
    }
}
