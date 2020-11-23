using System.Collections.Generic;

namespace Teste_Caixa
{
    class Caixa_eletronico
    {
        public List<Notas> notas_disponiveis;

        public Caixa_eletronico(List<Notas> notas_disponiveis)
        {
            this.notas_disponiveis = notas_disponiveis;
        }
    }
    class Notas
    {
        string nome;
        int quantidade;

        internal Caixa_eletronico Caixa_eletronico
        {
            get => default;
            set
            {
            }
        }
    }
}
