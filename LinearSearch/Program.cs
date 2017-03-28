using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Linearsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taulukon luonti
            int[] taul = new int[99999999];
            for (int i = 0; i < 99999999; i++)
            {
                taul[i] = i + 1;
            }
            /*Random rnd = new Random();
            for (int i = taul.Length; i > 1; i--)
            {
                int pos = rnd.Next(i);
                var x = taul[i - 1];
                taul[i - 1] = taul[pos];
                taul[pos] = x;
            }*/

            Console.WriteLine("Enter number:");
            string j = Console.ReadLine();
            int j2 = Int32.Parse(j);
            //var timer = System.Diagnostics.Stopwatch.StartNew(); //ajanotto alkaa
            var sw = new Stopwatch();
            sw.Start();
            // haku 
            for (int i = 0; i < 99999999; i++)
            {
                if (taul[i] == j2)
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}", j2, i + 1);
                }
                //else Console.WriteLine("Did not found");
            }
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
            //var elapsed = timer.ElapsedMilliseconds.ToString(); // ajanotto päättyy
            //Console.WriteLine("time: " + elapsed + " ms");
        }
    }
}