using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuOpcoes();
        }

        static void MenuOpcoes()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opcoes:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("---------------------");
            short opcoesMenu = short.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 1 valor:");
            float valorEntrada1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2 valor:");
            float valorEntrada2 = float.Parse(Console.ReadLine());

            float itemArit = 0;
            itemArit = OperacoesAritmedicas(opcoesMenu, valorEntrada1, valorEntrada2, itemArit);
        }

        static float OperacoesAritmedicas(short opcoesMenu, float valorEntrada1, float valorEntrada2, float itemArit)
        {
            switch (opcoesMenu)
            {
                case 1:
                    itemArit = valorEntrada1 + valorEntrada2;
                    Console.WriteLine($"O resultado da Soma: {itemArit}");
                    break;
                case 2:
                    itemArit = valorEntrada1 - valorEntrada2;
                    Console.WriteLine($"O resultado da Subtracao {itemArit}");
                    break;
                case 3:
                    itemArit = valorEntrada1 / valorEntrada2;
                    Console.WriteLine($"O resultado da Divisao {itemArit}");
                    break;
                case 4:
                    itemArit = valorEntrada1 * valorEntrada2;
                    Console.WriteLine($"O resultado da Multiplicacao {itemArit}");
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }
            return itemArit;
        }
    }
}
