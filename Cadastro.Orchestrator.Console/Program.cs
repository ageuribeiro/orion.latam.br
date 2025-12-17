using System;
using Cadastro.Systems.Produtos;
using Cadastro.Systems.Clientes;
using Cadastro.Core.Ports;

namespace Cadastro.Orchestrator;

class Program
{
    static void Main()
    {
        var sistemas = new ICadastroSystem[]
        {
            new CadastroClientesSystem(),
            new CadastroProdutosSystem()
        };

        Console.WriteLine("Selecione o sistema que deseja executar...");
        for (int i = 0; i < sistemas.Length; i++)
            Console.WriteLine($"{i + 1} - {sistemas[i].Nome}");

        var opcao = int.Parse(Console.ReadLine()!) - 1;
        var system = sistemas[opcao];

        system.Executar();
    }
}
