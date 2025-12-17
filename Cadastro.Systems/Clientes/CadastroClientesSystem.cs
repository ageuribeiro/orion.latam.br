using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Core.Ports;
using Cadastro.Core.Services;

namespace Cadastro.Systems.Clientes;

public class CadastroClientesSystem : ICadastroSystem
{
    public string Nome => "Cadastro de Clientes";

    private readonly CadastroBaseService _baseService;

    public CadastroClientesSystem()
    {
        _baseService = new CadastroBaseService();
    }

    public void Executar()
    {
        _baseService.Validar();
        Console.WriteLine("Executando o sistema de cadastro de clientes.");
    }   
}
