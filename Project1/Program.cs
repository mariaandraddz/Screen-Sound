string Sound = "Boas Vindas ao Screen Sound";
void ImprimirNome()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(Sound);
}


void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcao = int.Parse(opcaoEscolhida);

    switch (opcao)
    {
        case 1: RegistrarBandas();
            Console.WriteLine("Opção 1 selecionada: Registrar uma banda");
            break;
        case 2:
            Console.WriteLine("Opção 2 selecionada: Mostrar todas as bandas");
            break;
        case 3:
            Console.WriteLine("Opção 3 selecionada: Avaliar uma banda");
            break;
        case 4:
            Console.WriteLine("Opção 4 selecionada: Exibir a média de uma banda");
            break;
        case -1:
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }  
}
void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("=== Registro de Bandas ===");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"Banda '{nomeBanda}' registrada com sucesso!");
}
ImprimirNome();


ExibirMenu();