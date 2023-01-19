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