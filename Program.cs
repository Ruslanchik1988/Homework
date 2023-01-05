int n;
Console.Write($"Введите число N ");
int.TryParse(Console.ReadLine()!, out n);

NumberN(n, 1);

void NumberN(int r, int l)
{
    if( r == l)
    Console.Write($"{r} ");
    else
    {
       Console.Write($"{r} ");
       NumberN( r -1, l);
    }
}