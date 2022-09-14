// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
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
int negativeIndex(int [] array)
{
    int summ = 0;
    for ( int i = 0 ; i < array.Length ; i++ )
    {
        if (i % 2 != 0 )
        {
            summ +=array[i];
        }
    }
    return summ;
    // в прошлый раз делал через 
    //i = 1; while (i < .Length) 
    //summ = summ + array[i]
    //i+=2
    //В этот раз решил сделать так , пришел к выводу , что если вариант нужен где-то ещё - тут проще и быстрее изменить , тем более все задачи аналогичны)) 
}
Random size = new Random(); // по условию не задан размер , играюсь с рандомом)
Random LRange = new Random();// <= и всё аналогично размеру :D
Random RRange = new Random();
int[] Number = arr(size.Next(3 , 15) , LRange.Next(-50 ,-30 ) , RRange.Next(0 , 100));
int NegSumm = negativeIndex(Number);
Console.WriteLine(string.Join(", ",Number));
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {NegSumm}");