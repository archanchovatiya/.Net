using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            CarSalesman csalesman = new CarSalesman("steven", "stainwood");
            csalesman.sell();
            Console.WriteLine();
            RetailSalesman rsalesman = new RetailSalesman("baron", "corbin");
            rsalesman.sell();
            Console.ReadKey();
        }
    }
}
