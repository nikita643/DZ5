// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void DiffNumberArr(int [] array)
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
    int max = array[0];
    int min = array[0];
    for( int i =0; i < array.Length; i++ )
    {
       
        if(max < array[i]){max = array[i];}
        if(min > array[i]){min = array[i];}
    }
    int diff = max-min;
    Console.Write($" -> {diff}  ");

}
int [] AddArray(int [] array)
{
    int EnterData(string text)
    {
        Console.Write(text);
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    int sizeArr = EnterData("Введите размер масива: ");
    Array.Resize(ref array, sizeArr);
    for( int i =0; i < array.Length; i++ )
    {
        array[i] = EnterData($"Введите {i}-й элемент массива: ");
    }
    return array;
}
int [ ] array = {};
array = AddArray(array);
DiffNumberArr(array);
