namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Automovel : DePassageiros
{
    public int qntdDePortas { get; set; }
    public string Combustivel { get; set; }

    public Automovel(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", int qntddeportas = 0, string combustivel = "") : base(marca, modelo, ano, cor, placa)
    {
        qntdDePortas = qntddeportas;
        Combustivel = combustivel;
    }

    public override List<(string campo, string valor)> RetornarDados()
    {
        return new List<(string campo, string valor)>
        {
        ("Marca: ", Marca),
        ("Modelo: ", Modelo),
        ("Ano: ", Ano),
        ("Cor: ", Cor),
        ("Placa: ", Placa),
        ("Qntd de Portas: ", qntdDePortas.ToString()),
        ("Combustivel: ", Combustivel),
        };
    }
}

