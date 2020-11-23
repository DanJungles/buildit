using Caixa_Eletronico.Models;
using Caixa_Eletronico.Repositories;
using Caixa_Eletronico.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caixa_Eletronico.ViewModel
{

    public class CaixaViewModel
    {

        public int Valor_Saque { get; set; }
        public string Mensagem { get; set; }
        public IEnumerable<Cedulas> List_Cedula;

        private readonly ICedulasRepository _cedulasRepository;
        public CaixaViewModel()
        {
            _cedulasRepository = new HardCodeRepository();
            List_Cedula = _cedulasRepository.Cedula;
        }
    }
}
