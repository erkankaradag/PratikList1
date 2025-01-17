using System;

namespace PratikList1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> davetliler = new List<string> { "Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın" };

            foreach (string davetli in davetliler)

            {
                Console.WriteLine(davetli);
            }
        }
    }
}