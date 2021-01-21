using System;

namespace DictonaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> customers = new MyDictonary<int, string>();

            customers.Add(1, "Murat");
            customers.Add(2, "Kenan");
            customers.Add(3, "Adem");

        }
    }
}
