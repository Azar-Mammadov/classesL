using System;

namespace classesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Home a = new Home();
            a.unvan= "Akim Abbasov kuce 7 \n";
            a.telefon = "+994 55 111 11 11 \n";
            a.sheher = "Baku";
            Console.WriteLine(a.method());
        }

    }
}
