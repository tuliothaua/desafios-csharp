using System;

internal class Program
{ // Túlio Thauã Dutra :D
    static void Main()
    {
        // Chamando o método para ler os 3 valores
        decimal n1 = LerValor();
        decimal n2 = LerValor();
        decimal n3 = LerValor();

        // 1. Calcula a média
        decimal mediaBruta = (n1 + n2 + n3) / 3;

        // 2. Corta para 2 casas decimais sem arredondar (Truque simples)
        // Multiplicamos por 100, transformamos em 'long' para perder o resto, e dividimos por 100
        decimal media = ((long)(mediaBruta * 100)) / 100m;

        // 3. Pega a parte inteira e a parte dos centavos
        int parteInteira = (int)media;
        int centavos = (int)((media - parteInteira) * 100);

        // 4. Mostra os resultados
        Console.WriteLine("Média: " + media);

        // Verifica se é Par ou Ímpar
        if (parteInteira % 2 == 0)
        {
            Console.WriteLine("Parte inteira: Par");
        }
        else
        {
            Console.WriteLine("Parte inteira: Impar");
        }

        // Transforma o número dos centavos em letra (Caractere)
        char letra = (char)centavos;
        Console.WriteLine("Caracter correspondente da parte fracionada: " + letra);
    }

    // Método simples para ler e validar o número
    static decimal LerValor()
    {
        decimal valor;
        Console.WriteLine("Digite um valor decimal:");

        // Enquanto o que o usuário digitar NÃO for um número, ele repete
        while (decimal.TryParse(Console.ReadLine(), out valor) == false)
        {
            Console.WriteLine("Errado! Digite o número novamente:");
        }
        return valor;
    }
}