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

            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new SmsLoggerService());
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
