using Caixa_Eletronico.Context;
using Caixa_Eletronico.Models;
using Caixa_Eletronico.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Repositories
{

    public class CedulasRepository : ICedulasRepository
    {
        private readonly AppDbContext _Contex;

        public CedulasRepository(AppDbContext Context )
        {
            _Contex = Context;
        }

        public IEnumerable<Cedulas> Cedula => _Contex.Cedulas;
    }
}
