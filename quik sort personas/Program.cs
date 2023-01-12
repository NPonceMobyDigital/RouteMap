
using quik_sort_personas;

 List<Persona> personas = new List<Persona>();

    personas.Add(new Persona() { Edad = 35, Nombre = "Ariel" });
    personas.Add(new Persona() { Edad = 25, Nombre = "Sergio" });
    personas.Add(new Persona() { Edad = 23, Nombre = "Agustin" });
    personas.Add(new Persona() { Edad = 30, Nombre = "Nestor" });



Console.WriteLine("La lista se creo");
foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Nombre + "--" + persona.Edad);
}

// Se utiliza el método List.Sort() y se proporciona un comparador personalizado
personas.Sort((x, y) => x.Edad.CompareTo(y.Edad));



// La lista está ordenada por edad después de utilizar List.Sort()

Console.WriteLine("Se ordeno la lista de acuerdo a la edad");
foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Nombre + " - " + persona.Edad);
}