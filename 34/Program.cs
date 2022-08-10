int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int count = 0;
for (int i = 0; i < n; i++) 
{
    arr[i] = new Random().Next(100,1000);
    if (arr[i] % 2 == 0) count++;
}
//Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine(count);