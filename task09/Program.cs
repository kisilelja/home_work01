// Найти третью цифру числа или сообщить, что её нет 
// Был взят определенный диапозон чисел
int Number = new Random().Next(1, 2000);
Console.WriteLine($"Дано число: {Number}");

if (Number  > 99 && Number < 1000 ) 
{
    
    Console.WriteLine($"Третья цифра: {Number % 10}");
}
if (Number > 1000 ) 
{
    
    Console.WriteLine($"Третья цифра: {Number / 10 % 10}");
}
if (Number < 100)
{
    Console.WriteLine("У числа нет третьей цифры!");
}