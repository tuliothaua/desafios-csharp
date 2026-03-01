internal class Program
{
    private static void Main(string[] args)
    {   
        var aluno = "Túlio";
        var nota1 = 7.5; 
        var nota2 = 8.0;
        var nota3 = 6.0;
        var nota4 = 9.0;
        var media = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine($"Aluno: {aluno}");
        Console.WriteLine($"A média das notas é: {media}");
    }
}