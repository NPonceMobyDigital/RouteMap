using System.Collections;
using System.Collections.Generic;

class Persona : IComparable
{
    public int Edad { get; set; }
    public string Nombre { get; set; }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Persona otraPersona = obj as Persona;
        if (otraPersona != null)
            return this.Edad.CompareTo(otraPersona.Edad);
        else
            throw new ArgumentException("Object is not a Persona");
    }
}


class ComparadorPorNombre : IComparer
{
    public int Compare(object x, object y)
    {
        Persona persona1 = x as Persona;
        Persona persona2 = y as Persona;

        if (persona1 != null && persona2 != null)
            return persona1.Nombre.CompareTo(persona2.Nombre);
        else
            throw new ArgumentException("Object is not a Persona");
    }
}
