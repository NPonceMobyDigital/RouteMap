
using System.Collections.Generic;

LinkedList<int> numeros = new LinkedList<int> ();

//cargo el array  en la linkedlist(new int []{})
foreach (int numero in new int [] {10,8,6,4,2,0})
{
    numeros.AddFirst(numero);
}



Console.WriteLine ("Los valores del Arraylist son: ");
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

//creo una variable, la cargo y cargo como el primer nodo

Console.WriteLine ("INGRESE UN VALOR QUE SERA AGREGADO AL LISTADO GENERADO");

int valorIngresado = int.Parse(Console.ReadLine());

LinkedListNode<int> numerodeNodo = new LinkedListNode<int>(valorIngresado);

numeros.AddFirst(numerodeNodo);

//agrega los nodos al proncipio
Console.WriteLine ("Valores con for que pasan por movimientos de nodo");   

for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
{
    int numero = nodo.Value;
    Console.WriteLine (numero);     

}






