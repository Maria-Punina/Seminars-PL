// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// 1. Создадим случайное число
// 2. Разложим наше число на десятки сотни тысячи .... 
// 3. Сложим все элементы 
// 4. Выводим результат в терминал

int Promt(string message)         
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput); //int.Parse аналог Convert.ToInt32
    return result;
}

int SumAllNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {                                                                                                                                           // 3
        result+= number % 10; 
        number = number / 10;    
    }
    return result; 
}
int number = Promt("Введи число: ");
Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllNumbers(number)}"); 