namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Utilitario : DeMisto
{
    public Boolean tracaoNasQuatro { get; set; }
    public double volumePortaMalas { get; set; }

    public Utilitario(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", Boolean tracaonasquatro = false, double volumeportamalas = 0) : base(marca, modelo, ano, cor, placa)
    {
      tracaoNasQuatro = tracaonasquatro;
      volumePortaMalas = volumeportamalas;
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
        ("Tração nas Quatro: ", tracaoNasQuatro.ToString()),
        ("volume Porta Malas: ", volumePortaMalas.ToString()),
        };
    }
}
