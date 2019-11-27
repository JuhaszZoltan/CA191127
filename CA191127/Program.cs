using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CA191127
{
    class Program
    {
        static Random rnd = new Random();
        static int[] t = new int[100];
        static char[] szo;
        static void Main()
        {
            //Feltolt();
            //Kiir();
            //Console.WriteLine("írj be egy karaktert, csinálok belőle 200 színeset!");
            //char c = Console.ReadLine()[0];
            //for (int i = 0; i < 200; i++)
            //{
            //RandomSzin();
            //RandomHelyreIr(c);
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    JelszoGen();
            //}

            //string valami = Anagramma2();
            //Console.WriteLine(valami);

            Console.Write("Írd be Pistike jegyét: ");
            Console.WriteLine($"Pistike értékelése: {Osztalyoz(int.Parse(Console.ReadLine()))}");

            Console.ReadKey();
        }
        static void Feltolt()
        {
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
            }
        }
        static void Kiir()
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write($"{t[i]} ");
                if ((i + 1) % 10 == 0) Console.Write("\n");
            }
        }
        static void RandomHelyreIr(char k)
        {
            Console.SetCursorPosition(
                rnd.Next(Console.WindowWidth),
                rnd.Next(Console.WindowHeight));
            Console.Write(k);
        }
        static void RandomSzin()
        {
            Console.ForegroundColor = (ConsoleColor)rnd.Next(2, 16);
        }
        static void RandomChar()
        {
            Console.Write((char)rnd.Next(65, 91));
        }
        static void JelszoGen()
        {
            for (int i = 0; i < 6; i++)
            {
                RandomChar();
            }
            Console.Write("\n");
        }
        static void TombKever()
        {
            for (int i = 0; i < szo.Length; i++)
            {
                int x = rnd.Next(szo.Length);
                int y = rnd.Next(szo.Length);

                char cs = szo[x];
                szo[x] = szo[y];
                szo[y] = cs;
            }
        }
        static string Anagramma2()
        {
            szo = "INFORMATIKA".ToCharArray();
            TombKever();
            string anagramma = "";

            for (int i = 0; i < szo.Length; i++)
            {
                anagramma += szo[i];
            }

            return anagramma;
        }
        static string Anagramma(string s)
        {
            char[] t = s.ToCharArray();
            for (int i = 0; i < t.Length; i++)
            {
                int x = rnd.Next(t.Length);
                int y = rnd.Next(t.Length);

                char cs = t[x];
                t[x] = t[y];
                t[y] = cs;
            }
            return new string(t);
        }

        static string Osztalyoz(int jegy)
        {
            switch (jegy)
            {
                case 1: return "elégtelen";
                case 2: return "elégséges";
                case 3: return "közepes";
                case 4: return "jó";
                case 5: return "jeles";
            }
            return "valami nem stimmel :(";
        }

    }
}
