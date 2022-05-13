// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите  число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число B: ");
int B = int.Parse(Console.ReadLine());
if (A / B == B)
{
    Console.WriteLine("Число A является квадратом числа B");
}
else
{
    Console.WriteLine("Число A не является квадратом числа B");
};
