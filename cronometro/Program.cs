using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();
            char tipo = char.Parse(dados.Substring(dados.Length - 1, 1));
            int time = int.Parse(dados.Substring(0, dados.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tipo == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplicador);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2000);

            Start(time);
        }

        static void Start(int time)
        {
            int timeAtual = 0;

            while (timeAtual != time)
            {
                Console.Clear();
                timeAtual++;
                Console.WriteLine(timeAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
