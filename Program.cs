
// tesk N10



Console.Write("Введите любое число: ");
string inputNumber = Console.ReadLine();

if (inputNumber.Length > 1)
{
    Console.WriteLine("вторая цифра введенного числа :" + inputNumber[1]);
}
else
{
    Console.WriteLine("данное число :" + inputNumber + " имеет менее дувх знаков и значит я не смогу показать тебе желаемого результата:");
}






// tesk N13

Console.Write("Введите любое число: ");
string inputNumber = Console.ReadLine();

if (inputNumber.Length > 2) 
{
    Console.WriteLine("Третья цифра введенного числа :" + inputNumber[2]);
}

else 
{
    Console.WriteLine("данное число :" + inputNumber + " имеет менее трёх знаков и значит я не смогу показать тебе желаемого результата:" );
}






// // tesk N15


System.Console.Write("Введите порядкоый номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1)
{
    System.Console.Write("monday: ");
}

if (dayNumber == 2)
{
    System.Console.Write("Tuesday: ");
}

if (dayNumber == 3)
{
    System.Console.Write("Wednesday: ");
}

if (dayNumber == 4)
{
    System.Console.Write("Thursday: ");
}

if (dayNumber == 5)
{
    System.Console.Write("Friday: ");
}

if (dayNumber == 6)
{
    System.Console.Write("Saturday: ");
}

if (dayNumber == 7)
{
    System.Console.Write("sunday: ");
}



if (dayNumber < 5||dayNumber==5)
{
    System.Console.Write(+dayNumber + " working ");
}

if(dayNumber==6||dayNumber==7)
{
    System.Console.Write(+dayNumber + " non-working ");
}


if (dayNumber > 7 || dayNumber == 8)
{

    System.Console.Write("в неделе нет " + dayNumber + " дней");

}