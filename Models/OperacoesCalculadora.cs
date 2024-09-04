using System;

namespace dotnet.Models
{
    public class OperacoesCalculadora
    {
        public float Somar(float a, float b)
        {
            return a + b;
        }
        public float Subtrair(float a, float b)
        {
            return a - b;
        }
        public float Multiplicacao(float a, float b)
        {
            return a * b;
        }
        public float Dividir(float a, float b)
        {
            while (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero");
                if (float.TryParse(Console.ReadLine(), out float DivisorB))
                {
                    b = DivisorB;

                }
                else
                {
                    Console.WriteLine("Não foi possível converter o valor");
                }
            }
            return a / b;
        }
    }

}
