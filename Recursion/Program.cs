

Console.WriteLine("Ingrese un valor que dese averiguar su factorial");
int f = int.Parse(Console.ReadLine());
int c = 0;
c = Factorial(f);
Console.WriteLine("El resultado es:");
Console.WriteLine(c);   


// vuelve a utilizar parte del mismo metodo(usa los procedimientos pero actualiza valores)
int Factorial(int n)
{
    int r = 0;
    if (n > 1)
    {
        r = n * Factorial(n - 1);
    }

    if(n == 1) 
    {
        r = 1;
    }

    return r;   
}
