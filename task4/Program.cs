// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите целое число:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
if(number >= 1){
    for(int i = number; i >= 1; --i){
        Console.WriteLine(i);
    }
}
else
{
    for(int i = number; i <= 1; i++){
        Console.WriteLine(i);
    }
}
