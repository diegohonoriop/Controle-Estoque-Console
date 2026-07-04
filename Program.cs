Console.WriteLine("=== SISTEMA DE CONTROLE DE ESTOQUE ===");

string[] pecas =
{
    "Filtro de Oleo",
    "Pastilha de Freio",
    "Vela de Igniçao",
    "Correia Dentada"
};

int[] quantidades = { 10, 5, 15, 8 };

bool executar = true;

while (executar)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Listar todas as peças em estoque");
    Console.WriteLine("2 - Verificar itens com estoque baixo (menos de 6 unidades)");
    Console.WriteLine("0 - Sair do sistema");

    Console.Write("\nDigite a sua opção: ");
    string opcao = Console.ReadLine() ?? "";

    Console.WriteLine("\n--- Processando ---");

    if (opcao == "1")
    {
        Console.WriteLine("=== PRODUTOS EM ESTOQUE ===");

        for (int i = 0; i < pecas.Length; i++)
        {
            Console.WriteLine("Peça: " + pecas[i] + " | Quantidade: " + quantidades[i]);
        }
    }
    else if (opcao == "2")
    {
        Console.WriteLine("=== ALERTA: REPOSIÇÃO NECESSÁRIA ===");

        bool nenhumBaixo = true;

        for (int i = 0; i < pecas.Length; i++)
        {
            if (quantidades[i] < 6)
            {
                Console.WriteLine("ATENÇÃO: " + pecas[i] + " está com apenas " + quantidades[i] + " unidades!");
                nenhumBaixo = false;
            }
        }

        if (nenhumBaixo)
        {
            Console.WriteLine("Tudo certo! Nenhum item com estoque baixo.");
        }
    }
    else if (opcao == "0")
    {
        Console.WriteLine("Saindo do sistema...");
        executar = false;
    }
    else
    {
        Console.WriteLine("Opção inválida! Tente novamente.");
    }

    {
        Console.WriteLine("--------------------------------");
    }    
}
