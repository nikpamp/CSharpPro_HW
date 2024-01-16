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
                // HW5 Task 1
                void Test()
                {
                    Play hamlet = new Play("Hamlet", "William Shakespeare", "Tragedy", 1600);
                    hamlet.ShowInfo();
                    hamlet.Dispose();
                }
                Test();
                Console.WriteLine();

                // HW5 Task 2
                StoreType foodStore = new StoreType("Food Store");
                StoreType economicStore = new StoreType("Economic Store");
                StoreType clothesStore = new StoreType("Clothes Store");
                StoreType footwearStore = new StoreType("Footwear Store");

                void Test2()
                {
                    Store atb = new Store("ATB", "21 Shevchenko Avenue", foodStore.storeType);
                    atb.ShowInfo();
                    atb.Dispose();
                }
                Test2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}