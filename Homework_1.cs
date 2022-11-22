//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее


// Console.Write("Input first number ");
// int FirNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number ");
// int SecNum = Convert.ToInt32(Console.ReadLine());

// if (FirNum < SecNum)
// {
//     Console.WriteLine($"{FirNum}, {SecNum} -> max = {SecNum}");
// }
// else
// {
//     Console.WriteLine($"{FirNum}, {SecNum} -> max = {FirNum}");
// }


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Console.Write("Input first number ");
// int FirNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number ");
// int SecNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input third number ");
// int ThirdNum = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if (FirNum < SecNum)
// {
//     if (SecNum < ThirdNum)
//     {
//         max = ThirdNum; // макс третье число
//     }
        
//     else
//         max = SecNum; // макс второе число
// }
// else
// max = FirNum; // макс первое число

// Console.Write($"{FirNum}, {SecNum}, {ThirdNum} - > {max}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input first number ");
// int Num = Convert.ToInt32(Console.ReadLine());

// if (Num % 2 == 0)
// {
//     Console.Write($"{Num} -> чётное");
// }   
// else
// {
//     Console.Write($"{Num} -> нечётное");
// }
// Num += 1;        
    

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input first number ");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= Num)
{
    if (count % 2 == 0)
    { 
        Console.Write($"{count}, ");
    }
    count += 1;
}

//Задача 13. 

// Console.WriteLine(457%10);
