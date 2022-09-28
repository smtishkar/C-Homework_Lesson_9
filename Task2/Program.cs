// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int a = 4;
int b = 8;
Console.WriteLine (SumNumbers(a, b));

int SumNumbers (int a, int b)
{
    if ( b < a ) return 0; 
    else return a + SumNumbers (a+1, b);
}