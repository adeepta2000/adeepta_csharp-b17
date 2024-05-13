
int size = int.Parse(Console.ReadLine());

int[,] array = new int[size, size];

for (int i = 0; i < size; i++)
{
    string values = Console.ReadLine();

    string[] stringArray = values.Split(' ');

    for (int j = 0; j < stringArray.Length; j++)
    {
        array[i, j] = int.Parse(stringArray[j]);
    }
}

int firstDiagonalSum = 0;
int secondDiagonalSum = 0;

for (int i = 0; i < size; i++)
{
    firstDiagonalSum += array[i, i];
    secondDiagonalSum += array[i, size - 1 - i];
}

Console.WriteLine($"1st Diagonal Sum: {firstDiagonalSum}");
Console.WriteLine($"2nd Diagonal Sum: {secondDiagonalSum}");
