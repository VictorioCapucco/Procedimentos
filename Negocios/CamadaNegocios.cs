using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Negocios
{
    public class CamadaNegocios
    {
        public Boolean AdicionarProcedimento(string titulo, string[] passos, string usuario)
        {
            string id = (DateTime.Now.ToString("yyyyMMddHHmmss")) + usuario;

            try
            {
                string[] paths = { @"Procedimentos", titulo + ".txt" };
                string caminho = Path.Combine(paths);

                if (!File.Exists(caminho))
                {

                    using (StreamWriter writer = new StreamWriter(caminho))
                    {
                        writer.WriteLine(id);

                        for (int i = 0; i < passos.Length; i++)
                        {
                            if (passos[i] != null && passos[i] != "")
                                writer.WriteLine(passos[i]);
                        }
                    }

                    return true;
                }

                else
                    return false;
            }

            catch
            {
                return false;
            }
        }

        public List<string> ConsultarProcedimentos(string titulo)
        {
            //string[] lista_arquivos = new string[20];
            List<string> lista_arquivos = new List<string>();
            string caminho = @"Procedimentos\";

            DirectoryInfo dir_files = new DirectoryInfo(caminho);
            FileInfo[] files = dir_files.GetFiles("*" + titulo + "*.txt", SearchOption.TopDirectoryOnly);

            int i = 0;
            string temp;
            foreach (var fil in files)
            {
                temp = fil.Name;
                temp = temp.Substring(0, temp.IndexOf('.'));
                //lista_arquivos.Add(fil.Name);
                //lista_arquivos.Add(lista_arquivos[i].Substring(0, lista_arquivos[i].IndexOf('.')));
                lista_arquivos.Add(temp);
                i += 1;
            }

            return lista_arquivos;
        }

        public Tuple<Boolean, string[]> ConsultarPassos(string procedimento)
        {
            string[] passos = new string[150];
            string[] paths = { @"Procedimentos", procedimento + ".txt" };
            string arquivo = Path.Combine(paths);

            if (File.Exists(arquivo))
            {
                try
                {
                    string linha;
                    using (StreamReader leitura = new StreamReader(arquivo))
                    {
                        int i = 0;
                        while ((linha = leitura.ReadLine()) != null)
                        {
                            passos[i] = linha;
                            i += 1;
                        }
                    }

                    //Retornando uma tupla com o status de retorno, e a lista com procedimentos
                    return new Tuple<Boolean, string[]>(true, passos);
                }

                catch
                {
                    //Retornando uma tupla com o status de retorno, e a lista com os passos
                    return new Tuple<Boolean, string[]>(false, passos);
                }
            }

            else
                //Retornando uma tupla com o status de retorno, e a lista com os passos
                return new Tuple<Boolean, string[]>(true, passos);
        }

        public Boolean EditarProcedimento(string titulo_antigo, string titulo_novo, string[] passos, string usuario, string criacao)
        {
            string horario = (DateTime.Now.ToString("yyyyMMddHHmmss"));

            string[] paths = { @"Procedimentos", titulo_antigo + ".txt" };
            string caminho_antigo = Path.Combine(paths);

            if (File.Exists(caminho_antigo))
            {
                try
                {
                    File.Delete(caminho_antigo);

                    string[] paths_novo = { @"Procedimentos", titulo_novo + ".txt" };
                    string caminho_novo = Path.Combine(paths_novo);

                    using (StreamWriter writer = new StreamWriter(caminho_novo))
                    {
                        //Caso o procedimento nunca tenha sido editado
                        if (criacao.Length == 18)
                        {
                            writer.WriteLine(criacao + horario + usuario);
                        }

                        //Caso já tenha sido editado
                        else if (criacao.Length == 36)
                        {
                            criacao = criacao.Substring(0, 18);
                            writer.WriteLine(criacao + horario + usuario);
                        }

                        //Caso o arquivo tenha sido manipulado erroneamente
                        else
                            writer.WriteLine(horario + usuario);

                        int i = 0;

                        while (passos[i] != null)
                        {
                            writer.WriteLine(passos[i]);
                            i += 1;
                        }
                    }

                    return true;
                }

                catch
                {
                    return false;
                }
            }

            else
            {
                return false;
            }

        }

        public Boolean ExcluirProcedimento(string titulo)
        {
            string[] passos = new string[150];
            string[] paths = { @"Procedimentos", titulo + ".txt" };
            string arquivo = Path.Combine(paths);

            if (File.Exists(arquivo))
            {
                try
                {
                    File.Delete(arquivo);
                    return true;
                }

                catch
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }

        public Boolean CriarArquivoEmUso(string nome_arquivo, string usuario)
        {
            try
            {
                string[] paths = { @"Procedimentos", nome_arquivo + ".emuso" };
                string caminho = Path.Combine(paths);

                if (!File.Exists(caminho))
                {

                    using (StreamWriter writer = new StreamWriter(caminho))
                    {
                        writer.WriteLine(usuario);
                    }

                    return true;

                }

                else
                    return false;
            }

            catch
            {
                return false;
            }
        }

        public Boolean ExcluirArquivoEmUso(string nome_arquivo, Boolean procedimentos)
        {

            string pasta;

            if (procedimentos == false)
                pasta = "Usuarios";

            else
                pasta = "Procedimentos";

            string[] paths = { @pasta, nome_arquivo + ".emuso" };

            string caminho = Path.Combine(paths);


            if (File.Exists(caminho))
            {
                try
                {
                    File.Delete(caminho);
                    return true;
                }

                catch
                {
                    return false;
                }
            }

            else
                return false;
        }

        public Boolean ExisteProcedimento(string nome_procedimento)
        {
            string[] paths = { @"Procedimentos", nome_procedimento + ".txt" };
            string arquivo = Path.Combine(paths);

            if (File.Exists(arquivo))
                return true;
            else
                return false;
        }

        public Boolean AdicionarUsuario(string codigo_usuario, string nome_usuario, string senha_usuario)
        {
            string[] paths = { @"Usuarios", codigo_usuario + ".txt" };
            string caminho = Path.Combine(paths);

            try
            {

                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    writer.WriteLine(nome_usuario);
                    writer.WriteLine(senha_usuario);
                }

                return true;
            }

            catch
            {
                return false;
            }
        }

        public Boolean CriarUsuarioEmUso(string usuario, Boolean criarUsuario)
        {
            string nome_arquivo;
            if (criarUsuario == true)
            {
                nome_arquivo = "CriarUsuario";
            }

            else
            {
                nome_arquivo = usuario;
            }

            string[] paths = { @"Usuarios", nome_arquivo + ".emuso" };
            string caminho = Path.Combine(paths);

            if (!File.Exists(caminho))
            {
                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    writer.WriteLine(usuario);
                }

                return true;

            }

            else
                return false;

        }

        public Boolean AtualizarCodigoUsuario(string codigo)
        {
            try
            {
                string[] paths = { @"Usuarios", "CodigoUsuario.txt" };
                string caminho = Path.Combine(paths);

                File.Delete(caminho);

                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    writer.WriteLine(codigo);
                }

                return true;

            }

            catch
            {
                return false;
            }
        }

        public string ObterProximoCodigoUsuario()
        {
            try
            {
                string[] paths = { @"Usuarios", "CodigoUsuario.txt" };
                string caminho = Path.Combine(paths);

                string linha;
                using (StreamReader leitura = new StreamReader(caminho))
                {
                    linha = leitura.ReadLine();
                }

                return linha;
            }

            catch
            {
                return "0000";
            }
        }
        public Tuple<Boolean, string> ConsultarUsuario(string codigo)
        {
            try
            {
                string[] paths = { @"Usuarios", codigo + ".txt"};
                string caminho = Path.Combine(paths);

                string linha;
                using (StreamReader leitura = new StreamReader(caminho))
                {
                    linha = leitura.ReadLine();
                }

                return new Tuple<Boolean, string>(true, linha);
            }

            catch
            {
                return new Tuple<Boolean, string>(false, "");
            }
        }

        public Boolean ExisteUsuario(string codigo_usuario)
        {
            string[] paths = { @"Usuarios", codigo_usuario + ".txt" };
            string arquivo = Path.Combine(paths);

            if (File.Exists(arquivo))
                return true;
            else
                return false;
        }

        public Boolean AutenticarUsuario(string codigo_usuario, string senha_usuario)
        {
            string[] paths = { @"Usuarios", codigo_usuario + ".txt" };
            string caminho = Path.Combine(paths);
            string senha_arquivo;

            try
            {
                using (StreamReader leitura = new StreamReader(caminho))
                {
                    //Pegando a senha na segunda linha do arquivo
                    senha_arquivo = File.ReadLines(caminho).Skip(1).Take(1).First();
                }

                if (senha_usuario == senha_arquivo)
                    return true;
                else
                    return false;
            }

            catch
            {
                return false;
            }
        }

        public string ObterNomeUsuario(string codigo_usuario)
        {
            string[] paths = { @"Usuarios", codigo_usuario + ".txt" };
            string caminho = Path.Combine(paths);
            string nome_usuario;

            try
            {
                using (StreamReader leitura = new StreamReader(caminho))
                {
                    //Pegando o nome do usuário na primeira linha do arquivo
                    nome_usuario = leitura.ReadLine();
                }
                return nome_usuario;
            }

            catch
            {
                return "";
            }
        }

        public Boolean ExistePastasSistema()
        {
            string[] paths = { @"Usuarios", "0001.txt" };
            string usuario_inicial = Path.Combine(paths);

            string[] paths2 = { @"Usuarios", "CodigoUsuario.txt" };
            string codigo_usuario = Path.Combine(paths2);

            if (File.Exists(usuario_inicial) && File.Exists(codigo_usuario))
            {
                return true;
            }

            else
                return false;
        }

        public Boolean CriarPastasSistema()
        {
            try
            {
                //Apagando as pastas se houver
                if (Directory.Exists(@"Usuarios"))
                    Directory.Delete(@"Usuarios");

                if (Directory.Exists(@"Procedimentos"))
                    Directory.Delete(@"Procedimentos");

                //Criando as pastas novamente
                Directory.CreateDirectory(@"Usuarios");
                Directory.CreateDirectory(@"Procedimentos");


                //Criando os arquivos
                string[] paths = { @"Usuarios", "0001.txt" };
                string usuario_inicial = Path.Combine(paths);

                string[] paths2 = { @"Usuarios", "CodigoUsuario.txt" };
                string codigo_usuario = Path.Combine(paths2);


                using (StreamWriter writer = new StreamWriter(usuario_inicial))
                {
                    writer.WriteLine("Admin");
                    writer.WriteLine("81dc9bdb52d04dc20036dbd8313ed055");
                }

                using (StreamWriter writer = new StreamWriter(codigo_usuario))
                {
                    writer.WriteLine("0002");
                }

                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
