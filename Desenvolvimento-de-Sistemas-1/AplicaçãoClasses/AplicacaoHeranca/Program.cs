using ClassesHeranca;
// Túlio Thauã, Lia Mariah, Erik Domingos, Jose Pedro


Revenda? revenda = null;

string? opcao = "";
while (true)
{
    Console.WriteLine("\n================================");
    Console.WriteLine("1 - Cadastrar Revenda");
    Console.WriteLine("2 - Adicionar Veiculo");
    Console.WriteLine("3 - Listar Tudo");
    Console.WriteLine("0 - Sair\n");
    opcao = Console.ReadLine();
    Console.WriteLine("\n");
    if (opcao == "0") break;
    switch (opcao)
    {

        case "1":
            //Cadastrar a revenda
            Console.WriteLine("================================");
            Console.WriteLine("Nome da Revenda: ");
            string? nomerevenda = Console.ReadLine();
            Console.WriteLine("CNPJ: ");
            string? cnpj = Console.ReadLine();
            Console.WriteLine("Nome do Logradouro: ");
            string? nomelogradouro = Console.ReadLine();
            Console.WriteLine("Tipo do Logradouro: ");
            string? tipo = Console.ReadLine();
            Console.WriteLine("Bairro do Logradouro: ");
            string? bairro = Console.ReadLine();
            Console.WriteLine("Cidade do Logradouro: ");
            string? cidade = Console.ReadLine();
            Console.WriteLine("Estado do Logradouro: ");
            string? estado = Console.ReadLine();
            Console.WriteLine("CEP do Logradouro: ");
            string? cep = Console.ReadLine();

            Logradouro endereco = new Logradouro(
                nomelogradouro ?? string.Empty,
                tipo ?? string.Empty,
                bairro ?? string.Empty,
                cidade ?? string.Empty,
                estado ?? string.Empty,
                cep ?? string.Empty);
            revenda = new Revenda(nomerevenda ?? string.Empty, cnpj ?? string.Empty, endereco);
            Console.WriteLine("\n================================");
            Console.WriteLine("Revenda cadastrada com sucesso!");
            Console.WriteLine("================================");
            break;
        case "2":
            //Adicionar Veiculo
            if (revenda == null)
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("Cadastre uma revenda antes de adicionar um veículo.");
                break;
            }
            Console.WriteLine("================================");
            Console.WriteLine("1 - Automovel");
            Console.WriteLine("2 - Motocicleta");
            Console.WriteLine("3 - Bicicleta");
            Console.WriteLine("4 - Caminhão");
            Console.WriteLine("5 - Caminhonete ");
            Console.WriteLine("6 - Utilitario\n");

            string? tipoVeiculo = Console.ReadLine();
            switch (tipoVeiculo)
            {
                case "1": // Automovel
                    Console.WriteLine("\n================================");
                    Console.WriteLine("Marca: ");
                    string? marca = Console.ReadLine();
                    Console.WriteLine("Modelo: ");
                    string? modelo = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    string? ano = Console.ReadLine();
                    Console.WriteLine("Cor: ");
                    string? cor = Console.ReadLine();
                    Console.WriteLine("Placa: ");
                    string? placa = Console.ReadLine();
                    Console.WriteLine("Qntd de Portas: ");
                    string? qntddeportas = Console.ReadLine();
                    Console.WriteLine("Combustivel: ");
                    string? combustivel = Console.ReadLine();

                    Automovel automovel = new Automovel(marca ?? "", modelo ?? "", ano ?? "", cor ?? "", placa ?? "", int.Parse(qntddeportas ?? "0"), combustivel ?? "");
                    revenda.AdicionarVeiculo(automovel);
                    break;

    
                    case "2": // Motocicleta
                    Console.WriteLine("\n================================");
                    Console.WriteLine("Marca: ");
                    string? marcamo = Console.ReadLine();
                    Console.WriteLine("Modelo: ");
                    string? modelomo = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    string? anomo = Console.ReadLine();
                    Console.WriteLine("Cor: ");
                    string? cormo = Console.ReadLine();
                    Console.WriteLine("Placa: ");
                    string? placamo = Console.ReadLine();

                    Console.WriteLine("Cilindradas: ");
                     int cilindradas = int.Parse(Console.ReadLine() ?? "0");
                     Console.WriteLine("Partida Eletrica (S/N): ");
                    bool partidaEletrica = (Console.ReadLine() ?? "").ToUpper() == "S";
                     Motocicleta moto = new Motocicleta(marcamo ?? "", modelomo ?? "", anomo ?? "", cormo ?? "", placamo ?? "", cilindradas, partidaEletrica);
                    revenda.AdicionarVeiculo(moto);
                    break;

                case "3": // Bicicleta
                    Console.WriteLine("\n================================");
                    Console.WriteLine("Marca: ");
                    string? marcabi = Console.ReadLine();
                    Console.WriteLine("Modelo: ");
                    string? modelobi = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    string? anobi = Console.ReadLine();
                    Console.WriteLine("Cor: ");
                    string? corbi = Console.ReadLine();
                    Console.WriteLine("Placa: ");
                    string? placabi = Console.ReadLine();
                    Console.WriteLine("Numero de Marchas: ");
                    int numeroMarchas = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Tipo do Quadro: ");
                    string? tipoQuadro = Console.ReadLine();
                    Console.WriteLine("Tem Castinha (S/N): ");
                    bool temCastinha = (Console.ReadLine() ?? "").ToUpper() == "S";
                    Bicicleta bicicleta = new Bicicleta(marcabi ?? "", modelobi ?? "", anobi ?? "", corbi ?? "", placabi ?? "", numeroMarchas, tipoQuadro ?? "", temCastinha);
                    revenda.AdicionarVeiculo(bicicleta);
                    break;

                case "4": // Caminhao
                    Console.WriteLine("\n================================");
                    Console.WriteLine("Marca: ");
                    string? marcaca = Console.ReadLine();
                    Console.WriteLine("Modelo: ");
                    string? modeloca = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    string? anoca = Console.ReadLine();
                    Console.WriteLine("Cor: ");
                    string? corca = Console.ReadLine();
                    Console.WriteLine("Placa: ");
                    string? placaca = Console.ReadLine();
                    Console.WriteLine("Qntd de Eixos: ");
                    int qntdEixos = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Comprimento: ");
                    double comprimento = double.Parse(Console.ReadLine() ?? "0");
                    Caminhao caminhao = new Caminhao(marcaca ?? "", modeloca ?? "", anoca ?? "", corca ?? "", placaca ?? "", qntdEixos, comprimento);
                    revenda.AdicionarVeiculo(caminhao);
                    break;

                case "5": // Caminhonete
                    Console.WriteLine("\n================================");
                    Console.WriteLine("Marca: ");
                    string? marcacn = Console.ReadLine();
                    Console.WriteLine("Modelo: ");
                    string? modelocn = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    string? anocn = Console.ReadLine();
                    Console.WriteLine("Cor: ");
                    string? corcn = Console.ReadLine();
                    Console.WriteLine("Placa: ");
                    string? placacn = Console.ReadLine();
                    Console.WriteLine("Tipo da Cacamba: ");
                    string? tipoCacamba = Console.ReadLine();
                    Console.WriteLine("Tracao 4x4 (S/N): ");
                    bool tracao4x4 = (Console.ReadLine() ?? "").ToUpper() == "S";
                    Caminhonete caminhonete = new Caminhonete(marcacn ?? "", modelocn ?? "", anocn ?? "", corcn ?? "", placacn ?? "", tipoCacamba ?? "", tracao4x4);
                    revenda.AdicionarVeiculo(caminhonete);
                    break;

                case "6": // Utilitario
                    Console.WriteLine("\n================================");
                    Console.WriteLine("Marca: ");
                    string? marcaut = Console.ReadLine();
                    Console.WriteLine("Modelo: ");
                    string? modelout = Console.ReadLine();
                    Console.WriteLine("Ano: ");
                    string? anout = Console.ReadLine();
                    Console.WriteLine("Cor: ");
                    string? corut = Console.ReadLine();
                    Console.WriteLine("Placa: ");
                    string? placut = Console.ReadLine();
                    Console.WriteLine("Tracao nas Quatro (S/N): ");
                    bool tracaoNasQuatro = (Console.ReadLine() ?? "").ToUpper() == "S";
                    Console.WriteLine("Volume do Porta Malas: ");
                    double volumePortaMalas = double.Parse(Console.ReadLine() ?? "0");
                    Utilitario utilitario = new Utilitario(marcaut ?? "", modelout ?? "", anout ?? "", corut ?? "", placut ?? "", tracaoNasQuatro, volumePortaMalas);
                    revenda.AdicionarVeiculo(utilitario);
                    break;
            }

            break;
        case "3":
            //Listar Tudo
            if (revenda == null)
            {
                Console.WriteLine("Nenhuma revenda cadastrada.");
                break;
            }
            Console.WriteLine("\n================================");
            // mostrar dados da revenda
            foreach (var dado in revenda.RetornarDados())
                Console.WriteLine(dado.campo + "  ---  " + dado.valor);

            // mostrar veiculos
            foreach (var veiculo in revenda.Veiculos)
            {
                Console.WriteLine("\n--- " + veiculo.GetType().Name + " ---");
                foreach (var dado in veiculo.RetornarDados())
                    Console.WriteLine(dado.campo + dado.valor);
            }
            break;
    }
}