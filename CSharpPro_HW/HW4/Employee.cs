using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW4
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public static Employee operator +(Employee emp1, int increment)
        {
            emp1.Salary = emp1.Salary + increment;
            return emp1;
        }

        public static Employee operator -(Employee emp1, int decrement)
        {
            emp1.Salary = emp1.Salary - decrement;
            return emp1;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Salary == emp2.Salary;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Salary != emp2.Salary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }

        public static void TestTask1()
        {
            var sasha = new Employee();
            sasha.Salary = 100;
            int incr = 10;
            sasha = sasha + incr;
            Console.WriteLine(sasha.Salary);
            int decr = 5;
            sasha = sasha - decr;
            Console.WriteLine(sasha.Salary);

            var masha = new Employee();
            masha.Salary = 105;
            bool isEqualSalary = sasha == masha;
            Console.WriteLine(isEqualSalary);

            var dasha = new Employee();
            dasha.Salary = 150;
            bool isDiffSalary = sasha > dasha;
            Console.WriteLine(isDiffSalary);
        }
    } 
}