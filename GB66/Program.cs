
Console.Clear();

int valueM = 1;
int valueN = 0;
while (valueM > valueN)
{
    valueM = Input("Введите M: ");
    valueN = Input("Введите N: ");
    if(valueM > valueN)
    {
        Console.WriteLine("Значение M должно быть меньше либо равно значению N. \n\nВведите другие значения.");
    }
}
int result = 0;

SumNaturalNumbers(valueM, valueN, result);
Console.Write("\n");

void SumNaturalNumbers(int m, int n, int sum)
{
    sum = sum + m;

    if(m == n)
    {
        Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = " + sum);   
    }
    else
    {
        if(m+1 == n)
        {
            sum = sum + n;
            Console.WriteLine("Сумма натуральных элементов в промежутке от M до N = " + sum);   
        }
        else
        {
            SumNaturalNumbers(m+1, n, sum);
        }
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

