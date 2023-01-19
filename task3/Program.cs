//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
double numberB = number % 2;

if (numberB == 0){
    Console.WriteLine("Это число четное");    
}
else
{
    Console.WriteLine("Это число не четное");
}
