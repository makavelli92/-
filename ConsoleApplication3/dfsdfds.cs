using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class dfsdfds
    {
        class Program
        {
            private static string result;

            static void Main()
            {
                SaySomething();
                Console.WriteLine(result);
            }

            static async Task SaySomething()
            {
                await Task.Delay(5);
                result = "Hello world!";
                return “Something”;
            }
        }

    }
}
