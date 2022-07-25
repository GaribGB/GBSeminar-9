
Console.Clear();
double valueM = Input("Введите M: ");
double valueN = Input("Введите N: ");

double result = AkkermanF(valueM, valueN);
Console.WriteLine("Функция Аккермана от заданных значений = " + result);


double AkkermanF(double m, double n)
{
    if(m==0&&n!=0)
    {
        return n+1;
    }
    
    if(m!=0&&n==0)
    {
        return AkkermanF(m-1,1);
    }

    if(m!=0&&n!=0)
    {
        return AkkermanF(m-1,AkkermanF(m,n-1));
    }
    else 
    {
        return 0;
    }
}

double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}

