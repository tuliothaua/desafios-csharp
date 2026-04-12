namespace ClassesHerança;

public class Funcionario : Pessoa
{
    public string Matricula { get; set; }
    public decimal Salario { get; set; }


    public Funcionario(string nome = "", string cpf = "", string rg = "", int idade = 0, DateTime nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0) : base(nome, cpf, rg, idade, nascimento, endereco, numero, complemento)
    {
        Matricula = matricula;
        Salario = salario;
    }
}