﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı hesaplandı");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
