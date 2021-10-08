using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            //Start(6);

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Contar em minutos => 10s = 10 segundos");
            Console.WriteLine("M = Contar em minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);
            //usado para pegar o ultimo caractere (Substring + data.Length)
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1);
        
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...retornando para o menu");
            Thread.Sleep(2500);
        }

}   
