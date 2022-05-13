// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int result = 0;
if (a > 99 && a < 1000)
{
    result = (a / 10) % 10;
    Console.Write ("Вторая цифра 3хзначного числа: ");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine ("Это не трехзначное число!");
}