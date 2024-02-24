using System;

class Program
{
    static void Main()
    {
        // Tests
        Console.WriteLine(GetDateFromDay(34));
        Console.WriteLine(GetDateFromDay(1));
        Console.WriteLine(GetDateFromDay(10));
        Console.WriteLine(GetDateFromDay(65));
        Console.WriteLine(GetDateFromDay(300));
        Console.WriteLine(GetDateFromDay(360));
        Console.WriteLine(GetDateFromDay(365));

    }

    static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }

    static string GetDateFromDay(int day)
    {
        int[] daysPerMonth;
        int year = DateTime.Now.Year;
        if (IsLeapYear(year))
        {
            daysPerMonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }
        else
        {
            daysPerMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        }

        int month = 1;
        int remainingDays = day;
        while (remainingDays > daysPerMonth[month - 1])
        {
            remainingDays -= daysPerMonth[month - 1];
            month++;
        }

        return $"{remainingDays.ToString("00")} {new DateTime(year, month, 1).ToString("MMMM")}";
    }
}
