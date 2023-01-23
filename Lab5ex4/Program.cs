using System;

namespace Lab5ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 4 Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit de la tastatura, ignorand caseing-ul literelor. */

            Console.WriteLine("Introduceti sirul de caractere=  ");
            string sir = Console.ReadLine();

            if (string.IsNullOrEmpty(sir) || string.IsNullOrWhiteSpace(sir))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            //ignoram case-ing-ul literelor
            sir = sir.ToLower();

            int nrMaximDeAparitii = CalculeazaNumarMaximDeAparitii(sir);

            string celMaiRecurentCaracter = CalculeazaCaracterulCuNumarulMaximDeAparitii(nrMaximDeAparitii, sir);

            Console.WriteLine(celMaiRecurentCaracter + " apare de cele mai multe ori in sirul " + sir + " adica de " + nrMaximDeAparitii + " ori ");

        }

        public static string CalculeazaCaracterulCuNumarulMaximDeAparitii(int nrMaxDeAparitii, string sir) 
        {
            int lungimeSir = sir.Length;

            for (int i = 0; i < lungimeSir; i++)
            {
                int numarAparitii = NumaraAparitii(sir[i].ToString(), sir);
                if (numarAparitii == nrMaxDeAparitii) return sir[i].ToString();
            }

            return string.Empty;
        }

        public static int CalculeazaNumarMaximDeAparitii(string sir)
        {

            int lungimeSir = sir.Length;

            int celMaiMareNumarDeAparitii = 0;

            for (int i = 0; i < lungimeSir; i++)
            {
                int numarAparitii = NumaraAparitii(sir[i].ToString(), sir);
                if (numarAparitii > celMaiMareNumarDeAparitii) celMaiMareNumarDeAparitii = numarAparitii;
            }

            return celMaiMareNumarDeAparitii;
        }

        public static int NumaraAparitii(string crt, string sir)
        {
            int numarAparitii = 0;

            int lungimeSir = sir.Length;

            for (int i = 0; i < lungimeSir; i++)
            {
                if (sir[i].ToString() == crt.ToString())
                    numarAparitii = numarAparitii + 1;
            }

            return numarAparitii;
        }
    }
}
