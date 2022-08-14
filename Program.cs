

// // tesk N2

Console.Write("Введите любое первое число для сровнения: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое второе число для сровнения: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine(numberA+">"+numberB+":"+numberA+"=max number");

    System.Console.WriteLine();
}
else
{
    Console.WriteLine(numberA+"<"+numberB+":"+numberB+"=max number");

}





// // // tesk N8

System.Console.Write("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;

while (start <= N)
{
    if (start % 2 == 0)

        Console.WriteLine(start);
    start++;

}


// tesk N4



System.Console.WriteLine("введите первое числа для сровнения");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе числа для сровнения");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите третье числа для сровнения");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;

if (A<B) max=B;
if (max<C) max=C;
System.Console.WriteLine(+max+"=max number");



// tesk N6



System.Console.WriteLine("введите число для определения чётности: ");
int z = Convert.ToInt32(Console.ReadLine());


if (z % 2 == 0) 
{
    System.Console.WriteLine(+z+ ": является чётным.");
}
else
{
 System.Console.WriteLine(+z+ ": не является чётным числом.");

}

    

