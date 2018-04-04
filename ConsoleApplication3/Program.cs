using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ForExperimentInConsole
{
    static class Program
    {
        static string StringReverse(string str)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            return builder.ToString();
        }
        static double GetTimeAngle(double hour, double minut)
        {
            if (hour > 12)
                hour -= 12;
            double hourAngle = (360 / 12 * hour) + (30 * minut / 60);
            double minutAngle = 360 / 60 * minut;
            return Math.Abs(hourAngle - minutAngle);
        }
        static string StringRevrse(string str)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            return builder.ToString();
        }
        static string ReverseValue(this string str)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                builder.Append(str[i]);
            }
            return String.Format(builder.ToString());
        }
        static double GetAngle(double hour, double minuts)
        {
            if (hour > 12)
                hour -= 12;
            double hourAngle = 360 / 12 * hour + (360 / 12 * minuts / 60);
            double minutsAngle = 360 / 60 * minuts;
            return Math.Abs(hourAngle - minutsAngle);
        }
        public static bool Polyndrom(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                int j = str.Length - i - 1;
                if (i == j && str[i] == str[j])
                    return true;
                if (str[i] != str[j])
                    return false;
            }
            return true;
        }
        static void ShowInfo(string path)
        {
            string path2 = @"C:\Test";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] info = dir.GetFiles();
            foreach (var i in info)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2}", i, i.CreationTime.ToString("dd/MM/yyyy"), i.Length / 1024);
            }
        }

        // Группа товаров – таблица Groups
        class Group
        {
            public int Id;
            public string Name;
        }

        // Товар – таблица Products
        class Product
        {
            public int Id;
            public string Name;
            public int GroupId; // Идентификатор группы товаров (внешний ключ)
        }

        static void Main(string[] args)
        {
            List<int> productIds = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            IEnumerable<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1, Name = "milk", GroupId = 1
                },
                new Product()
                {
                    Id = 2, Name = "fish", GroupId = 2
                },
                new Product()
                {
                    Id = 3, Name = "sugar", GroupId = 3
                }
            };
            IEnumerable<Group> groups = new List<Group>()
            {
                new Group()
                {
                    Id = 1, Name = "M"
                },
                new Group()
                {
                    Id =3, Name = "S"
                }
            };

            var result = products.Where(x => productIds.Contains(x.Id));

            //  foreach (var i in result)
            //      Console.WriteLine("{0} {1}",i.Id, i.Name);

            var result2 = products.Join(groups, x => x.Id, y => y.Id, (x, y) => new { ProductName = x.Name, GroupName = y.Name });
            foreach (var i in result2)
            {
                Console.WriteLine("{0} {1}", i.ProductName, i.GroupName);

            }
            var result3 = products.GroupBy(x => x.Name);
            foreach(var i in result3)
            {
                Console.WriteLine(i.Key);
                foreach (var g in i)
                    Console.WriteLine("{0} {1}",g.Id, g.GroupId);
            }

            Console.ReadLine();
        }
    }
}
