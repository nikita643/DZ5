// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void WriteArray (int [] array)
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
    int temp = 0;
    for( int i =0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0) {temp++;}
    }
    Console.Write($" -> {temp}  ");
}
int [] AddArray(int [] array)
{
    Console.Write("Ведите размер массива: ");
    int sizeArr = int.Parse(Console.ReadLine());
    for( int i =0; i < sizeArr; i++ )
    {
        Random rnd = new Random();
        Array.Resize(ref array, sizeArr);
        array[i] = rnd.Next(100,999);
    }
    return array;
}
int [] array = {};
array = AddArray(array);
WriteArray(array);