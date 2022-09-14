// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] arr( int size , int minN , int maxN)
{
    int[] array = new int[size];
    Random Numb = new Random();
    for(int i = 0 ; i < size ; i++)
    {
        array[i] = Numb.Next(minN , maxN +1);
    }
    return array;
}
int countRange(int [] array)
{
    int count = 0;
    for ( int i = 0 ; i < array.Length ; i++ )
    {
        if (array[i] > 9 && array[i] < 100 )
        {
            count++;
        }
    }
    return count;
}
int[] Number = arr(123 , 0 , 150);
int countR = countRange(Number);
Console.WriteLine(string.Join(",  ",Number));
Console.WriteLine($"Колл-во элементов массива, значения которых лежат в отрезке [10,99] - {countR}");