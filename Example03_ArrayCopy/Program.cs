// Написать программу копирования массива
int[] arr = {1, 4, 6, 5, 11};
int[] copy = arr;

void ArrayCopy(int[] array)
{
int n = arr.Length;    
for (int i = 0; i < n; i++)
{
    Console.Write($"{array[i]} ");
}
}

ArrayCopy(arr);
Console.WriteLine();
ArrayCopy(copy);