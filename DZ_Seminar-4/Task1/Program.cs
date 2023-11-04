// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 
// 2, 4 -> 16

void numberAB(double a , double b)
{
    
    while(a < 10 && b < 10)
    {
        double result = Math.Pow(a,b);
        Console.WriteLine($" {a} ^ {b} = {result}");
        a++;
        b++;
    }
  
}

Console.Write("Введите число A : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B : ");
double y = Convert.ToDouble(Console.ReadLine());
numberAB(x,y);
