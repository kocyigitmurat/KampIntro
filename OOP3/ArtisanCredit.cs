using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi Ödeme Planı hesaplandı");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
