using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> items = Enumerable.Range(1, 100);
            items = Enumerable.Range(1, 10);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(items);
            items = Enumerable.Range(10, 6);
            // Console.WriteLine(items);
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            //int[] items2 = new int[] {}
        }
    }
}
