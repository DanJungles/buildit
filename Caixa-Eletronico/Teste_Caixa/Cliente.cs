public abstract class Cliente
{
    public int Id_Conta;
    public string Nome;
    public int Senha;

    protected Cliente(int id_Conta, string nome, int senha)
    {
        Id_Conta = id_Conta;
        Nome = nome;
        Senha = senha;
    }

    public abstract float Sacar(float valor);
    public abstract float Depositar(float valor);
}
