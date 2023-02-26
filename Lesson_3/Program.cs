//1. По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите предпологаемый квадрат числа: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите само числo: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number * number == square)
{
System.Console.WriteLine($"{square} является квадратом {number}");}
else
{System.Console.WriteLine($"{square} не является квадратом {number}");
}
