using CSharpPro_HW.HW3;
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
                int[] testArr = { 21, 29, 73, 46, 51, 62, 18 };
                var myArr = new MyArray(testArr);
                myArr.Show();
                string myInfo = "Information";
                myArr.Show(myInfo);

                // Task 2
                myArr.Max();
                myArr.Min();
                myArr.Avg();
                myArr.Search(62);

                // Task 3
                myArr.SortAsc();
                myArr.SortDesc();
                myArr.SortByParam(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
