using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratando_entradas_de_Console.ReadLine__
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 + num2);

            }
            catch (Exception)
            {
                Console.WriteLine("Utilize apenas números");
            }
            Console.ReadKey();

        }
    }
}
