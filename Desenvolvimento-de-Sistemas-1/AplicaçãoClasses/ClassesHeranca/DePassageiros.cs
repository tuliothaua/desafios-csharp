namespace ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro
public abstract class DePassageiros : Veiculo
{
   public int capacidadePassageiros {get; set;}
   public string Categoria {get; set;}
   public Boolean possuiCinto {get; set;}

   public DePassageiros(string marca = "", string modelo = "", string ano = "", string cor = "", string placa = "", int capacidadepassageiros = 0, string categoria = "", Boolean possuicinto = false) : base (marca,modelo,ano,cor,placa)
    {
        capacidadePassageiros = capacidadepassageiros;
        Categoria = categoria;
        possuiCinto = possuicinto;
    }
}
