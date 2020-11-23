using Caixa_Eletronico.Models;
using Caixa_Eletronico.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Repositories
{
    public class HardCodeRepository : ICedulasRepository
    {
        public IEnumerable<Cedulas> Cedula => new[]
           {
                new Cedulas {Valor = 100 ,Quantidade = 10 },
                new Cedulas {Valor = 50 ,Quantidade = 10 },
                new Cedulas {Valor = 20 ,Quantidade = 10 },
                new Cedulas {Valor = 10 ,Quantidade = 10 },
                new Cedulas {Valor = 5 ,Quantidade = 10 }
            };
    }
}
