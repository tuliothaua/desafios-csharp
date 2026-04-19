namespace ClassesHerança;
//Túlio Thauã Dutra
public class TecnicoAdministrativo : Funcionario // herança, TecnicoAdmistrativo é uma subclasse de Funcionario que é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string Funcao { get; set; }
    // construtor com parâmetros opcionais e uso de construtor da classe base
    public TecnicoAdministrativo(string nome = "", string cpf = "", string rg = "", string idade = "0", DateOnly nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario =
    0, string funcao = "") : base(nome, cpf, rg, idade, nascimento, endereco, numero, complemento, matricula, salario)
    {
        // os atributos da classe base são herdados e inicializados pelo construtor da classe base
        // atributos específicos da classe derivada
        Funcao = funcao;
    }
    // implementa membro abstrato herdado "Pessoa.RetornarDados()
    public override List<(string campo, string valor)> RetornarDados()
    {
        // cria uma lista de tuplas com os dados do aluno,
        // utilizando variável temporária embutida para criar a lista de tuplas
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome),
            ("Cpf", Cpf),
            ("Rg", Rg),
            ("Idade", Idade),
            ("Nascimento", Nascimento.ToString("dd/MM/yyyy")),
            ("Endereço Nome", Endereco.Nome),
            ("Endereço Tipo", Endereco.Tipo),
            ("Endereço Bairro", Endereco.Bairro),
            ("Endereço Cidade", Endereco.Cidade),
            ("Endereço Estado", Endereco.Estado),
            ("Endereço Cep", Endereco.CEP.ToString()),
            ("Numero", Numero),
            ("Complemento", Complemento),
            ("Matricula", Matricula),
            ("Salário", Salario.ToString("C")),
            ("Função", Funcao)
        };
    }
}
