// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
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
int MaxElement(int [] array)
{
    int max = 0;
    for ( int i = 0 ; i < array.Length ; i++ )
    {
        if (array[i] > max )
        {
            max = array[i];
        }
    }
    return max;
}
int MinElement(int [] array)
{
    int min = 0;
    for ( int i = 0 ; i < array.Length ; i++ )
    {
        if (array[i] < min )
        {
            min = array[i];
        }
    }
    return min;
}
Random size = new Random(); 
Random LRange = new Random();
Random RRange = new Random();
int[] Number = arr(size.Next(3 , 15) , LRange.Next(-50 ,-30 ) , RRange.Next(0 , 100));
int maxNumber = MaxElement(Number);//  находим максимальный и минимальный элемент , с помощью описанных выше методов
int minNumber = MinElement(Number);
int diff = maxNumber - minNumber; // находим разницу между полученными значениями
Console.WriteLine(string.Join(", ",Number));
Console.WriteLine($"разница между максимальным и минимальным элементов массива = {diff}");// не стал брать модуль , разница не будет отрицательной , так как мы точно знаем что минимальное значение меньше максимального , после проделанных методов)