int[] numeros = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

// Se utiliza el método Array.Sort() para ordenar el arreglo
Array.Sort(numeros);

// El arreglo está ordenado después de utilizar Array.Sort()
foreach (int numero in numeros)
{
    Console.Write(numero + " ");
}
