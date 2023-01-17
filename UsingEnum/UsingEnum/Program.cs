//Using enum



enum WeekDay
{
    SUN = 1,
    MON = 2,
    TUE = 3,
    WED = 4,
    THU = 5,
    FRI = 6,
    SAT = 7
}


WeekDay day = WeekDay.TUE;
switch (day)
{
    case WeekDay.SUN:
        Console.WriteLine("星期日為一周的第{0}天!!", (int)WeekDay.SUN);
        break;
    case WeekDay.TUE:
        Console.WriteLine("星期日為一周的第{0}天!!", (int)WeekDay.TUE);
        break;
    default:
        Console.WriteLine("一周的第{0}天!!", (int)day);
        break;
}