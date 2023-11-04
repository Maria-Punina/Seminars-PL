// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1,k1,b2 и k2
// задаются пользователем. 



double[] EnterNumbers() 
{
    Console.Write("Введите через , b1, k1, b2, k2 ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(","); 
    double[] numbers = new double[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(arrayNumbers[i]);
    }
    return numbers;
}

void LinearEquation(double [] array)
{
double b1 = array[0]; // 0
double k1 = array[1]; // 1 
double b2 = array[2]; // 2
double k2 = array[3]; // 3 
double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Прямые пересекаются в точке x = {x} y = {y}");
}
double[] num = EnterNumbers();
LinearEquation(num);