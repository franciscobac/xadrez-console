using System;
using tabuleiro;

namespace xadrez_console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(3, 4);

            Console.WriteLine(tab);
        }
    }
}
