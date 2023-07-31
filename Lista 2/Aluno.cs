using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_2
{
    internal class Aluno
    {
        public int matricula { get; set; }
        public string Nome { get; set; }

        public string cpf { get; set; }

        public DateOnly DataNascimento { get; set; }

        public Aluno() // Sobrecarga, so diferencia pelas assinaturasm (atributos)
        {

        }
        public Aluno(int matricula, string nome, string cpf, DateOnly DataNascimento)
        {
            this.matricula = matricula;
            this.Nome = nome;
            this.cpf = cpf;
            this.DataNascimento = DataNascimento;
        }
    }
}
