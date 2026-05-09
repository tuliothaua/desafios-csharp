namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Motocicleta : DePassageiros
{
    public int Cilindradas { get; set; }
    public Boolean partidaEletrica { get; set; }
    

    public Motocicleta(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", int cilindradas = 0,Boolean partidaeletrica = false) : base(marca, modelo, ano, cor, placa)
    {
      Cilindradas = cilindradas;
      partidaEletrica = partidaeletrica;
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
        ("Cilindradas: ", Cilindradas.ToString()),
        ("Partida Eletrica: ", partidaEletrica.ToString()),
        };
    }
}
