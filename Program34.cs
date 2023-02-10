// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[10];
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
   arr[i] = new Random().Next(100, 999); 
}
Console.WriteLine(string.Join(' ', arr));


int count = 0;
for (int i = 0; i < arr.Length; i++)
   
   {
    if ((arr[i] % 2 == 0) )
    {
        count = count + 1; 
    } 

   }
Console.WriteLine($"Количесво четных чисел в массиве --> {count}\n");


// void FillArray(int[] collection)
// {
// int length = collection.Length;
// int index = 0;
// while (index < length)

// {
//  collection[index] = new Random().Next(1, 10);

//  index++;
// }
// }
