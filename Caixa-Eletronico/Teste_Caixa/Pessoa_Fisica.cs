using System;

namespace Teste_Caixa
{

    class Pessoa_Fisica : Cliente
    {
        public string CPF;

        public Pessoa_Fisica(int id_Conta, string nome, int senha, string cpf) : base(id_Conta, nome, senha)
        {
            CPF = cpf;
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
