Console.WriteLine("Введите количество сколько прошло месяцев");
string fa = Console.ReadLine();
try 
{ 
    int n = Convert.ToInt32(fa);
    if (n > 2500)
    {
        Console.WriteLine("ERROR");
        
    }
    else
    {
        string start = "01.01.1990";
        string[] start1 = start.Split('.', 3);
        int day = Convert.ToInt32(start1[0]);
        int month = Convert.ToInt32(start1[1]);
        int kodye = 0;
        int yearint = Convert.ToInt32(start1[2]);
        while (n >= 12)
        {
            n = n - 12;
            yearint = yearint + 1;
        }
        month = month + n;
        int monthkod = 0;
        string yearstr = Convert.ToString(yearint);
        string k = Convert.ToString(yearstr[1]);
        string[] ye = yearstr.Split(k, 2);
        if (Convert.ToInt32(k) == 9)
        {
            kodye = 0;
        }
        if (Convert.ToInt32(k) == 0)
        {
            kodye = 6;
        }
        if (Convert.ToInt32(k) == 1)
        {
            kodye = 4;
        }
        int yearkod = (kodye + Convert.ToInt32(ye[1]) + Convert.ToInt32(ye[1]) / 4) % 7;
        switch (month)
        {
            case 1:
                {
                    Console.WriteLine("Январь");
                    if (DateTime.IsLeapYear(yearint) == true)
                    {
                        monthkod = 0;
                    }
                    else
                    {
                        monthkod = 1;
                    }
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Февраль");
                    if (DateTime.IsLeapYear(yearint) == true)
                    {
                        monthkod = 3;
                    }
                    else
                    {
                        monthkod = 4;
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Март");
                    monthkod = 4;
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Апрель");
                    monthkod = 0;
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Май");
                    monthkod = 2;
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Июнь");
                    monthkod = 5;
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Июль");
                    monthkod = 0;
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Август");
                    monthkod = 3;
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Сентябрь");
                    monthkod = 6;
                    break;
                }
            case 10:
                {
                    Console.WriteLine("Октябрь");
                    monthkod = 1;
                    break;
                }
            case 11:
                {
                    Console.WriteLine("Ноябрь");
                    monthkod = 4;
                    break;
                }
            case 12:
                {
                    Console.WriteLine("Декабрь");
                    monthkod = 6;
                    break;
                }
        }
        if (day < 10)
        {
            Console.Write("0");
        }
        Console.Write(day);
        Console.Write(".");
        if (month < 10)
        {
            Console.Write("0");
        }
        Console.Write(month);
        Console.Write(".");
        Console.Write(yearint);
        Console.WriteLine("");
        int dayned = (day + monthkod + yearkod) % 7;
        switch (dayned)
        {
            case 0: Console.WriteLine("Суббота"); break;
            case 1: Console.WriteLine("Воскресенье"); break;
            case 2: Console.WriteLine("Понедельник"); break;
            case 3: Console.WriteLine("Вторник"); break;
            case 4: Console.WriteLine("Среда"); break;
            case 5: Console.WriteLine("Четверг"); break;
            case 6: Console.WriteLine("Пятница"); break;
        }
        if (DateTime.IsLeapYear(yearint) == true)
        {
            Console.WriteLine("Год високосный");

        }
        else
        {
            Console.WriteLine("Год не високосный");
        }
    }
} 
catch (Exception e)
{
    Console.WriteLine("Ошибка");

}