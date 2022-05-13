// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("This is Monday");
} 
if (a == 2)
{
    Console.WriteLine("This is Tuesday");
}
if (a == 3)
{
    Console.WriteLine("This is Wednesday");
} 
if (a == 4)
{
    Console.WriteLine("This is Thursday");
}
if (a == 5)
{
    Console.WriteLine("This is Friday");
}
if (a == 6)
{
    Console.WriteLine("This is Saturday");
} 
if (a == 7)
{
    Console.WriteLine("This is Sunday");
}
else 
{
    Console.WriteLine("There is no such day of the week!");
}