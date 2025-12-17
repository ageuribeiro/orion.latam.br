using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Ports;

public interface ICadastroSystem
{
    string Nome { get; }
    void Executar();
}
