using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        double[] numbers = new double[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент массива {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        double product = 1;

        Console.WriteLine("Массив чисел:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
            sum += numbers[i];
            product *= numbers[i];
        }

        Console.WriteLine("\nСумма элементов массива: " + sum);
        Console.WriteLine("Произведение элементов массива: " + product);

        Console.ReadLine();
    }
}
