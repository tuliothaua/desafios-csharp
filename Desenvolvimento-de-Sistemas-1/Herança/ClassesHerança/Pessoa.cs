namespace ClassesHerança;
//Túlio Thauã Dutra
public class Pessoa : Object
{
    public string Nome {get; set;}
    public string Cpf {get; set;}
    public string Rg {get; set;}
    public int Idade {get; set;}
    public DateTime Nascimento {get; set;}
    public Logradouro? Endereco {get; set;}
    public string Numero {get; set;}
    public string Complemento {get; set;}

    public Pessoa(string nome = "", string cpf = "", string rg = "", int idade = 0, DateTime nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "")
    {
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Idade = idade;
        if(nascimento > DateTime.Now)
        {
            throw new ArgumentException("A data nao pode ser futuro");
        }

        Nascimento = nascimento;
        Endereco = endereco;
        Numero = numero;
        Complemento = complemento;
    }
}