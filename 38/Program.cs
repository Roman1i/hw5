int n = Convert.ToInt32(Console.ReadLine());
double max = 0;
double min = 100;
double[] arr = new double[n];
for (int i = 0; i < n; i++) 
{
    arr[i] = new Random().Next(1,100);
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
}
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine(max - min);

