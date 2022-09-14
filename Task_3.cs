/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];


int[] fillArrayRandomNumbers(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 20);
    }
    return array;
}


fillArrayRandomNumbers(numbers);
Console.Write("Наш массив: ");
Console.WriteLine("[{0}]", string.Join(", ", numbers));


int[] getMultiplication(int[] array)
{
    int size = array.Length;
    int sizeNew;
    sizeNew = size / 2;


    if (size % 2 == 0)
    {
        int[] result = new int[sizeNew];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[size - 1 - i];
        }
        return result;
    }
    else
    {
        int[] result = new int[sizeNew + 1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[size - 1 - i];
        }
        result[sizeNew] = array[size / 2];
        return result;
    }

}
int[] newArray = getMultiplication(numbers);

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}