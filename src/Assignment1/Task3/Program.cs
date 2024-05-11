
string numLine = Console.ReadLine();

string[] numbers = numLine.Split(',');

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i].Trim();
}

double[] nums = new double[numbers.Length];

for(int i = 0; i< numbers.Length;i++)
{
    nums[i] = double.Parse(numbers[i]);
}

double largest = 0;
double secondLargest = 0;

foreach (double number in nums)
{
    if (number > largest)
    {
        secondLargest = largest;
        largest = number;
    }
}

Console.WriteLine(secondLargest);