using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {

        public void Application(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CreditFrontInfo(List<ICreditManager> creditManager)
        {
            foreach(ICreditManager credit in creditManager)
            {
                credit.Calculate();
            }
        }
    }
}
