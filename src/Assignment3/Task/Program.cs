
using Task;

BubbleSort<int> bubbleSort1 = new BubbleSort<int>();
BubbleSort<double> bubbleSort2 = new BubbleSort<double>();

int[] intArray = { 8, 3, 7, 6, 9 };
double[] doubleArray = { 8.65, 3.78, 7.12, 6.92, 9.38 };

bubbleSort1.SortArray(intArray);
bubbleSort2.SortArray(doubleArray);

Console.WriteLine(string.Join(", ", intArray));
Console.WriteLine(string.Join(", ", doubleArray));
