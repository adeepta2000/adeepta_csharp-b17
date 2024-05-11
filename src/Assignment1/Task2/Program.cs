
string input = Console.ReadLine();

string[] numbers = input.Split(',');

for(int i = 0;  i < numbers.Length; i++)
{
    numbers[i] = numbers[i].Trim();
}

int[] values = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    values[i] = int.Parse(numbers[i]);
}

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - i - 1; j++)
    {
        if (values[j] < values[j + 1])
        {
            int temp = values[j];
            values[j] = values[j + 1];
            values[j + 1] = temp;
        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(values[i]);

    if (i < numbers.Length - 1)
    {
        Console.Write(", ");
    }
}