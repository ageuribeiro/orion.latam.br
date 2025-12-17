using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Core.Ports;

namespace Cadastro.Systems.Produtos;

public class CadastroProdutosSystem : ICadastroSystem
{
    public string Nome => "Cadastro de Produtos";
    public void Executar()
    {
        Console.WriteLine("Executando o sistema de cadastro de produtos.");
    }
}
