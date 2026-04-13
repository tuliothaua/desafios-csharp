// Alunos: Túlio Thauã Dutra e José Pedro
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Leitor
    {
        private string _nome = string.Empty; // Inicializado para evitar CS8618
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nome não pode ser nulo ou vazio.");
                }
                _nome = value.Trim();
            }
        }

        private string _cpf = string.Empty; // Inicializado para evitar CS8618
        public string Cpf
        {
            get => _cpf;
            private set // CPF deve ser imutável após a criação e definido no construtor
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("CPF não pode ser nulo ou vazio.");
                }
                // A validação de CPF repetido será feita na classe Biblioteca, ao tentar cadastrar.
                _cpf = value.Trim();
            }
        }

        private int _idade; // int é um tipo de valor, não pode ser nulo
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Idade não pode ser negativa.");
                }
                _idade = value;
            }
        }

        public List<Livro> LivrosEmPosse { get; private set; } = new List<Livro>(); // Inicializado para evitar CS8618

        public Leitor(string nome, string cpf, int idade)
        {
            // Chamamos os setters para aplicar as validações
            Nome = nome;
            Cpf = cpf; // O setter privado garante que o valor seja trimado e não nulo/vazio
            Idade = idade;
            // LivrosEmPosse já é inicializado na declaração da propriedade
        }

        public string ExibirDetalhes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"CPF: {Cpf}");
            sb.AppendLine($"Idade: {Idade}");
            sb.AppendLine("Livros em posse:");
            if (LivrosEmPosse.Any())
            {
                foreach (var livro in LivrosEmPosse)
                {
                    sb.AppendLine($"  - {livro.ExibirDetalhes()}");
                }
            }
            else
            {
                sb.AppendLine("  Nenhum livro.");
            }
            return sb.ToString();
        }

        public void AdicionarLivro(Livro livro)
        {
            LivrosEmPosse.Add(livro);
        }

        public bool RemoverLivro(string isbn)
        {
            var livroParaRemover = LivrosEmPosse.FirstOrDefault(l => l.Isbn == isbn);
            if (livroParaRemover != null)
            {
                LivrosEmPosse.Remove(livroParaRemover);
                return true;
            }
            return false;
        }

        public Livro? BuscarLivroPorIsbn(string isbn) // Retorno agora é Livro? para indicar que pode ser nulo
        {
            return LivrosEmPosse.FirstOrDefault(l => l.Isbn == isbn);
        }
    }
}
