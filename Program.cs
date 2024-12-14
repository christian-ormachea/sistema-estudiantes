class Program {
    static void Main(string [] args){
        Console.WriteLine("Bienvenido al sistema de gestion de estudiantes de Christian Ormachea");
        List<Estudiante> estudiantes = new List<Estudiante>();
        int opcion;
        do {
            Console.WriteLine("1. Ingrese un nuevo estudiante");
            Console.WriteLine("2. Ver la lista de estudiantes");
            Console.WriteLine("3. Ver el promedio de un estudiante");
            Console.WriteLine("4. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre y la edad del estudiante que desea agregar");
                    Console.WriteLine("Nombre:");
                    string nombreAAgregar = Console.ReadLine();
                    Console.WriteLine("Edad:");
                    int edadAAgregar = int.Parse(Console.ReadLine());
                    estudiantes.Add(new Estudiante(nombreAAgregar, edadAAgregar));
                    break;
                case 2:
                    Console.WriteLine("La lista de los estudiantes es:");
                    foreach (var estudiante in estudiantes)
                    {
                        Console.WriteLine($"Nombre: {estudiante.Nombre()} Edad: {estudiante.Edad()}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del estudiante a buscar el promedio:");
                    string nombreEstudianteABuscar = Console.ReadLine();
                    Estudiante estudianteEncontrado = null;

                    foreach (var estudiante in estudiantes)
                    {
                        if (estudiante.Nombre() == nombreEstudianteABuscar)
                        {
                            estudianteEncontrado = estudiante;
                            Console.WriteLine($"El promedio del estudiante {estudianteEncontrado.Nombre()} es {estudiante.Promedio()}");
                        }
                    }

                    if (estudianteEncontrado == null)
                    {
                        Console.WriteLine("Error! El estudiante no fue encontrado!");
                    }
                    break;
            }
        } while (opcion != 4);

                                                       
    }
}
