using ClassesHerança;

//Túlio Thauã Dutra
internal class Program
{
    // lista para armazenar objetos do tipo Pessoa, que é a classe base de Aluno e Professor
    List<Pessoa> pessoas = new List<Pessoa>();
    public Program()
    {
        Curso auxCurso1 = new Curso();
        auxCurso1.Nome = "Sistemas de Informação";
        auxCurso1.Codigo = "Código 1";
        auxCurso1.CargaHoraria = 1000;
        auxCurso1.Descricao = "Descrição 1";

        Curso auxCurso2 = new Curso("Curso 2", "Código 2", 2145, "Descrição 2");

        Aluno auxAluno1 = new Aluno("Túlio Thauã Dutra", "123", "456", 19, new DateTime(2000,05,22), new Logradouro("Rua 1", "rua", "Bairro 1", "Cidade 1", "Estado 1", "12345-678"), "123", "casa", "9080", auxCurso1);

        Aluno auxAluno2 = new Aluno("Aluno 2", "789", "101", 20, new DateTime(2003, 05, 15), new Logradouro("Avenida 2", "avenida", "Bairro 2", "Cidade 2", "Estado 2", "12345-678"), "456", "apartamento", "9081", auxCurso1);

        Aluno auxAluno3 = new Aluno("Aluno 3", "325", "748", 22, new DateTime(2003,05,4), new Logradouro("Rua 4", "rua", "Bairro 4", "Cidade 4", "Estado 4", "12345-678"), "456", "casa", "9082", auxCurso2);

        Logradouro auxEnd = new Logradouro("Rua 3", "rua", "Bairro 3", "Cidade 3", "Estado 3", "12345-678");

        Professor auxProfessor1 = new Professor("Professor 1", "123", "456", 29, new DateTime(1980,11,11), new Logradouro("RUA 0, ", "tiPO 0", "bairro 0", "cidade 0", "estado 0", "00000"), "10", "casa", "98125", 1000, "Tecnologia", "Bacharelado");

        Professor auxProfessor2 = new Professor("Professor 2", "789", "101", 45, new DateTime(1980,11,10), new Logradouro("Rua 4","O", "Bairro 4", "Cidade 4", "Estado 4", "12345-678"), "25", "casa", "98745", 5950, "Tecnolgia", "Mestre");

        Coordenador auxCoordenador = new Coordenador("Coordenador 1", "333", "22", 48, new DateTime(1989,05,01), new Logradouro("Rua 5", "rua", "Bairro 5", "Cidade 5", "Estado 5", "898989-009"), "388", "complemento","8989", 4000, "Desenvolvedor", "AbcBolinhas");

        Pessoa auxPessoa = new Pessoa("Pessoa ex", "222", "900", 78, new DateTime(2000,11,10), new Logradouro("Rua 9", "rua", "Bairro 9", "ciadade 9", "estado 9", "9302930"), "390", "casa");

        TecnicoAdministrativo auxTecnico1 = new TecnicoAdministrativo("tecnico 1", "444", "76", 22, new DateTime(1999,05,19), new Logradouro("Rua 6", "rua", "Bairro 6", "cidade 6", "estado 6", "3939"), "333", "complemento 6", "8989", 3000, "Desenvolvedor");

        TecnicoAdministrativo auxTecnico2 = new TecnicoAdministrativo("Tecnico 2", "555", "9090", 99, new DateTime(1989,11,01), new Logradouro("Rua 7", "rua", "Bairro 7", "Cidade 7", "Estado 7", "89889"), "999", "Complementar", "8765", 2000, "Tecnico de Gestão");     
        //adicionar alunos e professores na lista de pessoas, que é do tipo Pessoa, ou seja, pode armazenar objetos do tipo Aluno e Professor, pois ambos herdam de Pessoa
        pessoas.Add(auxAluno1);
        pessoas.Add(auxAluno2);
        pessoas.Add(auxAluno3);
        pessoas.Add(auxProfessor1);
        pessoas.Add(auxProfessor2);
        pessoas.Add(auxCoordenador);
        pessoas.Add(auxPessoa);
        pessoas.Add(auxTecnico1);
        pessoas.Add(auxTecnico2);
        // listar todo o conteúdo do list mostrando todos os dados e os dados específicos de cada classe
        // como o list é do tipo Pessoa, para acessar os dados específicos de cada classe, precisamos verificar o tipo do objeto e fazer um cast para o tipo correto, ou seja, Aluno ou Professor
        foreach (var item in pessoas)
        {
            // Dados que TODO MUNDO tem (pois todos herdam de Pessoa)
            Console.WriteLine($"Tipo: {item.GetType().Name}");
            Console.WriteLine($"Nome: {item.Nome} | CPF: {item.Cpf}");

            // Agora os dados específicos de cada um
            if (item is Aluno aluno)
            {
                Console.WriteLine($"Matrícula: {aluno.Matricula} | Curso: {auxAluno1.Curso}");
            }
            else if (item is Coordenador coord)
            {
                Console.WriteLine($"Matrícula: {coord.Matricula} | Senha: {coord.senhaAlarme}");
            }
            else if (item is TecnicoAdministrativo tecnico)
            {
                Console.WriteLine($"Matrícula: {tecnico.Matricula} | Função: {tecnico.Funcao}");
            }
            else if (item is Professor prof)
            {
                Console.WriteLine($"Matrícula: {prof.Matricula} | Área: {prof.AreaAtuacao} | Titulação: {prof.Titulacao}");
            }
            else if (item is Funcionario func)
            {
                Console.WriteLine($"Matrícula: {func.Matricula} | Salário: {func.Salario:C}");
            }

            Console.WriteLine("--------------------------------------------------");
        }
    }
    private static void Main(string[] args) => _ = new Program();
}