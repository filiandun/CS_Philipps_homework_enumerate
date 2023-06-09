using System.Text.RegularExpressions;

namespace Homework
{
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }



    internal class Program
    {
        static void Main()
        {
            List<int> date = new List<int>(3);

            while (true)
            {
                Console.Write("Введите дату в формате 30.04.2023: ");
                string input = Console.ReadLine().Trim();

                string pattern = @"^[0-3]?[0-9].[0-1]?[0-9].[0-9]+$";
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    foreach (string str in input.Split('.'))
                    {
                        date.Add(Convert.ToInt32(str));
                    }

                    if (date[0] <= 31 && date[0] != 0)
                    {
                        if (date[1] <= 12 && date[1] != 0)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("Ваша дата неверна!\n");
            }
  


            Console.Write($"\nМесяц:\t\t");
            switch (date[1])
            {
                case (int)Months.February: Console.WriteLine("февраль"); break;
                case (int)Months.January: Console.WriteLine("январь"); break;
                case (int)Months.March: Console.WriteLine("март"); break;
                case (int)Months.April: Console.WriteLine("апрель"); break;
                case (int)Months.May: Console.WriteLine("май"); break;
                case (int)Months.June: Console.WriteLine("июнь"); break;
                case (int)Months.July: Console.WriteLine("июль"); break;
                case (int)Months.August: Console.WriteLine("август"); break;
                case (int)Months.September: Console.WriteLine("сентябрь"); break;
                case (int)Months.October: Console.WriteLine("октябрь"); break;
                case (int)Months.November: Console.WriteLine("ноябрь"); break;
                case (int)Months.December: Console.WriteLine("декабрь"); break;
            }


            Console.Write($"Время года:\t");
            switch (date[1] / 3 + 1)
            {
                case 1: Console.WriteLine("зима"); break;
                case 2: Console.WriteLine("весна"); break;
                case 3: Console.WriteLine("лето"); break;
                case 4: Console.WriteLine("осень"); break;
                case 5: Console.WriteLine("зима"); break;
            }


            Console.Write($"День недели:\t");
            int dayOfWeek = (7000 + (date[0] + (date[2] - (14 - date[1]) / 12) + (date[2] - (14 - date[1]) / 12) / 4 - (date[2] - (14 - date[1]) / 12) / 100 + (date[2] - (14 - date[1]) / 12) / 400 + (31 * (date[1] + 12 * ((14 - date[1]) / 12) - 2)) / 12)) % 7;
            switch (dayOfWeek)
            {
                case (int)DayOfWeek.Sunday: Console.WriteLine("воскресенье"); break;
                case (int)DayOfWeek.Monday: Console.WriteLine("понедельник"); break;
                case (int)DayOfWeek.Tuesday: Console.WriteLine("вторник"); break;
                case (int)DayOfWeek.Wednesday: Console.WriteLine("среда"); break;
                case (int)DayOfWeek.Thursday: Console.WriteLine("четверг"); break;
                case (int)DayOfWeek.Friday: Console.WriteLine("пятница"); break;
                case (int)DayOfWeek.Saturday: Console.WriteLine("суббота"); break;
            }
        }
    }
}