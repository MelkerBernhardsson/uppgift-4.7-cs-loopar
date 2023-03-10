using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett meddelande");
            string mssg = Console.ReadLine();
            Console.WriteLine("hur många rader vill du ska vara tomma");
            int mell = int.Parse(Console.ReadLine());

            for(int I=0; I<mssg.Length;I++)
            {
                for(int j=0; j<mell; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(mssg[I]);
            }
        }
    }
}
