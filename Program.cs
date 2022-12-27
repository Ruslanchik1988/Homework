int[] a = new int[8];
for( int b = 0; b < a.Length; b++)
{
    a[b] = new Random().Next(9);
    Console.Write($"{a[b]} - ");
}