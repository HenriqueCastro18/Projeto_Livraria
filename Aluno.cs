using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    public class Aluno
    {
        private string cpf;
        private string nome;
        private string nascimento;


        public Aluno(string Cpf, string Nome, string Nascimento)
        {
            cpf = Cpf;
            nome = Nome;
            nascimento = Nascimento;
        }

        public Aluno()
        {
            cpf = "";
            nome = "";
            nascimento = "";

        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string valor)
        {
            cpf = valor;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string valor)
        {
            nome = valor;
        }

        public string GetNascimento()
        {
            return nascimento;
        }

        public void SetNascimento(string valor)
        {
            nascimento = valor;
        }

    }
}
