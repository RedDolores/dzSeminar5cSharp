// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumNumOfOddPosition(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] mass = newRandomArray(5, -99 , 100);
Console.WriteLine($"Сумма чисел на неченых позициях равна: {sumNumOfOddPosition(mass)}");
Console.WriteLine($"Массив: {string.Join(", ", mass)}");