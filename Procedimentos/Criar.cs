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
    public partial class Criar : Form
    {
        Form voltar;
        Validacao validar = new Validacao();
        object codigo_usuario;

        public Criar(Form Inicio, object classe_usuario, int x, int y)
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

        private void btnAdicionarPasso_Click(object sender, EventArgs e)
        {
            AdicionarPasso();
        }

        private void Criar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Caso o usuário tenha clicado no x, irá fechar o programa
            if (xClicked == true)
                voltar.Close();

            //Caso ele tenha clicado no voltar
            else
            {
                voltar.Location = this.Location;
                voltar.Show();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Fazendo a validação dos dados
            string titulo = txtTituLo.Text.ToString();
            titulo = titulo.Trim();
            Boolean statusValidacaoTitulo = validar.TituloProcedimento(titulo);

            if (statusValidacaoTitulo == true)
            {
                //Verificando se existe já um procedimento com este nome
                CamadaNegocios funcao = new CamadaNegocios();
                Boolean existeTituloProcedimento = funcao.ExisteProcedimento(titulo);

                //Fazendo a validação para quantidade mínima de items na listbox
                Boolean statusQuantidadeMinimaPassos = validar.QuantidadeMinimaPassos(lstboxPassos.Items.Count);


                if (existeTituloProcedimento == true)
                    MessageBox.Show("Já existe um procedimento com este título");

                else if (statusQuantidadeMinimaPassos == true)
                {
                    string[] passos = new string[150];

                    //Adicionando os passos no vetor
                    for (int i = 0; i < lstboxPassos.Items.Count; i++)
                    {
                        passos[i] = lstboxPassos.Items[i].ToString();
                    }

                    //Obtendo o status da criação do procedimento
                    Boolean statusAdicionar = funcao.AdicionarProcedimento(titulo, passos, codigo_usuario.ToString());

                    if (statusAdicionar == true)
                    {
                        MessageBox.Show("Procedimento criado com sucesso!");
                        LimparCaixas();
                    }
                    else
                        MessageBox.Show("Não foi possível gravar. Verifique se a pasta Procedimentos existe e se a data do PC está correta");
                }

                else
                {
                    MessageBox.Show("É necessário ter pelo menos 2 passos no procedimento");
                    txtPasso.Focus();
                }
            }

            else
            {
                MessageBox.Show("Titulo inválido. Ele deve: \n\n" +
                                "Ter entre 3 e 35 caracteres \n" +
                                "Não ter o caractere '.'");

                txtTituLo.Focus();
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCaixas();
        }

        private void AdicionarPasso()
        {
            //Fazendo a validação dos dados
            string passo = txtPasso.Text.ToString();
            passo = passo.Trim();
            Boolean statusValidacaoPasso = validar.PassoProcedimento(passo);

            if (statusValidacaoPasso == true)
            {
                //Validando a quantidade de passos já cadastrada
                Boolean statusValidarQuantidadeMaximaPassos = validar.QuantidadeMaximaPassos(lstboxPassos.Items.Count);

                if (statusValidarQuantidadeMaximaPassos)
                {
                    //Deixando visível os componentes dos passos
                    lstboxPassos.Visible = true;
                    lblPassos.Visible = true;
                    btnBaixo.Visible = true;
                    btnCima.Visible = true;
                    btnLixeira.Visible = true;

                    //Adicionando o passo na listbox
                    lstboxPassos.Items.Add(' ' + txtPasso.Text.ToString());
                    lstboxPassos.SelectedIndex = lstboxPassos.Items.Count - 1;

                    txtPasso.Text = "";
                    txtPasso.Focus();
                }

                else
                    MessageBox.Show("Limite máximo de passos é 150");
            }

            else
            {
                MessageBox.Show("Passo inválido. Ele deve: \n\n" +
                                "Ter entre 1 e 40 caracteres");
                txtPasso.Focus();
            }    
        }

        private void txtPasso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;
                
                AdicionarPasso();
            }
        }

        private void LimparCaixas()
        {
            //Limpando a listbox
            lstboxPassos.Items.Clear();

            //Deixando invisível os componentes dos passos
            lstboxPassos.Visible = false;
            lblPassos.Visible = false;
            btnBaixo.Visible = false;
            btnCima.Visible = false;
            btnLixeira.Visible = false;

            //Limpando as caixas de texto
            txtPasso.Text = "";
            txtTituLo.Text = "";
            txtTituLo.Focus();
        }

        private void txtTituLo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtPasso.Focus();
            }

            if (e.KeyCode == Keys.Escape)
            {
                //Evitando o barulho de "erro" do windows
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnVoltar.PerformClick();
            }
        }

        private void lstboxPassos_KeyDown(object sender, KeyEventArgs e)
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
