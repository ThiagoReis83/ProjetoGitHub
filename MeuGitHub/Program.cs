using System;

namespace MeuGitHub
{
    class Program
    {
        static void EscreveNaTela()
        {
            Console.WriteLine("Hello World!");
        }


        static void EscreveNaTela(String texto)
        {
            Console.WriteLine(texto);
        }

        static void Main(string[] args)
        {
            EscreveNaTela();
            Console.ReadKey();
        }
    }
}
