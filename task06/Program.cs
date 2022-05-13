// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int numberA = new Random().Next (10, 100);
Console.WriteLine(numberA);
int digit1 = numberA / 10;
int digit2 = numberA % 10;
if (digit1 > digit2)
{
    Console.Write("Наибольшая цифра числа = ");
    Console.WriteLine(digit1);
}
else
{
   Console.Write ("Наибольшая цифра числа = "); 
   Console.WriteLine(digit2);
}