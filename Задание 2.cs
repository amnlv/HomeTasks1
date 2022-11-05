//  Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
 int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
 int num_B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
 int num_C = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    if (num_A > num_C)
    {
        Console.WriteLine("Максимальное число: " + num_A);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + num_C);
    }
}

else if (num_B > num_C)
{
    Console.WriteLine("Максимальное число: " + num_B);
}
else
{
    Console.WriteLine("Максимальное число: " + num_C);
}