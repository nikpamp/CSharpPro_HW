using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW6
{
    public class Barbershop
    {
        Semaphore customers = new Semaphore(0, 10);
        Semaphore barber = new Semaphore(0, 1);
        Semaphore mutex = new Semaphore(1, 1);
        int waiting = 0;

        public void Barber()
        {
            while (true)
            {
                customers.WaitOne();
                mutex.WaitOne();
                waiting--;
                mutex.Release();
                barber.Release();
                Console.WriteLine("Barber is cutting hair");
                Thread.Sleep(2000);
                Console.WriteLine("Barber finished haircut");
            }
        }

        public void Customer()
        {
            mutex.WaitOne();
            if (waiting < 3)
            {
                waiting++;
                customers.Release();
                mutex.Release();
                barber.WaitOne();
                Console.WriteLine("Barber starts haircutting for the customer");
            }
            else
            {
                mutex.Release();
                Console.WriteLine("No available chairs, customer leaves");
            }
        }
    }
}