using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
           //Soma();
           //Subtacao();
           //Divisao();
           //Multiplicacao();
           Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.Write("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divição");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res){
                case 1: Soma(); break;
                case 2: Subtacao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
             Console.Clear();
            Console.Write("Digite um primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float g = v1 + v2;
            Console.WriteLine("");
            Console.Write($"A soma entre {v1} e o {v2} vale {g}");
            Console.ReadKey();
            Menu();
        }

        static void Subtacao(){
            Console.Clear();
            Console.Write("Hora de subtrair");
            Console.WriteLine("");

            Console.Write("Digite um valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite outro valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float f = n1 - n2;
            Console.WriteLine("");

            Console.WriteLine($"A subtração entre {n1} menos {n2} vale {f}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao(){
            Console.Clear();

            Console.Write("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite um segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float r = v1 / v2;

            Console.WriteLine($"O resultado da divição entre {v1} e {v2} e {r}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao(){
            Console.Clear();

            Console.Write("Digite um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite outro valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            float R = v1 * v2;

            Console.WriteLine($"A Multiplicação entre {v1} e o {v2} vale {R}");
            Console.ReadKey();
            Menu();
        }
    }
}