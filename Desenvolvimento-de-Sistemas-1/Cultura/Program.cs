internal class Program
{
    private static void Main(string[] args)
    {
        // Mostra a cultura do seu sistema 
        System.Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture);
        System.Console.WriteLine(System.Globalization.CultureInfo.CurrentUICulture);

        // O v14 usa o ponto (.) porque você forçou a InvariantCulture
        float v14 = float.Parse("134.43", System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

        // O v15 usa a vírgula (,) porque ele pega o padrão (pt-BR)
        float v15 = float.Parse("134,43");

        System.Console.WriteLine(v14);
        System.Console.WriteLine(v15);
    }
}