//Удалить вторую цифру трехзначного числа. 
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());
int firstDigit = a / 10 / 10;
int secondDigit = (a/10) % 10;
int thirdDigit = a % 10;
if (a <= 999 && a >= 100)
{
    Console.Write($"Полученное число = {firstDigit}{thirdDigit}");
}
else
{
    Console.WriteLine("Увы, это не трех значное число!");
}