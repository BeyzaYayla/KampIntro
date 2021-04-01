using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(ihtiyacKrediManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { ihtiyacKrediManager, tasitKrediManager };
            //applyManager.CreditPreInform(credits);
        }
    }
}
