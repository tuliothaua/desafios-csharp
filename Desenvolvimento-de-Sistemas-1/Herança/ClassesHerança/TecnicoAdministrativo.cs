namespace ClassesHerança;
//Túlio Thauã Dutra
public class TecnicoAdministrativo : Funcionario
{
    public string Funcao {get; set;}

    public TecnicoAdministrativo(string nome = "", string cpf = "", string rg = "", int idade = 0, DateTime nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "", string matricula = "", decimal salario = 0, string funcao = "") : base(nome, cpf, rg, idade, nascimento, endereco!, numero, complemento, matricula, salario)
    {
        Funcao = funcao;
    }
}