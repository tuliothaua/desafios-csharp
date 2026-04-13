// Alunos: Túlio Thauã Dutra e José Pedro
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    public class Program
    {
        static Biblioteca minhaBiblioteca = new Biblioteca();

        static void Main(string[] args)
        {
            Console.WriteLine("\n--- Sistema de Gerenciamento de Biblioteca ---\n");

            while (true)
            {
                ExibirMenu();
                string opcao = Console.ReadLine()!;

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            CadastrarLeitor();
                            break;
                        case "2":
                            ListarTodosLeitores();
                            break;
                        case "3":
                            BuscarLeitorPorCpf();
                            break;
                        case "4":
                            EditarLeitor();
                            break;
                        case "5":
                            ExcluirLeitor();
                            break;
                        case "6":
                            IncluirLivroParaLeitor();
                            break;
                        case "7":
                            EditarLivroEspecificoDoLeitor();
                            break;
                        case "8":
                            RemoverLivroDoLeitor();
                            break;
                        case "9":
                            DoarLivroEntreLeitores();
                            break;
                        case "10":
                            PesquisarLivroPorIsbn();
                            break;
                        case "0":
                            Console.WriteLine("Saindo da aplicação. Até mais!");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                // Exceções mais específicas primeiro
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Erro de valor: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Erro de validação: {ex.Message}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Erro de operação: {ex.Message}");
                }
                // Exceção genérica por último
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n--- Menu da Biblioteca ---");
            Console.WriteLine("1. Cadastrar Leitor");
            Console.WriteLine("2. Listar Todos os Leitores");
            Console.WriteLine("3. Buscar Leitor por CPF");
            Console.WriteLine("4. Editar Leitor");
            Console.WriteLine("5. Excluir Leitor");
            Console.WriteLine("6. Incluir Livro para Leitor");
            Console.WriteLine("7. Editar Livro Específico do Leitor");
            Console.WriteLine("8. Remover Livro do Leitor");
            Console.WriteLine("9. Doar Livro");
            Console.WriteLine("10. Pesquisar Livro por ISBN");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
        }

        static void CadastrarLeitor()
        {
            Console.Write("Nome do Leitor: ");
            string nomeLeitor = Console.ReadLine()!;
            Console.Write("CPF do Leitor: ");
            string cpfLeitor = Console.ReadLine()!;
            Console.Write("Idade do Leitor: ");
            int idadeLeitor;
            while (!int.TryParse(Console.ReadLine(), out idadeLeitor))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para a idade.");
                Console.Write("Idade do Leitor: ");
            }
            minhaBiblioteca.CadastrarLeitor(nomeLeitor, cpfLeitor, idadeLeitor);
            Console.WriteLine($"Leitor \'{nomeLeitor}\' cadastrado com sucesso!");
        }

        static void ListarTodosLeitores()
        {
            List<Leitor> leitores = minhaBiblioteca.ObterTodosLeitores();
            if (!leitores.Any())
            {
                Console.WriteLine("Nenhum leitor cadastrado.");
                return;
            }

            Console.WriteLine("\n--- Lista de Leitores ---");
            foreach (var leitor in leitores)
            {
                Console.WriteLine(leitor.ExibirDetalhes());
                Console.WriteLine("--------------------------");
            }
        }

        static void BuscarLeitorPorCpf()
        {
            Console.Write("CPF do Leitor a buscar: ");
            string cpfBusca = Console.ReadLine()!;
            Leitor? leitorEncontrado = minhaBiblioteca.BuscarLeitorPorCpf(cpfBusca);
            if (leitorEncontrado != null)
            {
                Console.WriteLine("\n--- Detalhes do Leitor ---");
                Console.WriteLine(leitorEncontrado.ExibirDetalhes());
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine($"Leitor com CPF \'{cpfBusca}\' não encontrado.");
            }
        }

        static void EditarLeitor()
        {
            Console.Write("CPF do Leitor a editar: ");
            string cpfEditar = Console.ReadLine()!;
            Console.Write("Novo Nome do Leitor: ");
            string novoNome = Console.ReadLine()!;
            Console.Write("Nova Idade do Leitor: ");
            int novaIdade;
            while (!int.TryParse(Console.ReadLine(), out novaIdade))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para a idade.");
                Console.Write("Nova Idade do Leitor: ");
            }
            minhaBiblioteca.EditarLeitor(cpfEditar, novoNome, novaIdade);
            Console.WriteLine($"Leitor com CPF \'{cpfEditar}\' atualizado para nome: \'{novoNome}\' e idade: {novaIdade}.");
        }

        static void ExcluirLeitor()
        {
            Console.Write("CPF do Leitor a excluir: ");
            string cpfExcluir = Console.ReadLine()!;
            minhaBiblioteca.ExcluirLeitor(cpfExcluir);
            Console.WriteLine($"Leitor com CPF \'{cpfExcluir}\' excluído com sucesso!");
        }

        static void IncluirLivroParaLeitor()
        {
            Console.Write("CPF do Leitor para adicionar livro: ");
            string cpfLeitorLivro = Console.ReadLine()!;
            Console.Write("ISBN do Livro: ");
            string isbnLivro = Console.ReadLine()!;
            Console.Write("Título do Livro: ");
            string tituloLivro = Console.ReadLine()!;
            Console.Write("Subtítulo do Livro: ");
            string subtituloLivro = Console.ReadLine()!;
            Console.Write("Escritor do Livro: ");
            string escritorLivro = Console.ReadLine()!;
            Console.Write("Editora do Livro: ");
            string editoraLivro = Console.ReadLine()!;
            Console.Write("Gênero do Livro: ");
            string generoLivro = Console.ReadLine()!;
            Console.Write("Ano de Publicação do Livro: ");
            int anoPublicacaoLivro;
            while (!int.TryParse(Console.ReadLine(), out anoPublicacaoLivro))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o ano.");
                Console.Write("Ano de Publicação do Livro: ");
            }
            Console.Write("Tipo da Capa do Livro: ");
            string tipoCapaLivro = Console.ReadLine()!;
            Console.Write("Número de Páginas do Livro: ");
            int numeroPaginasLivro;
            while (!int.TryParse(Console.ReadLine(), out numeroPaginasLivro))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o número de páginas.");
                Console.Write("Número de Páginas do Livro: ");
            }
            minhaBiblioteca.IncluirLivroLeitor(cpfLeitorLivro, isbnLivro, tituloLivro, subtituloLivro, escritorLivro, editoraLivro, generoLivro, anoPublicacaoLivro, tipoCapaLivro, numeroPaginasLivro);
            Console.WriteLine($"Livro \'{tituloLivro}\' adicionado ao leitor com CPF \'{cpfLeitorLivro}\' com sucesso!");
        }

        static void EditarLivroEspecificoDoLeitor()
        {
            Console.Write("CPF do Leitor dono do livro: ");
            string cpfDonoLivro = Console.ReadLine()!;
            Console.Write("ISBN do Livro a editar: ");
            string isbnAntigo = Console.ReadLine()!;
            Console.Write("Novo Título do Livro: ");
            string novoTitulo = Console.ReadLine()!;
            Console.Write("Novo Subtítulo do Livro: ");
            string novoSubtitulo = Console.ReadLine()!;
            Console.Write("Novo Escritor do Livro: ");
            string novoEscritor = Console.ReadLine()!;
            Console.Write("Nova Editora do Livro: ");
            string novaEditora = Console.ReadLine()!;
            Console.Write("Novo Gênero do Livro: ");
            string novoGenero = Console.ReadLine()!;
            Console.Write("Novo Ano de Publicação do Livro: ");
            int novoAnoPublicacao;
            while (!int.TryParse(Console.ReadLine(), out novoAnoPublicacao))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o ano.");
                Console.Write("Novo Ano de Publicação do Livro: ");
            }
            Console.Write("Novo Tipo da Capa do Livro: ");
            string novoTipoDaCapa = Console.ReadLine()!;
            Console.Write("Novo Número de Páginas do Livro: ");
            int novoNumeroDePaginas;
            while (!int.TryParse(Console.ReadLine(), out novoNumeroDePaginas))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o número de páginas.");
                Console.Write("Novo Número de Páginas do Livro: ");
            }
            minhaBiblioteca.EditarLivroEspecificoLeitor(cpfDonoLivro, isbnAntigo, novoTitulo, novoSubtitulo, novoEscritor, novaEditora, novoGenero, novoAnoPublicacao, novoTipoDaCapa, novoNumeroDePaginas);
            Console.WriteLine($"Livro com ISBN \'{isbnAntigo}\' do leitor com CPF \'{cpfDonoLivro}\' atualizado com sucesso!");
        }

        static void RemoverLivroDoLeitor()
        {
            Console.Write("CPF do Leitor para remover livro: ");
            string cpfLeitorRemoverLivro = Console.ReadLine()!;
            Console.Write("ISBN do Livro a remover: ");
            string isbnRemover = Console.ReadLine()!;
            minhaBiblioteca.RemoverLivroLeitor(cpfLeitorRemoverLivro, isbnRemover);
            Console.WriteLine($"Livro com ISBN \'{isbnRemover}\' removido do leitor com CPF \'{cpfLeitorRemoverLivro}\' com sucesso!");
        }

        static void DoarLivroEntreLeitores()
        {
            Console.Write("CPF do Leitor Doador: ");
            string cpfDoador = Console.ReadLine()!;
            Console.Write("ISBN do Livro a doar: ");
            string isbnDoacao = Console.ReadLine()!;
            Console.Write("CPF do Leitor Recebedor: ");
            string cpfRecebedor = Console.ReadLine()!;
            minhaBiblioteca.DoarLivro(cpfDoador, isbnDoacao, cpfRecebedor);
            Console.WriteLine($"Livro com ISBN \'{isbnDoacao}\' doado de \'{cpfDoador}\' para \'{cpfRecebedor}\' com sucesso!");
        }

        static void PesquisarLivroPorIsbn()
        {
            Console.Write("ISBN do Livro a pesquisar: ");
            string isbnPesquisa = Console.ReadLine()!;
            Leitor? leitorEncontrado = minhaBiblioteca.PesquisarLivro(isbnPesquisa);
            if (leitorEncontrado != null)
            {
                Console.WriteLine($"\n--- Livro com ISBN \'{isbnPesquisa}\' encontrado! ---");
                Console.WriteLine($"Em posse do leitor: {leitorEncontrado.Nome} (CPF: {leitorEncontrado.Cpf})");
                Console.WriteLine("Detalhes do Livro:");
                // Usar o operador ?. para evitar NullReferenceException se BuscarLivroPorIsbn retornar null
                leitorEncontrado.BuscarLivroPorIsbn(isbnPesquisa)?.ExibirDetalhes();
                Console.WriteLine("--------------------------");
            }
            else
            {
                Console.WriteLine($"Livro com ISBN \'{isbnPesquisa}\' não encontrado em posse de nenhum leitor.");
            }
        }
    }
}
