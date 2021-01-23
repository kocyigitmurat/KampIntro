using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı hesaplandı");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
