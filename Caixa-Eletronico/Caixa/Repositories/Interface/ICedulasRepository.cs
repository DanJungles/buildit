using Caixa_Eletronico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Repositories.Interface
{
    public interface ICedulasRepository
    {
        IEnumerable<Cedulas> Cedula { get; }
    }
}
