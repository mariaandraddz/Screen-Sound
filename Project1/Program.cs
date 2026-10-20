string Sound = "Boas Vindas ao Screen Sound";
List<string> bandasRegistradas = new List<string> { "U2", "The Beatles"};

Dictionary<string, List<int>> bandasRegistadas = new Dictionary<string, List<int>>();
bandasRegistadas.Add("Link park", new List<int> { 10, 8, 6 });
bandasRegistadas.Add("The Beatles", new List<int>());
void ExibirLogo()
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
    ExibirLogo();
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
            break;
        case 2: ExibirTodasBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
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
    Console.Clear(); // limpa todo o conteúdo do console
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!; // "!" indica que a variável não será nula
    bandasRegistadas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda '{nomeBanda}' registrada com sucesso!");
    Thread.Sleep(2000); // Pausa a execução por 2 segundos
    Console.Clear(); // Limpa o console novamente
    ExibirMenu(); // Chama o menu novamente após registrar a banda

}
void ExibirTodasBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    foreach (string banda in bandasRegistadas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
    Console.Clear();
    ExibirMenu(); // Chama o menu novamente após exibir as bandas
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda() { 
    
}
ExibirMenu();