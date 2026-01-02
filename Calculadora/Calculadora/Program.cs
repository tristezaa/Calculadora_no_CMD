using System;

namespace Calculadora
{
    class Program
    {
        enum Menu
        {
            Soma = 1,
            Subtracao,
            Multiplicacao,
            Divisao,
            Potencia,
            Raiz,
            Sair
        }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Calculadora iniciada.");
                Console.WriteLine("Selecione uma operação:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potencia\n6-Raiz\n7-Sair");

                Menu escolha = (Menu)int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Multiplicacao:
                        Multi();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                }
                

                //Console.WriteLine($"Voce escolheu: {escolha}");
                Console.ReadLine();
                Console.Clear();
            }

        }

        static void Soma()
        {   
            Console.WriteLine("Soma selecionada.");
            Console.WriteLine("Digite o primeiro valor:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a + b; 
            Console.WriteLine($"O resultado da soma é: {resultado}");
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração selecionada.");
            Console.WriteLine("Digite o primeiro valor:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
        }

        static void Multi()
        {
            Console.WriteLine("Multiplicação selecionada.");
            Console.WriteLine("Digite o primeiro valor:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }

        static void Div()
        {
            Console.WriteLine("Divisão selecionada.");
            Console.WriteLine("Digite o primeiro valor:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            double b = double.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }

        static void Potencia()
        {
            Console.WriteLine("Potência selecionada.");
            Console.WriteLine("Digite a base da potência:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            double b = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(a, b);
            Console.WriteLine($"O resultado da potência é: {resultado}");
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz selecionada.");
            Console.WriteLine("Digite o radicando:");
            double a = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da raiz é: {resultado}");
        }
    }
}
