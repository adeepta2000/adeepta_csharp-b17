
int number;

while (true)
{
    number = int.Parse(Console.ReadLine());

    if (number == 0)
    {
        break;
    }

    int isPrime = 0;

    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            isPrime++;
        }
    }

    if (isPrime == 2)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

