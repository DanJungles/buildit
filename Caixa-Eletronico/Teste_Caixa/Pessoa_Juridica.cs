using System;

namespace Teste_Caixa
{
    class Pessoa_Juridica : Cliente
    {
        public string CNPJ;

        public Pessoa_Juridica(int id_Conta, string nome, int senha, string cNPJ) : base(id_Conta, nome, senha)
        {
            CNPJ = cNPJ;
        }

        public override float Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }
    }
}
