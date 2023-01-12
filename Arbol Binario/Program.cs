class Persona
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}

class ArbolBST
{
    // Clase interna Nodo para almacenar los objetos Persona
    class Nodo
    {
        public Persona Persona { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        public Nodo(Persona persona)
        {
            this.Persona = persona;
            this.Izquierdo = null;
            this.Derecho = null;
        }
    }

    // Raíz del árbol
    private Nodo raiz;

    public ArbolBST()
    {
        raiz = null;
    }

    // Método para insertar un objeto Persona en el árbol
    public void Insertar(Persona persona)
    {
        raiz = InsertarRecursivo(raiz, persona);
    }

    private Nodo InsertarRecursivo(Nodo nodo, Persona persona)
    {
        // Si el nodo es nulo, se crea un nuevo nodo
        if (nodo == null)
        {
            return new Nodo(persona);
        }

        // Si el ID de la persona es menor que el ID del nodo actual, se inserta en el sub-árbol izquierdo
        if (persona.Id < nodo.Persona.Id)
        {
            nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, persona);
        }
        // Si el ID de la persona es mayor o igual que el ID del nodo actual, se inserta en el sub-árbol derecho
        else
        {
            nodo.Derecho = InsertarRecursivo(nodo.Derecho, persona);
        }

        return nodo;
    }
}
