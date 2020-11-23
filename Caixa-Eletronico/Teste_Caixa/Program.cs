using System;

namespace Teste_Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor a ser sacado");
            int valor_Saque = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de notas de valor 100 ");
            int quantidade_Nota100 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de notas de valor 50 ");
            int quantidade_Nota50 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de notas de valor 20 ");
            int quantidade_Nota20 = int.Parse(Console.ReadLine());

            //Sacar notas de 100
            Sacar_100(valor_Saque, quantidade_Nota100, quantidade_Nota50, quantidade_Nota20);

            //Sacar notas de 50
            Sacar_50(valor_Saque, quantidade_Nota50, quantidade_Nota20);

            // Sacar notas de 20
            Sacar_20( valor_Saque,quantidade_Nota20);


            void Sacar_100(int valor_Saque, int notas_100, int notas_50, int notas_20)
            {
                if (notas_100 > 0)
                {
                    int resultado_Subtraido = valor_Saque;
                    int contador = 0;
                    while (resultado_Subtraido >= 100 & contador <= notas_100)
                    {
                        resultado_Subtraido = resultado_Subtraido - 100;
                        contador += 1;



                        if (resultado_Subtraido <= notas_50 * 50 || resultado_Subtraido <= notas_20 * 20)
                        {
                            Console.WriteLine($"Quantidade Notas de 100: {contador}");

                            Console.WriteLine($"Quantidade Notas de 50: {resultado_Subtraido / 50}  ");
                            Console.WriteLine($"Quantidade Notas de 20: {resultado_Subtraido / 20} ");
                        }
                        Console.WriteLine("----------------------------------------------------------------");

                    }
                    //Console.WriteLine($"Quantidade de notas de 100: {contador}");
                    Console.WriteLine("----------------------------------------------------------------");


                }
            }


            void Sacar_50(int valor_Saque, int notas_50, int notas_20)
            {
                if (notas_50 > 0 && valor_Saque <= notas_20 * 50)
                {
                    int contador = 0;
                    int resultado_Subtraido = valor_Saque;

                    while (resultado_Subtraido >= 50 & contador <= notas_50)
                    {
                        resultado_Subtraido = resultado_Subtraido - 50;
                        contador += 1;

                        if (resultado_Subtraido < notas_20 * 20)
                        {

                            Console.WriteLine($"Quantidade Notas de 50: {contador}  ou {resultado_Subtraido / 20 } de 20 ");

                        }
                        Console.WriteLine("----------------------------------------------------------------");

                    }
                    //Console.WriteLine($"Quantidade de notas de 50: {contador}");
                    Console.WriteLine("----------------------------------------------------------------");
                }
            }



            void Sacar_20(int valor_Saque, int notas_20)
            {
                if (notas_20 > 0 && valor_Saque <= notas_20 * 20)
                {
                    int contador = 0;
                    int resultado_Subtraido = valor_Saque;

                    while (resultado_Subtraido >= 20 & contador <= notas_20)
                    {
                        resultado_Subtraido = resultado_Subtraido - 20;
                        contador += 1;
                    }
                    Console.WriteLine($"Quantidade de notas de 20: {contador}");

                }
            }

        }
    }

}
