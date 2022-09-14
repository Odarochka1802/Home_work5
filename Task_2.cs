/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int[] fillArrayRandomNumbers(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,20);
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


// Нечетную позицию я брала по индексу в массиве
int getSumOddNumbers(int[] array)
{
    int sum = 0;
    for (int z = 1; z < array.Length; z += 2) //Начинаем с нечетного идекса [1] и далее +2 к индексу
        sum = sum + array[z];
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

fillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArrayToConsole(numbers);
/*Второй способ вывести массив
Console.WriteLine("[{0}]", string.Join(", ", numbers));*/

Console.WriteLine($"В массиве {numbers.Length} чисел, сумма элементов на нечётных позициях = {getSumOddNumbers(numbers)}");