
Console.Clear();
int n = Input("Введите N: ");

NaturalNumbers(n);
Console.Write("\n");

void NaturalNumbers(int number)
{
    Console.Write(number);
    if(number > 1)
    {
        Console.Write(", ");
        NaturalNumbers(number-1);
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

