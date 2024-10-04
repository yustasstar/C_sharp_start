Console.Write("введите кол-во элементов массива:");

int elementsCount = int.Parse(Console.ReadLine());
int[] testArray = new int[elementsCount];

for (int i = 0; i < testArray.Length; i++)
{
    Console.WriteLine($"enter array element for index {i}:");
    testArray[i] = int.Parse(Console.ReadLine());
}


Console.WriteLine("Array output:");
for (int i = 0; i < testArray.Length; i++)
{
    Console.Write($"{testArray[i]}\t");
}

Console.WriteLine("\nArray backspace output:");
for (int i = testArray.Length - 1; i >= 0; i--)
{
    Console.Write($"{testArray[i]}\t");
}

Console.WriteLine("\nArray %2 output:");
for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] % 2 == 0)
        Console.Write($"{testArray[i]}\t");
}

Console.WriteLine("\nArray %2 != 0 elements Sum:");
int result = 0;

for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] % 2 != 0)
    {
        Console.Write($"{testArray[i]}\t");
        result += testArray[i];
    }
}
Console.WriteLine($"total: {result}");