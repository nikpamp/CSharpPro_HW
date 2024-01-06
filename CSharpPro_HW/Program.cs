using CSharpPro_HW.HW3;
using CSharpPro_HW.HW4;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpPro_HW
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                // Task 1
                Employee.TestTask1();
                Console.WriteLine("---------------------------------");
                // Task 2
                City.TestTask2();
                Console.WriteLine("---------------------------------");
                // Task 3
                CreditCard.TestTask3();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}