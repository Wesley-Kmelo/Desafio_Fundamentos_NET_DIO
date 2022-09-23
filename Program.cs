using Desafio_Fundamentos_NET_DIO.Models;


Estacionamento veiculo = new Estacionamento();

Console.WriteLine("Bem vindo ao Sistema ExtacionaMax !!!");
Console.WriteLine("-------------------------------------");
Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx \n");

bool Menu = true;
bool login = false;
string? usuario;

    Console.Write("Digite um nome para continuar => : ");
    usuario = Console.ReadLine();
    Console.WriteLine($"\nO login digitado foi {usuario}.");
    
while (!login)
{
    Console.WriteLine("Deseja prosseguir com esse login ? Escolha 'sim' ou 'nao'");
    Console.Write("=> : ");

    switch (Console.ReadLine())
    {
        case "sim":
            Console.Clear();
            Console.WriteLine($"\nBem vindo {usuario} !!!");
            login = true;
            break;

        case "nao":
            Console.Clear();
            Console.Write("\nEscolha outro nome desejado =>: ");
            usuario = Console.ReadLine();
            break;
        default:
            Console.Clear();
            Console.Write("\nNão entendi. Digite o login novamente =>: ");
            usuario = Console.ReadLine();
            break;
    }
}

while (Menu)
{ 
 Console.WriteLine("    \n Escolha uma das opções abaixo:");
 Console.WriteLine(@"       
       (1) Cadastra Veículo 
       (2) Remove Veículo 
       (3) Lista de Veículos 
       (4) Encerrar o Sistema");
 Console.Write("\n Número da opção =>: ");

 var opcao = Console.ReadLine();

 switch (opcao)
 {
    case "1":
        Console.Clear();
        
        Console.WriteLine("CADASTRO DE VEÍCULOS");
        Console.Write("Escreva o nome da placa => : ");
        string? placa = Console.ReadLine();

        Console.WriteLine("\nCADASTRO DE TAXAS");
        Console.Write("Digite o valor inicial do Estacionamento => : ");
        decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
        
        veiculo.AdicionarVeiculo(placa!, valorInicial);
        Console.Clear();
        break;

    case "2":
        Console.Clear();
        veiculo.RemoverVeiculo();
        break;

    case "3":
        Console.Clear();
        veiculo.ListarVeiculos(usuario!);
        break;

    case "4":
        Console.Clear();
        Menu = false;
        break;

    default:
        Console.Clear();
        Console.WriteLine($"A Opção digitada foi: '{opcao}' e é inválida. Digite novamente");
        break;
 }
}

Console.WriteLine($"Sistema encerrado com sucesso!!! \nAté mais {usuario} !!!");



