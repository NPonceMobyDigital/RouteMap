
using NetTopologySuite.Algorithm;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

//declara una lista

List<int> numeros = new List<int>();

// agregar elementos 

Console.WriteLine("Ingresa valores distintos de 0");
Console.WriteLine("Presiona 0 para salir");
 
//carga de elementos a traves del while



int elem = 1;
int suma = 0;
int contador = 0;   

while (elem != 0)
{
    elem = Int32.Parse(Console.ReadLine());

    numeros.Add(elem);
    suma = suma + elem;
    contador++;

}


//remuevo el ultimo elemento para quitar el 0 ingresado de la lista
numeros.RemoveAt(numeros.Count-1);

Console.WriteLine("Lista de elementos ingresados");
foreach (int elementos in numeros)
{
    Console.WriteLine(elementos);
    
}


Console.WriteLine("El numero total de la suma es:");    
Console.WriteLine(suma);
Console.WriteLine("La cantidad de valores ingresados es");
Console.WriteLine(contador - 1);    