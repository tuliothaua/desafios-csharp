namespace ClassesHerança;

public abstract class Funcionario : Pessoa
{
    public string Matricula { get; set; }
    public decimal Salario { get; set; }


    public  Funcionario(string nome = "", string cpf = "", string rg = "", string idade = "0", DateOnly nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0) : base(nome, cpf, rg, idade, nascimento, endereco, numero, complemento)
    {
        Matricula = matricula;
        Salario = salario;
    }

    public override List<(string campo, string valor)> RetornarDados()
    {
        return new List<(string campo, string valor)>
        {
          ("Nome", Nome),
          ("CPF", Cpf),
          ("Rg", Rg),
          ("Idade", Idade),
          ("Nascimento", Nascimento.ToString("dd/MM/yyyy")),
          ("Endereço Nome", Endereco.Nome),
          ("Endereço Tipo", Endereco.Tipo),
          ("Endereço Bairro", Endereco.Bairro),
          ("Endereço Cidade", Endereco.Cidade),
          ("Endereço Estado", Endereco.Estado),
          ("Endereço Cep", Endereco.CEP),
          ("Numero", Numero),
          ("Complemento", Complemento),
          ("Matricula", Matricula),
          ("Salário", Salario.ToString("C")),
        };
    }
}
