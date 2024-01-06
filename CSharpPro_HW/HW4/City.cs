using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW4
{
    public class City
    {
        public string CityName {  get; set; }

        public int Population {  get; set; }

        public static City operator +(City city, int increment)
        {
            city.Population = city.Population + increment;
            return city;
        }

        public static City operator -(City city, int decrement)
        {
            city.Population = city.Population - decrement;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public static void TestTask2()
        {
            var odesa = new City();
            odesa.Population = 1000000;
            int popIncr = 456321;
            odesa = odesa + popIncr;
            Console.WriteLine(odesa.Population);
            int popDecr = 123654;
            odesa = odesa - popDecr;
            Console.WriteLine(odesa.Population);

            var kyiv = new City();
            kyiv.Population = 3500000;
            bool isEqualPopulation = odesa == kyiv;
            Console.WriteLine(isEqualPopulation);

            var lviv = new City();
            lviv.Population = 1100000;
            bool isDiffPopulation = odesa > lviv;
            Console.WriteLine(isDiffPopulation);
        }
    }
}