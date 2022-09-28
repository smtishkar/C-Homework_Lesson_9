// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"


// Второй способ
int n = 7;
Console.WriteLine (NumbersList(n));

string NumbersList (int n)
{
    if ( n == 2 ) return "2"; 
    
    if ( n%2 == 1 )
    --n; 
    return $"{n} " + NumbersList (n-2); 

}

