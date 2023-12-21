using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    enum Menu { Soma, Subtração, Multiplicação, Divisão, Potenciação, Sair }
    private static void Main(string[] args)
    {

        bool escolheuSair = false;
        while (!escolheuSair)
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("0-Soma\n1-Subtração\n2-Multiplicação\n3-Divisão\n4-Potenciação\n5-Sair");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            Console.WriteLine("Você selecionou " + opcao);

            switch (opcao)
            {
                case Menu.Soma:
                    Somar();
                    break;

                case Menu.Subtração:
                    Subtrair();
                    break;
                case Menu.Multiplicação:
                    Multiplicar();
                    break;
                case Menu.Divisão:
                    Dividir();
                    break;
                case Menu.Potenciação:
                    Potenciar();
                    break;
                    case Menu.Sair:
                    escolheuSair = true;
                    break;
            }
            
            Console.Clear();

            static void Somar()
            {
                Console.WriteLine("Escolha um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha outro: ");
                int n2 = int.Parse(Console.ReadLine());
                int resultado = n1 + n2;
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();
            }

            static void Subtrair()
            {
                Console.WriteLine("Escolha um número: ");
                var n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha outro: ");
                var n2 = int.Parse(Console.ReadLine());
                var resultado = n1 - n2;
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();
            }

            static void Multiplicar()
            {
                Console.WriteLine("Escolha um número: ");
                var n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha outro: ");
                var n2 = int.Parse(Console.ReadLine());
                var resultado = n1 * n2;
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();
            }

             static void Dividir()
            {
                Console.WriteLine("Escolha um número: ");
                var n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha outro: ");
                var n2 = int.Parse(Console.ReadLine());
                var resultado = (float)n1 / (float)n2;
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();
            }

            static void Potenciar()
            {
                Console.WriteLine("Digite a base: ");
                var n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente: ");
                var n2 = int.Parse(Console.ReadLine());
                var resultado = Math.Pow(n1, n2);
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();
            }

            
        }
    }

}





   