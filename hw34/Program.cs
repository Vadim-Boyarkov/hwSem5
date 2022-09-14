// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
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
int amountEven(int [] array)
{
    int count = 0;
    for ( int i = 0 ; i < array.Length ; i++ )
    {
        if (array[i] % 2 == 0 )
        {
            count++;
        }
    }
    return count;
}
Random size = new Random();
int[] Number = arr(size.Next(3 , 10) , 100 , 999);
int Even = amountEven(Number);
Console.WriteLine(string.Join(", ",Number));
Console.WriteLine($"Колл-во четных чисел в массиве - {Even}");
