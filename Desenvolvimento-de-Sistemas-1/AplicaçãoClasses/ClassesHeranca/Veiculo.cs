namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public abstract class Veiculo(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "") 
{
    public string Marca {get; set;} = marca;
    public string Modelo {get; set;} = modelo;
    public string Ano {get; set;} = ano;
    public string Cor {get; set;} = cor;

    public string Placa {get; set;} = placa;

    public abstract List<(string campo, string valor)> RetornarDados();
}
