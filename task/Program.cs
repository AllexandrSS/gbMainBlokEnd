using System;

class Program
{
    static void Main()
    {
        int n = 3;
        Console.Clear();
        Console.WriteLine("Введите строки массива через пробел:");
        string input = Console.ReadLine()!;
        string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= n)
            {
                count++;
            }
        }
       
        string[] resultArray = new string[count];
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= n)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }
       
        Console.Clear();
        Console.WriteLine($" Это введённый Вами массив и результирующий массив  состоящий из {n} и менее символов :" );
        Console.WriteLine();
        Console.WriteLine($"[ {String.Join(", ", inputArray)} ] -> [ {String.Join(", ", resultArray)} ]");
        Console.ReadLine();
    }
}