namespace ClassesHerança;
//Túlio Thauã Dutra
public class Coordenador : Funcionario
{
    public string senhaAlarme {get; set;}

    public Coordenador(string nome = "", string cpf = "", string rg = "", int idade = 0, DateTime nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0, string areaAtuacao = "", string senhaalarme = "") : base(nome, cpf, rg, idade, nascimento, endereco!, numero, complemento, matricula, salario)
    {
        senhaAlarme = senhaalarme;
    }
}