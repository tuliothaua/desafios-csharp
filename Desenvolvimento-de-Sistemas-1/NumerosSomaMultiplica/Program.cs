internal class Program
{ // Túlio Thauã Dutra :D
    private static void Main(string[] args)
    {
        float numero1, numero2;
        float soma, resultado;

        Console.WriteLine("Digite o primeiro número:");
        float.TryParse(Console.ReadLine(), out numero1);

        Console.WriteLine("Digite o segundo número:");
        float.TryParse(Console.ReadLine(), out numero2);

        soma = numero1 + numero2;
        resultado = soma * numero1;
        Console.WriteLine($"Resultado final: {resultado}");
    }
}