using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Procedimentos
{
    class Validacao
    {

        public Boolean CodigoUsuario(string codigo)
        {
            try
            {
                int codigo_int = Int32.Parse(codigo);

                if (codigo_int <= 0 || codigo_int > 9999)
                    return false;

                return true;
            }
            
            catch
            {
                return false;
            }
        }

        public string IncrementarCodigo(string codigo_usuario)
        {
            try
            {
                int codigo_int = Int32.Parse(codigo_usuario);
                codigo_int = codigo_int + 1;

                codigo_usuario = codigo_int.ToString();

                while (codigo_usuario.Length < 4)
                {
                    codigo_usuario = "0" + codigo_usuario;
                }

                return codigo_usuario;
            }

            catch
            {
                return "0000";
            }
        }

        public string Criptografar(string senha)
        {
            MD5 md5Hash = MD5.Create();
            // Converter string para array
            byte[] dados = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            // Montar a string
            StringBuilder sBuilder = new StringBuilder();

            // Formatando byte a byte
            for (int i = 0; i < dados.Length; i++)
            {
                sBuilder.Append(dados[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public Boolean TituloProcedimento(string titulo)
        {
            if (titulo.Length < 3 || titulo.Length > 35)
                return false;

            else if (titulo.Contains('.') == true)
                return false;

            else
                return true;
        }

        public Boolean PassoProcedimento(string passo)
        {
            if (passo.Length < 1 || passo.Length > 40)
                return false;

            else
                return true;
        }

        public Boolean QuantidadeMaximaPassos(int quantidade_passos)
        {
            if (quantidade_passos == 150)
                return false;
            else
                return true;
        }

        public Boolean QuantidadeMinimaPassos(int quantidade_passos)
        {
            if (quantidade_passos < 2)
                return false;
            else
                return true;
        }

        public Boolean nomeUsuario(string nome)
        {
            if (nome.Length < 3 || nome.Length > 30)
                return false;
            else
                return true;
        }

        public Boolean senhaUsuario(string senha)
        {
            if (senha.Length < 3 || senha.Length > 20)
                return false;
            else
                return true;
        }
    }
}
