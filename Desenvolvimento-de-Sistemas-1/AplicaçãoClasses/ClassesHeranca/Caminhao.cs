namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Caminhao : DeCarga
{
    public int QntdEixos { get; set; }
    public double Comprimento { get; set; }

    public Caminhao(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", int qntdeixos = 0, double comprimento = 0) : base(marca, modelo, ano, cor, placa)
    {
        QntdEixos = qntdeixos;
        Comprimento = comprimento;
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
        ("Qntd de Eixos: ", QntdEixos.ToString()),
        ("Comprimento: ", Comprimento.ToString()),
        };
    }
}
