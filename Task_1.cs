/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

//Заполняем массив рандомными значениями
int[] fillArrayNumbersRandom(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

//Выводим массив 1 способ
void PrintArrayToConsole(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int getEvenNumbers(int[] array)
{
    int count = 0;
    for (int z = 0; z < numbers.Length; z++)
        if (numbers[z] % 2 == 0)
            count++;
    return count;
}
fillArrayNumbersRandom(numbers);
Console.Write("Вот ваш массив: ");
PrintArrayToConsole(numbers);

/*Второй способ вывести массив
Console.WriteLine("[{0}]", string.Join(", ", numbers));*/


Console.WriteLine($"В масииве {numbers.Length} чисел, из них чётных - {getEvenNumbers(numbers)}.");

