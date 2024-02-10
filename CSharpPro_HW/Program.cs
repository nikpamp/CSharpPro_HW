using CSharpPro_HW.HW3;
using CSharpPro_HW.HW4;
using CSharpPro_HW.HW5;
using CSharpPro_HW.HW6;
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
                // HW6
                var barbershop = new Barbershop();
                var barberThread = new Thread(barbershop.Barber);
                barberThread.Start();

                Thread.Sleep(1000);

                for (int i = 0; i < 10; i++)
                {
                    var customerThread = new Thread(barbershop.Customer);
                    customerThread.Start();
                    Thread.Sleep(300);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}