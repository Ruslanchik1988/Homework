int[] array = new int[5];
for(int i = 0; i < array.Length; i ++)
    array[i] = new Random().Next(100, 1000);
    int c = 0;
for(int i = 0; i < array.Length; i ++)
    if(array[i] % 2 == 0)
    c++;
    for(int i = 0; i < array.Length; i ++)
Console.Write($"{array[i]} ");
Console.Write($"= {c}");
