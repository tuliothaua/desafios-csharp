internal class Program
{
    private static void Main(string[] args)
    {
        int nota1, nota2, nota3, nota4;
        decimal media;

        Console.WriteLine("Nome do Aluno:");
        string nome = Console.ReadLine();

        Console.WriteLine("Nota 1:");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nota 2:");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nota 3:");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Nota 4:");
        nota4 = int.Parse(Console.ReadLine());

        media = (decimal)(nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine($"A média do aluno {nome} é: {media}");
    }
}