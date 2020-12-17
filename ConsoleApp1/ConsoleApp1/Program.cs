using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Sorting sorting = new Sorting();

            int[] tab;
            tab = numbers.GenerujNumery();
            sorting.Sortuj(tab);

            Console.ReadKey();
        }
    }

    public class Numbers
    {
        public int[] GenerujNumery()
        {
            int[] numery = new int[10000];
            Random random = new Random();

            for(int i = 0; i< 10000; i++)
            {
                numery[i] = random.Next(0, 10000);
            }

            return numery;
        }
    }

    public class Sorting
    {
        public int[] Sortuj(int[] tab)
        {
            int rezerwa;

            Draw draw = new Draw();
            draw.Rysuj(tab);
            Console.WriteLine("New Tab: \n");

            for(int i = 0; i < tab.Length-1; i++)
            {
                for(int j = 0; j< tab.Length-1; j++)
                {
                    if(tab[j] > tab[j + 1])
                    {
                        rezerwa = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = rezerwa;
                    }
                }
            }
            draw.Rysuj(tab);

            return tab;
        }
    }

    public class Draw
    {
        public void Rysuj(int[] tab)
        {
            for(int i = 0; i< tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
