namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public abstract class DeCarga : Veiculo
{
    public double capacidadeCarga { get; set; }
    public double volumeMaximo { get; set; }
    public string tipoCarroceria { get; set; }

    public DeCarga(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", double capacidadecarga = 0, double volumemaximo = 0, string tipocarroceria = "") : base(marca, modelo, ano, cor, placa)
    {
        capacidadeCarga = capacidadecarga;
        volumeMaximo = volumemaximo;
        tipoCarroceria = tipocarroceria;
    }
}
