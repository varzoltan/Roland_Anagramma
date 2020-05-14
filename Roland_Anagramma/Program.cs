using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Roland_Anagramma
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.Write("Kérem adjon meg egy szót: ");
            string szo = Console.ReadLine();
            char[] kar_tomb = szo.ToCharArray();
            /*Array.Sort(kar_tomb);
            for (int i = 0; i<kar_tomb.Length;i++)
            {
                Console.Write(kar_tomb[i]);              
            }
            Console.WriteLine();
            int darabszam = 1;
            for (int i = 1;i<szo.Length;i++)
            {
                if(kar_tomb[i] == kar_tomb[i-1])
                {

                    darabszam++;
                    if (i == szo.Length - 1)
                    {
                        Console.WriteLine(kar_tomb[i] + ":" + darabszam);
                    }
                }

                else 
                {
                    Console.WriteLine(kar_tomb[i - 1]+ ":"+darabszam);
                    darabszam = 1;
                    if (i == szo.Length - 1)
                    {
                        Console.WriteLine(kar_tomb[i] + ":" + darabszam);
                    }
                }
            }*/
            
            for (int i = 'a';i<='z';i++)
            {
                int darabszam = 0;
                for (int j = 0;j<kar_tomb.Length;j++)
                {
                    if (Convert.ToChar(i) == kar_tomb[j])
                    {
                        darabszam++;
                    }                  
                }
                if (darabszam != 0)
                {
                    Console.WriteLine(Convert.ToChar(i) + ":" + darabszam);
                }
            }

            //2.feladat
            /*string[] sor = File.ReadAllLines("szotar.txt");
            string[] szotar = new string[300];
            int n = 0;
            while (sor != null)
            {
                szotar[n] = sor[0];
                n++;
            }*/
            StreamReader olvas = new StreamReader("szotar.txt");
            int n = 0;
            string[] szotar = new string[300];
            while (!olvas.EndOfStream)
            {
                szotar[n] = olvas.ReadLine();
                n++;
            }
            Console.ReadKey();
        }
    }
}
