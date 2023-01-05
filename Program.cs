int M;
int N;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine()!, out M);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);
if(M > N)
{
    Console.Write($"Число M не может быть больше числа N ");
}

int Sum(int M, int N)
{
    if(M >= N)
    return M;
   return M + Sum(M + 1, N); 
}
Console.Write($"{Sum(M, N)}");


