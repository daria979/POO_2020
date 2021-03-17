using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Stars
    {
        public Stars(int n)
        {
            this.n = n;
        }

        int n;

        ~Stars()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduceti un numar: ");
            n = int.Parse(Console.ReadLine());
            Stars s = new Stars(n);
        }
    }
}
