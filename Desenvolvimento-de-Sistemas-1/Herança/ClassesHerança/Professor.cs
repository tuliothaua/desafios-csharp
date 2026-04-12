namespace ClassesHerança;
//Túlio Thauã Dutra
public class Professor : Funcionario
{
    public string AreaAtuacao { get; set; }

    public string Titulacao {get; set;}

    public Professor(string nome = "", string cpf = "", string rg = "", int idade = 0, DateTime nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0, string areaAtuacao = "", string titulacao = ""): base(nome, cpf, rg, idade, nascimento, endereco!, numero, complemento, matricula, salario)
    {   
        AreaAtuacao = areaAtuacao;
        Titulacao = titulacao;
    }
}