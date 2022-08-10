int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;
for (int i = 0; i < n; i++) 
{
    arr[i] = new Random().Next(1,100);
    if (i % 2 == 0) sum += arr[i];
}
//Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine(sum);
