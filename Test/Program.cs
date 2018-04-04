using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public class PriceComparator
        {
            private PriceComparator instance;

            public PriceComparator()
            {
                instance = this;
            }

            public PriceComparator Instance
            {
                get
                {
                    return instance;
                }
            }
        }

        static void Main()
        {
            PriceComparator my = new PriceComparator();
            PriceComparator my2 = my.Instance;

            Console.ReadLine();
        }
    }
}