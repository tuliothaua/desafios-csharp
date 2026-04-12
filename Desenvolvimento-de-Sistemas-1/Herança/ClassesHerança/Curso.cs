namespace ClassesHerança;
//Túlio Thauã Dutra
public class Curso 
{
    public string Nome {get; set;}
    public string Codigo {get; set;}
    public int CargaHoraria {get; set;}
    public string Descricao {get; set;}

    public Curso(string nome = "", string codigo = "", int cargaHoraria = 0, string descricao = "")
    {
        Nome = nome;
        Codigo = codigo;
        CargaHoraria = cargaHoraria;
        Descricao = descricao;
    }
}