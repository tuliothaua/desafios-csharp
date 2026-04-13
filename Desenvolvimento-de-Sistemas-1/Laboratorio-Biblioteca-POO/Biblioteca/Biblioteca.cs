// Alunos: Túlio Thauã Dutra e José Pedro
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Biblioteca
    {
        public static List<Leitor> Leitores { get; private set; } = new List<Leitor>();

        // --- Operações CRUD para Leitores ---

        public void CadastrarLeitor(string nome, string cpf, int idade)
        {
            if (Leitores.Any(l => l.Cpf == cpf))
            {
                throw new InvalidOperationException($"Leitor com CPF \'{cpf}\' já cadastrado.");
            }

            // As validações de nome, cpf e idade são feitas no construtor de Leitor
            Leitor novoLeitor = new Leitor(nome, cpf, idade);
            Leitores.Add(novoLeitor);
        }

        public List<Leitor> ObterTodosLeitores()
        {
            return Leitores;
        }

        public Leitor? BuscarLeitorPorCpf(string cpf) // Retorno agora é Leitor? para indicar que pode ser nulo
        {
            return Leitores.FirstOrDefault(l => l.Cpf == cpf);
        }

        public void EditarLeitor(string cpf, string novoNome, int novaIdade)
        {
            Leitor? leitor = BuscarLeitorPorCpf(cpf); // Usar Leitor? aqui também
            if (leitor == null)
            {
                throw new InvalidOperationException($"Leitor com CPF \'{cpf}\' não encontrado.");
            }

            // As validações de nome e idade são feitas nos setters de Leitor
            leitor.Nome = novoNome;
            leitor.Idade = novaIdade;
        }

        public void ExcluirLeitor(string cpf)
        {
            Leitor? leitor = BuscarLeitorPorCpf(cpf); // Usar Leitor? aqui também
            if (leitor == null)
            {
                throw new InvalidOperationException($"Leitor com CPF \'{cpf}\' não encontrado.");
            }

            Leitores.Remove(leitor);
        }

        // --- Operações de Gerenciamento de Livros ---

        public void IncluirLivroLeitor(string cpfLeitor, string isbn, string titulo, string subtitulo, string escritor, string editora, string genero, int anoPublicacao, string tipoDaCapa, int numeroDePaginas)
        {
            Leitor? leitor = BuscarLeitorPorCpf(cpfLeitor); // Usar Leitor? aqui também
            if (leitor == null)
            {
                throw new InvalidOperationException($"Leitor com CPF \'{cpfLeitor}\' não encontrado.");
            }

            if (leitor.BuscarLivroPorIsbn(isbn) != null)
            {
                throw new InvalidOperationException($"Livro com ISBN \'{isbn}\' já está em posse do leitor \'{leitor.Nome}\'");
            }

            // As validações do livro são feitas no construtor de Livro
            Livro novoLivro = new Livro(isbn, titulo, subtitulo, escritor, editora, genero, anoPublicacao, tipoDaCapa, numeroDePaginas);
            leitor.AdicionarLivro(novoLivro);
        }

        public void EditarLivroEspecificoLeitor(string cpfLeitor, string isbnAntigo, string novoTitulo, string novoSubtitulo, string novoEscritor, string novaEditora, string novoGenero, int novoAnoPublicacao, string novoTipoDaCapa, int novoNumeroDePaginas)
        {
            Leitor? leitor = BuscarLeitorPorCpf(cpfLeitor); // Usar Leitor? aqui também
            if (leitor == null)
            {
                throw new InvalidOperationException($"Leitor com CPF \'{cpfLeitor}\' não encontrado.");
            }

            Livro? livro = leitor.BuscarLivroPorIsbn(isbnAntigo); // Usar Livro? aqui também
            if (livro == null)
            {
                throw new InvalidOperationException($"Livro com ISBN \'{isbnAntigo}\' não encontrado em posse do leitor \'{leitor.Nome}\'");
            }

            // ISBN é init-only, não pode ser alterado após a criação do objeto.
            // As validações das propriedades do livro são feitas nos setters de Livro
            livro.Titulo = novoTitulo;
            livro.Subtitulo = novoSubtitulo;
            livro.Escritor = novoEscritor;
            livro.Editora = novaEditora;
            livro.Genero = novoGenero;
            livro.AnoPublicacao = novoAnoPublicacao;
            livro.TipoDaCapa = novoTipoDaCapa;
            livro.NumeroDePaginas = novoNumeroDePaginas;
        }

        public void RemoverLivroLeitor(string cpfLeitor, string isbn)
        {
            Leitor? leitor = BuscarLeitorPorCpf(cpfLeitor); // Usar Leitor? aqui também
            if (leitor == null)
            {
                throw new InvalidOperationException($"Leitor com CPF \'{cpfLeitor}\' não encontrado.");
            }

            if (!leitor.RemoverLivro(isbn))
            {
                throw new InvalidOperationException($"Livro com ISBN \'{isbn}\' não encontrado em posse do leitor \'{leitor.Nome}\'");
            }
        }

        public void DoarLivro(string cpfDoador, string isbnDoacao, string cpfRecebedor)
        {
            Leitor? doador = BuscarLeitorPorCpf(cpfDoador); // Usar Leitor? aqui também
            if (doador == null)
            {
                throw new InvalidOperationException($"Leitor doador com CPF \'{cpfDoador}\' não encontrado.");
            }

            Livro? livroDoado = doador.BuscarLivroPorIsbn(isbnDoacao); // Usar Livro? aqui também
            if (livroDoado == null)
            {
                throw new InvalidOperationException($"Livro com ISBN \'{isbnDoacao}\' não encontrado em posse do doador \'{doador.Nome}\'");
            }

            Leitor? recebedor = BuscarLeitorPorCpf(cpfRecebedor); // Usar Leitor? aqui também
            if (recebedor == null)
            {
                throw new InvalidOperationException($"Leitor recebedor com CPF \'{cpfRecebedor}\' não encontrado.");
            }

            if (recebedor.BuscarLivroPorIsbn(livroDoado.Isbn) != null)
            {
                throw new InvalidOperationException($"Livro com ISBN \'{livroDoado.Isbn}\' já está em posse do recebedor \'{recebedor.Nome}\'");
            }

            doador.RemoverLivro(isbnDoacao);
            recebedor.AdicionarLivro(livroDoado);
        }

        public Leitor? PesquisarLivro(string isbnPesquisa) // Retorno agora é Leitor? para indicar que pode ser nulo
        {
            foreach (var leitor in Leitores)
            {
                Livro? livro = leitor.BuscarLivroPorIsbn(isbnPesquisa); // Usar Livro? aqui também
                if (livro != null)
                {
                    return leitor; // Retorna o leitor que possui o livro
                }
            }
            return null; // Livro não encontrado em posse de nenhum leitor
        }
    }
}
