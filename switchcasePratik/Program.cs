using System;

namespace switchcasePratik
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Geçersiz komut");
                    break;
            }

            int month2 = DateTime.Now.Month;
            switch (month2)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız.");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız.");
                    break;
                case 9:
                    Console.WriteLine("Eylül ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız.");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış veri gişi");
                    break;
            }
        }
    }
}
