using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW4
{
    public class CreditCard
    {
        public double Balance { get; set; }
        public short CVC { get; set; }

        public static CreditCard operator +(CreditCard card1, double increment)
        {
            card1.Balance = card1.Balance + increment;
            return card1;
        }

        public static CreditCard operator -(CreditCard card1, double decrement)
        {
            card1.Balance = card1.Balance - decrement;
            return card1;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVC != card2.CVC;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static void TestTask3()
        {
            var privat = new CreditCard();
            privat.Balance = 987.41;
            double bonus = 321.47;
            privat = privat + bonus;
            Console.WriteLine(privat.Balance);
            double penalty = 125.89;
            privat = privat - penalty;
            Console.WriteLine(privat.Balance);

            var mono = new CreditCard();
            mono.Balance = 789.63;
            bool isEqualBalance = privat > mono;
            Console.WriteLine(isEqualBalance);

            privat.CVC = 753;
            mono.CVC = 159;
            bool isEqualCVC = privat == mono;
            Console.WriteLine(isEqualCVC);
        }
    }
}