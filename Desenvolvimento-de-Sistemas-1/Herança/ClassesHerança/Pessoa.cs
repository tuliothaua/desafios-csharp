namespace ClassesHerança;
// Túlio Thauã Dutra
public abstract class Pessoa(string nome = "", string cpf = "", string rg = "", string idade = "0", DateOnly nascimento = default, Logradouro? endereco = null, string numero = "", string complemento = "")
{
    public string Nome { get; set; } = nome;
    public string Cpf { get; set; } = cpf;
    public string Rg { get; set; } = rg;

    public string Idade {get; set;} = idade;
    public DateOnly Nascimento { get; set; } = nascimento;
    public Logradouro Endereco { get; set; } = endereco ?? new Logradouro();
    public string Numero { get; set; } = numero;
    public string Complemento { get; set; } = complemento;

    // método abstrato, não tem implementação, deve ser implementado nas classes derivadas
    public abstract List<(string campo, string valor)> RetornarDados();
}
