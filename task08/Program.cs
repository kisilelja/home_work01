// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите проверяемое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  число - делитель: ");
int B = int.Parse(Console.ReadLine());
if (A % B == 0)
{
    Console.WriteLine($"{A} кратно {B}");
}
else
{
    int C = A % B;
    Console.WriteLine($"Остаток от деления = {C}");
}