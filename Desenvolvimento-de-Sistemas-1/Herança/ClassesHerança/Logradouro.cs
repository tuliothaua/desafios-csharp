namespace ClassesHerança;
//Túlio Thauã Dutra
public class Logradouro
{
    public string Nome {get; set;}
    public string Tipo {get; set;}
    public string Bairro {get; set;}
    public string Cidade {get; set;}
    public string Estado {get; set;}
    public string CEP {get; set;}

    public Logradouro(string nome = "", string tipo = "", string bairro = "", string cidade = "", string estado = "", string cep = "")
    {
        Nome = nome;
        Tipo = tipo;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;
    }
}
