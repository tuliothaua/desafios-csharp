using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        (string Nome, int Idade) pessoa = ("Túlio Thauã Dutra", 18);
        Console.WriteLine($"{pessoa.Nome}, você tem {pessoa.Idade} anos.");
    }
}