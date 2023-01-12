
Console.WriteLine("Metodo burbuja clasico");

int IteracionExt = 0;
int IteracionInt = 0;

int [] numbers = new int[] {50, 65, 41, 71, 91 , 20 , 00, 10};


Console.WriteLine("Los valores del Arraylist son: ");
foreach (var item in numbers)
{
	Console	.WriteLine(item);
}


for (int i = 0; i < numbers.Length; i++)
{
	IteracionExt ++;

	for (int j = 0; j < numbers.Length-1; j++)
	{
        IteracionInt ++;
        if (numbers[j] < numbers[j+1])
		{
			int VarAux = numbers[j];
			numbers[j] = numbers[j+1];
			numbers[j+1] = VarAux;
		}

	}
}

Console.WriteLine("Los valores del Arraylist ordenado son: ");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}
Console.WriteLine("numero de iteraciones externas  " + IteracionExt);
Console.WriteLine("numero de iteraciones Internas  " + IteracionInt);

Console.WriteLine("----------------------------Metodo Mejorado------------------------------------------");
// se le restan los valores ordenados y se le agrega una bandera para evitar que ingrese al for interior cuando ya este ordenado.
int IteracionExt2 = 0;
int IteracionInt2 = 0;
bool flag = true;

int[] numbers2 = new int[] { 50, 65, 41, 71, 91, 20, 00, 10 };


Console.WriteLine("Los valores del Arraylist son: ");
foreach (var item in numbers2)
{
    Console.WriteLine(item);
}


for (int i = 0; i < numbers2.Length && flag; i++)
{
    IteracionExt2++;

    for (int j = 0; j < numbers2.Length -i - 1; j++)
    {
        flag = false;
        IteracionInt2++;
        if (numbers2[j] < numbers2[j + 1])
        {
            flag = true;
            int VarAux = numbers2[j];
            numbers2[j] = numbers2[j + 1];
            numbers2[j + 1] = VarAux;
        }

    }
}

Console.WriteLine("Los valores del Arraylist ordenado son: ");
foreach (var item in numbers2)
{
    Console.WriteLine(item);
}
Console.WriteLine("numero de iteraciones externas  " + IteracionExt2);
Console.WriteLine("numero de iteraciones Internas  " + IteracionInt2);