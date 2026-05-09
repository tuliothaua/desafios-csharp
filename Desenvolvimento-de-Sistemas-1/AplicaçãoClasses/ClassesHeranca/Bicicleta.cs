namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public class Bicicleta : DePassageiros
{ //Herança
    public int numeroMarchas { get; set; }
    public string tipoQuadro { get; set; }
    public Boolean temCastinha { get; set; } //Encapsulamento

    public Bicicleta(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", int numeromarchas = 0, string tipoquadro= "", Boolean temcastinha = false) : base(marca, modelo, ano, cor, placa)
    {
        numeroMarchas = numeromarchas;
        tipoQuadro = tipoquadro;
        temCastinha = temcastinha;
    }

    public override List<(string campo, string valor)> RetornarDados()
    { //Polimorfismo
        return new List<(string campo, string valor)>
        {
        ("Marca: ", Marca),
        ("Modelo: ", Modelo),
        ("Ano: ", Ano),
        ("Cor: ", Cor),
        ("Placa: ", Placa),
        ("Numero Marchas: ", numeroMarchas.ToString()),
        ("Tipo Quadro: ", tipoQuadro),
        ("Tem Castinha: ", temCastinha.ToString())
        };
    }
}
