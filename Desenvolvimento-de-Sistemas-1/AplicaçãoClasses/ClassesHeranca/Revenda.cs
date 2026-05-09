using ClassesHeranca;

namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Revenda(string nomerevenda = "", string cnpj = "", Logradouro? endereco = null)
{
    public string NomeRevenda {get; set;} = nomerevenda;
    public string CNPJ {get; set;} = cnpj;
    public Logradouro Endereco { get; set; } = endereco ?? new Logradouro();

    public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();

    public void AdicionarVeiculo(Veiculo v)
    {
        Veiculos.Add(v);
    }

    public List<(string campo, string valor)> RetornarDados()
    {
        return new List<(string campo, string valor)>
        {
        ("Nome", NomeRevenda),
        ("CNPJ", CNPJ),
        ("Endereço Nome", Endereco.NomeLogradouro),
        ("Endereço Tipo", Endereco.Tipo),
        ("Endereço Bairro", Endereco.Bairro),
        ("Endereço Cidade", Endereco.Cidade),
        ("Endereço Estado", Endereco.Estado),
        ("Endereço Cep", Endereco.CEP),
        };
    }
}