// Задайте массив натуральных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


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

int diffOfMinAndMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    int result = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else if(array[i] > max) max = array[i];
    }
    return result = max - min;
}

int[] mass = newRandomArray(5, 0, 100);
Console.WriteLine($"Разница максимального и минимального чисел равна: {diffOfMinAndMax(mass)}");
Console.WriteLine($"Массив: {string.Join(", ", mass)}");