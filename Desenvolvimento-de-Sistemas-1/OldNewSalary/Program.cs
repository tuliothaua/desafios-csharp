internal class Program
{ // Túlio Thauã Dutra :D
    private static void Main(string[] args)
    {
        int choice = 1;
        decimal newsalary = 0;
        string percentual = "0%";
        string cargo = "N";


        Console.WriteLine("\n- Insira seu nome: ");
        string nome = Console.ReadLine()!;

        Console.WriteLine("\n- Insira seu salário: ");
        decimal oldsalary = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("\n- Insira seu código de acordo com seu cargo: ");
        Console.WriteLine("\nCòdigo  ---  Cargo");
        Console.WriteLine("\n1     --- Gerente");
        Console.WriteLine("\n2     --- Engenheiro");
        Console.WriteLine("\n3     --- Técnico");
        choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
                cargo = "Gerente";
                newsalary = oldsalary;
                newsalary *= 1.10m;
                percentual = "%10";
                break;

            case 2:
                cargo = "Engenheiro";
                newsalary = oldsalary;
                newsalary *= 1.20m;
                percentual = "%20";
                break;

            case 3:
                cargo = "Técnico";
                newsalary = oldsalary;
                newsalary *= 1.30m;
                percentual = "%30";
                break;

            default:
                cargo = "Unknown";
                newsalary = oldsalary;
                newsalary *= 1.40m;
                percentual = "%40";
                break;

        }

        Console.WriteLine($"\n[NOME]       :: {nome}");
        Console.WriteLine($"[CARGO]      :: {cargo}");
        Console.WriteLine($"[OLD-SALARY] :: {oldsalary}");
        Console.WriteLine($"[NEW-SALARY] :: {newsalary}");
        Console.WriteLine($"[PERCENTUAL] :: {percentual}");
    }
}