namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public abstract class DeMisto : Veiculo
{
    public int capacidadePassageiros { get; set; }
    public double capacidadeCarga { get; set; }
    public string tipoUso { get; set; }

    public DeMisto(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", int capacidadepassageiros = 0, double capacidadecarga = 0, string tipouso = "") : base(marca, modelo, ano, cor, placa)
    {
        this.capacidadePassageiros = capacidadepassageiros;
        this.capacidadeCarga = capacidadecarga;
        tipoUso = tipouso;   
    }
}
