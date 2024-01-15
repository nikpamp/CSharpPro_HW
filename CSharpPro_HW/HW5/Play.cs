using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPro_HW.HW5
{
    public class Play : IDisposable
    {
        private bool disposed = false;
        private string name;
        private string author;
        private string genre;
        private int year;
        public Play(string name, string author, string genre, int year)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }

        public int GetAge()
        {
            DateTime dateTime = DateTime.Now;
            int age = dateTime.Year - year;
            return age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Play Info:\nName: {name}\nAuthor: {author}\nGenre: {genre}\nYear: {year}\nAge: {GetAge()}");
        }

        protected virtual void InternalDispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine($"Object {name} of class Play was disposed.");
            }
            disposed = true;
        }

        public void Dispose()
        {
            InternalDispose(true);
            GC.SuppressFinalize(this);
        }

        ~Play()
        {
            InternalDispose(false);
        }
    }
}