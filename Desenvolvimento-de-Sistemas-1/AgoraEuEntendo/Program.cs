internal class Program
{
    private static void Main(string[] args)
    { // Túlio Thauã Dutra :D
        Console.WriteLine("Digite um valor para byte: ");
        byte n1 = byte.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite um valor para short: ");
        short n2 = short.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite um valor para int: ");
        int n3 =  int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite um valor para long: ");
        long n4 = long.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite um valor para float: ");
        float n5 = float.Parse(Console.ReadLine()!);

        double total = n1+n2+n3+n4+n5;
        decimal media = (decimal)total / 5;
        int parteInt = (int)media;
        char caractere = (char)parteInt;

        Console.WriteLine($"Soma: {total} -  Média: {media} - Parte Inteira: {parteInt} - Caráctere: {caractere}");


    }
}