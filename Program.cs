using System;

namespace CurrencyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Döviz Hesaplaması");
            Console.WriteLine("ALIM FİYAT; Dolar = 8.1₺," + " Euro = 9.5,");
            Console.WriteLine("SATIŞ FİYAT; Dolar = 8.3₺," + " Euro = 9.7,");
            Console.WriteLine("Hangi para birimiyle işlem yapmak istiyorsunuz ?" +
                              "\n1: Dolar Alım-Satım" +
                              "\n2: Euro Alım-Satım");
            double balance;
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ?" +
                                      "\n1- Dolar Alım" +
                                      "\n2- Dolar Satım");
                    double newBalance;
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Bozdurmak istediğiniz Dolar miktarını giriniz.");
                            balance = Convert.ToDouble(Console.ReadLine());
                            newBalance = balance * 8.1;
                            Console.WriteLine("Fiş; "+balance + "*8.1 = " + newBalance+" ₺");
                            break;
                        case "2":
                            Console.WriteLine("Yatırmak istediğiniz TL miktarını giriniz.");
                            balance = Convert.ToDouble(Console.ReadLine());
                            newBalance = balance / 8.2;
                            Console.WriteLine("Fiş; "+balance + "/8.3 = " + newBalance+" $");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ?" +
                                      "\n1- Euro Alım" +
                                      "\n2- Euro Satım");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Bozdurmak istediğiniz Euro miktarını giriniz.");
                            balance = Convert.ToDouble(Console.ReadLine());
                            newBalance = balance * 9.5;
                            Console.WriteLine("Fiş; "+balance + "*9.5 = " + newBalance+" ₺");
                            break;
                        case "2":
                            Console.WriteLine("Yatırmak istediğiniz TL miktarını giriniz.");
                            balance = Convert.ToDouble(Console.ReadLine());
                            newBalance = balance / 9.7;
                            Console.WriteLine("Fiş; "+balance + "/9.7 = " + newBalance+" $");
                            break;
                    }                    
                    break;
            }
        }
    }
}