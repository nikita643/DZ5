// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void ArraySumm( int [] array )
{
    Console.Write("[");
    for( int i =0; i < array.Length; i++ )
    {
        if((array.Length - 1) > i )
        {
            Console.Write($"{array[i]}, ");
        }
        else{Console.Write($"{array[i]}");}
    }
    Console.Write("]");
    int tempVar = 0;
    for( int i =1; i < array.Length; i+=2 )
    {
        tempVar = tempVar + array[i];
    }
    Console.Write($" -> {tempVar}  ");

}
int [] AddArray(int [] array)
{
    int EnterData(string text)
    {
        Console.Write(text);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int sizeArr = EnterData("Введите размер массива: ");
    int rndMin = EnterData("Введите минимальное значение случайного числа: ");
    int rndMax = EnterData("Ведите максимальное значение случайного числа: ");
    Array.Resize(ref array, sizeArr);
    for( int i =0; i < sizeArr; i++ )
    {
        Random rnd = new Random();
        array[i] = rnd.Next(rndMin,rndMax);
    }
    return array;
}
int [] array = {};
array = AddArray(array);
ArraySumm(array);
