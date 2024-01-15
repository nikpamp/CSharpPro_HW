using CSharpPro_HW.HW3;
using CSharpPro_HW.HW4;
using CSharpPro_HW.HW5;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
                // HW5
                void Test()
                {
                    Play hamlet = new Play("Hamlet", "William Shakespeare", "Tragedy", 1600);
                    hamlet.ShowInfo();
                    hamlet.Dispose();
                }
                Test();
                GC.Collect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}