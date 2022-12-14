// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] newRandomArray(int len, int leftRan, int rightRan)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRan, rightRan + 1);
    }
    return arr;
}

int countNumOfRange(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] mass = newRandomArray(123, 0, 150);
Console.WriteLine($"Количество чисел в диапазоне от 10 до 99 равно: {countNumOfRange(mass)}");
Console.WriteLine($"Массив: {string.Join(", ", mass)}");
