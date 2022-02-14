using System;

namespace triangulosProva.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação do tipo do triângulo.");
            Console.WriteLine();

            double x = 0;
            double y = 0;
            double z = 0;

            while (true)
            {
                Console.WriteLine("Digite 1 para iniciar, ou digite s para sair.");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {

                    Console.WriteLine("Digite o valor de X:");
                    string strX = Console.ReadLine();
                    x = Convert.ToDouble(strX);

                    Console.WriteLine("Digite o valor de Y:");
                    string strY = Console.ReadLine();
                    y = Convert.ToDouble(strY);
                    
                    Console.WriteLine("Digite o valor de Z:");
                    string strZ = Console.ReadLine();
                    z = Convert.ToDouble(strZ);
                    Console.WriteLine();

                    if (x > y + z || y > x + z || z > y + x)
                    {
                        Console.WriteLine("Triângulo inválido.");
                    }

                    else if (x == y && y == z)
                    {
                        Console.WriteLine("Triângulo equilatero.");
                    }

                    else
                    {
                        Console.WriteLine("Triângulo escaleno.");
                    }

                }

                if (opcao == "s")
                {
                    break;
                }
                
            }
            return;
               
        }
    }
}
