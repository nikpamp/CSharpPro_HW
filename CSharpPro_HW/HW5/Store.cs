using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW5
{
    public class Store : IDisposable
    {
        private bool disposed = false;
        private string name;
        private string address;
        private string type;

        public Store(string name, string address, string type)
        {
            this.name = name;
            this.address = address;
            this.type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Store Info:\nName: {name}\nAddress: {address}\nType: {type}");
        }

        protected virtual void InternalDispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"Object {name} of class Store was disposed.");
            }
            disposed = true;
        }

        public void Dispose()
        {
            InternalDispose(true);
            GC.SuppressFinalize(this);
        }

        ~Store()
        {
            InternalDispose(false);
        }
    }
}