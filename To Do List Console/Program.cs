
List<string> listaDeTareas = new List<string>();
string opcionElegida = "";


Console.WriteLine("Bienvenido/a a la LISTA DE TAREAS");
Console.WriteLine("");

while (opcionElegida != "4")
{
    string tarea="";
    Console.WriteLine("¿Qué deseas realizar?");
    Console.WriteLine("");
    Console.WriteLine("Presione 1 para AGREGAR UNA NUEVA TAREA");
    Console.WriteLine("Presione 2 para VER LA LISTA DE TAREAS");
    Console.WriteLine("Presione 3 para BORRAR UNA TAREA");
    Console.WriteLine("Presione 4 para SALIR DEL PROGRAMA");
    opcionElegida = Console.ReadLine();
    Console.WriteLine("");

    switch (opcionElegida)
    {
        case "1":
            Console.WriteLine("Escriba la NUEVA TAREA");
            tarea=Console.ReadLine();
            listaDeTareas.Add(tarea);
            Console.WriteLine($"La tarea '{tarea.ToUpper()}' fue agregada");
            break;
        case "2":
            //agregar un if si la lista está vacía
            Console.WriteLine("LISTA DE TAREAS");
            for (int i = 0; i < listaDeTareas.Count; i++)
            {
                Console.WriteLine($"Tarea {i}, {listaDeTareas[i]}");
            }
            Console.WriteLine("");
            break;
        case "3":

            Console.WriteLine("Escriba el número de la tarea a borrar");
            int numeroTareaABorrar= Convert.ToInt32(Console.ReadLine());
            listaDeTareas.RemoveAt(numeroTareaABorrar);
            Console.WriteLine("Tarea borrada");
            break;
        case "4":
            break;
        default:
            Console.WriteLine("Opción inválida. Escriba nuevamente alguna de las opciones correctas");
            break;
    }
}
Console.WriteLine("Muchas gracias por usar LISTA DE TAREAS");
