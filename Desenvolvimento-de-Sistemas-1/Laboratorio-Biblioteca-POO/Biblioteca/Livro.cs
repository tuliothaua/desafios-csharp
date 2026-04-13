// Alunos: Túlio Thauã Dutra e José Pedro
using System;
using System.Text;

namespace Biblioteca
{
    public class Livro
    {
        // ISBN deve ser imutável após a criação e definido no construtor
        public string Isbn { get; init; }

        private string _titulo = string.Empty; // Inicializado para evitar CS8618
        public string Titulo
        {
            get => _titulo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Título não pode ser nulo ou vazio.");
                }
                _titulo = value.Trim();
            }
        }

        private string _subtitulo = string.Empty; // Inicializado para evitar CS8618
        public string Subtitulo
        {
            get => _subtitulo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Subtítulo não pode ser nulo ou vazio.");
                }
                _subtitulo = value.Trim();
            }
        }

        private string _escritor = string.Empty; // Inicializado para evitar CS8618
        public string Escritor
        {
            get => _escritor;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Escritor não pode ser nulo ou vazio.");
                }
                _escritor = value.Trim();
            }
        }

        private string _editora = string.Empty; // Inicializado para evitar CS8618
        public string Editora
        {
            get => _editora;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Editora não pode ser nula ou vazia.");
                }
                _editora = value.Trim();
            }
        }

        private string _genero = string.Empty; // Inicializado para evitar CS8618
        public string Genero
        {
            get => _genero;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gênero não pode ser nulo ou vazio.");
                }
                _genero = value.Trim();
            }
        }

        private int _anoPublicacao;
        public int AnoPublicacao
        {
            get => _anoPublicacao;
            set
            {
                int anoAtual = DateTime.Now.Year;
                if (value < 1970 || value > anoAtual)
                {
                    throw new ArgumentOutOfRangeException($"Ano de Publicação deve estar entre 1970 e {anoAtual}.");
                }
                _anoPublicacao = value;
            }
        }

        private string _tipoDaCapa = string.Empty; // Inicializado para evitar CS8618
        public string TipoDaCapa
        {
            get => _tipoDaCapa;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tipo da Capa não pode ser nulo ou vazio.");
                }
                _tipoDaCapa = value.Trim();
            }
        }

        private int _numeroDePaginas;
        public int NumeroDePaginas
        {
            get => _numeroDePaginas;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Número de Páginas deve ser maior que zero.");
                }
                _numeroDePaginas = value;
            }
        }

        public Livro(string isbn, string titulo, string subtitulo, string escritor, string editora, string genero, int anoPublicacao, string tipoDaCapa, int numeroDePaginas)
        {
            // Chamamos os setters para aplicar as validações
            // O init setter já garante que o valor seja trimado e não nulo/vazio para ISBN
            Isbn = isbn.Trim(); 
            Titulo = titulo;
            Subtitulo = subtitulo;
            Escritor = escritor;
            Editora = editora;
            Genero = genero;
            AnoPublicacao = anoPublicacao;
            TipoDaCapa = tipoDaCapa;
            NumeroDePaginas = numeroDePaginas;
        }

        public string ExibirDetalhes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ISBN: {Isbn}");
            sb.AppendLine($"Título: {Titulo}");
            sb.AppendLine($"Subtítulo: {Subtitulo}");
            sb.AppendLine($"Escritor: {Escritor}");
            sb.AppendLine($"Editora: {Editora}");
            sb.AppendLine($"Gênero: {Genero}");
            sb.AppendLine($"Ano Publicação: {AnoPublicacao}");
            sb.AppendLine($"Tipo da Capa: {TipoDaCapa}");
            sb.AppendLine($"Número de Páginas: {NumeroDePaginas}");
            return sb.ToString();
        }
    }
}
