using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>();
            loggers.Add(databaseLoggerService);
            loggers.Add(fileLoggerService);
            loggers.Add(smsLoggerService);

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(consumerCreditManager, loggers);

            List<ICreditManager> creditList = new List<ICreditManager>();
            creditList.Add(consumerCreditManager);
            creditList.Add(vehicleCreditManager);
            creditList.Add(mortgageCreditManager);


            //applicationManager.CreditFrontInfo(creditList);

        }
    }
}
