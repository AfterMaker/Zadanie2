using System;
using System.Security.Claims;

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Моя дата рождения.");

            const int maxAttempt = 99;
            int attempt = 0;
            int day = 27;
            int mounth = 10;
            int year = 2004;

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Какого числа мой день рождения?");
                Console.WriteLine("Попытка {0}:", attempt);

                string userString = Console.ReadLine();
                int intValue = Convert.ToInt32(userString);

                if (intValue < day)
                {
                    Console.WriteLine("Нужный результат находится выше.");
                    continue;
                }

                if (intValue > day)
                {
                    Console.WriteLine("Нужный результат находится ниже.");
                    continue;
                }

                if (intValue != day)
                {
                    continue;
                }
                Console.WriteLine("Верно.");
                break;
            }

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Какой месяц моего рождения?");
                Console.WriteLine("Попытка {0}:", attempt);

                string userString = Console.ReadLine();
                int intValue = Convert.ToInt32(userString);

                if (intValue < mounth)
                {
                    Console.WriteLine("Нужный результат находится выше.");
                    continue;
                }

                if (intValue > mounth)
                {
                    Console.WriteLine("Нужный результат находится ниже.");
                    continue;
                }

                if (intValue != mounth)
                {
                    continue;
                }
                Console.WriteLine("Верно.");
                break;
            }

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Осталось немного. Какой мой год рождения?");
                Console.WriteLine("Попытка {0}:", attempt);

                string userString = Console.ReadLine();
                int intValue = Convert.ToInt32(userString);

                if (intValue < year)
                {
                    Console.WriteLine("Нужный результат находится выше.");
                    continue;
                }

                if (intValue > year)
                {
                    Console.WriteLine("Нужный результат находится ниже.");
                    continue;
                }

                if (intValue != year)
                    Console.WriteLine("Ты угадал мою дату рождения 27.10.2004");
                Console.WriteLine("Попыток Потрачено {0}", attempt);
                break;
            }
            Console.WriteLine("End!");
        }
    }
}