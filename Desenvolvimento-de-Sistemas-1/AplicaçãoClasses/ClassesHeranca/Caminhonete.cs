namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Caminhonete : DeCarga
{
    public string TipoCacamba { get; set; }
    public Boolean Tracao4x4 { get; set; }

    public Caminhonete(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", string tipocacamba = "", Boolean tracao4x4 = false) : base(marca, modelo, ano, cor, placa)
    {
       TipoCacamba = tipocacamba;
       Tracao4x4 = tracao4x4;
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
        ("Tipo Caçamba: ", TipoCacamba),
        ("Tração 4x4: : ", Tracao4x4.ToString()),
        };
    }
}
