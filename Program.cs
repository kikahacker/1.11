/*Console.WriteLine("Введите дату рождения в формате xx.xx.xxxx");
string bith = Console.ReadLine();
if (bith.Length != 10 || (bith[2] != '.' && bith[5] != '.') || bith[7] < 9)
{
    Console.WriteLine("Неверный формат");
}
else
{
    string[] bith2 = bith.Split('.', 3);
    int day = Convert.ToInt32(bith2[0]);
    int month = Convert.ToInt32(bith2[1]);
    int year = Convert.ToInt32(bith2[2]);
    string[] zodiac = ["Козерог", "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец"];
    string[] animals = ["Крыса", "Бык", "Тигр", "Кролик", "Дракон", "Змея", "Лошадь", "Обезьяна", "Петух", "Собака", "Кабан"];
    string[] color = ["Металл", "Вода", "Дерево", "Огонь", "Земля"];
    int x = year - 1900;
    while (x >= 12)
    {
        x = x - 12;
    }
    int y = year - 1900;
    while (y >= 10)
    {
        y = y - 10;
    }
    Console.WriteLine("Ваш знак зодиака:");

    switch (month)
    {
        case 01:
            if (day <= 20)
            {
                Console.WriteLine(zodiac[0]);
            }
            else
            {
                Console.WriteLine(zodiac[1]);
            }
            break;

        case 02:
            if (day <= 18)
            {
                Console.WriteLine(zodiac[1]);
            }
            else
            {
                Console.WriteLine(zodiac[2]);
            }
            break;

        case 03:
            if (day <= 20)
            {
                Console.WriteLine(zodiac[2]);
            }
            else
            {
                Console.WriteLine(zodiac[3]);
            }
            break;

        case 04:
            if (day <= 20)
            {
                Console.WriteLine(zodiac[3]);
            }
            else
            {
                Console.WriteLine(zodiac[4]);
            }
            break;

        case 05:
            if (day <= 20)
            {
                Console.WriteLine(zodiac[4]);
            }
            else
            {
                Console.WriteLine(zodiac[5]);
            }
            break;

        case 06:
            if (day <= 21)
            {
                Console.WriteLine(zodiac[5]);
            }
            else
            {
                Console.WriteLine(zodiac[6]);
            }
            break;

        case 07:
            if (day <= 22)
            {
                Console.WriteLine(zodiac[6]);
            }
            else
            {
                Console.WriteLine(zodiac[7]);
            }
            break;

        case 08:
            if (day <= 22)
            {
                Console.WriteLine(zodiac[7]);
            }
            else
            {
                Console.WriteLine(zodiac[8]);
            }
            break;

        case 09:
            if (day <= 23)
            {
                Console.WriteLine(zodiac[8]);
            }
            else
            {
                Console.WriteLine(zodiac[9]);
            }
            break;

        case 10:
            if (day <= 23)
            {
                Console.WriteLine(zodiac[9]);
            }
            else
            {
                Console.WriteLine(zodiac[10]);
            }
            break;

        case 11:
            if (day <= 22)
            {
                Console.WriteLine(zodiac[10]);
            }
            else
            {
                Console.WriteLine(zodiac[11]);
            }
            break;

        case 12:
            if (day <= 21)
            {
                Console.WriteLine(zodiac[11]);
            }
            else
            {
                Console.WriteLine(zodiac[0]);
            }
            break;


    }
    Console.WriteLine("Ваше животное по китайскому каллендарю:");
    if (x == 0)
    {
        string anim = animals[x];
        Console.WriteLine(anim);
    }
    else
    {
        string anim = animals[x - 1];
        Console.WriteLine(anim);
    }
    Console.WriteLine("Ваша стихия");
    if (y > 4)
    {
        y = y / 2;
        string col = color[y];
        Console.WriteLine(col);
    }
    else 
    {
        string col = color[y];
        Console.WriteLine(col);
    }
}
*/