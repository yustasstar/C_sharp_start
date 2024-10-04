Console.Write("введите кол-во элементов массива:\t");

int elementsCount = int.Parse(Console.ReadLine());
int[] testArray = new int[elementsCount];

for (int i = 0; i < testArray.Length; i++)
{
    Console.WriteLine($"enter array element for index {i}:\t");
    testArray[i] = int.Parse(Console.ReadLine());
}



Console.WriteLine("Array output:");


for (int i = 0; i < testArray.Length; i++)
{
    Console.WriteLine($"{testArray[i]}\t");
}
