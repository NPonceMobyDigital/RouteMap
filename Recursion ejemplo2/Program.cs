
Console.WriteLine("Seleccione la posicion en la cadena Fibonacci que desee conocer su valor, en numero entero");



try
{
    int c = int.Parse(Console.ReadLine());

    int f = 0;
    f = Fib(c);
    Console.WriteLine("El valor en el punto seleccionado de la cadena es:  " + f);

}
catch (Exception Ex)
{

    throw Ex;
        
}



int Fib(int x)
{
    int r = 0;
    if (x > 1)
    {
        r = Fib(x - 1) + Fib(x - 2);
    }
    if (x <= 1)
    {
        r = 1;
    }

    return r;
}
