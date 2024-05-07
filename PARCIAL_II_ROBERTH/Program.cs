using System;

namespace parcial_2_roberth;
{    class Program
 
    {

            {
                Console.WriteLine($"ingrese el nombre del estudiante {i + 1}:");
                nombres[i] = Console.wriateLine();

                int notaValida = false;
                while (!notaValida)
                {
                    Console.WriteLine($"ingrese la nota de {nombres} (entre 0 a 100):");
                    string notaInput = Console.ReadLine();
                    if (int.TryParse(notaInput, out int nota))
                    {
                        if (nota >= 0 && nota <= 100)
                        {
                            notas[i] = nota;
                            notaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("la nota ingresada debe estar entre 0 a 100.");
                        }
                            }
                                Console.WriteLine("ingrese un número válido porfavor.");
                            }
              
                }
                
            
            }

            int salir = false;
            while (!salir)
            {
                // MENU
                Console.WriteLine("\nmenu:");
                Console.WriteLine("1) mostrar nombre y nota de alumnos que aprobaron el curso.");
                Console.WriteLine("2) mostrar nombre y nota de alumnos que nno aprobaron el curso.");
                Console.WriteLine("3) mostrar el promedio de notas del grupo.");
                Console.WriteLine("4) salir del programa");
                Console.Write("seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\nAlumnos que aprobaron el curso:");
                        Mostrar_Alumnos_Por_Condicion(nombres, notas, true);
                        break;
                    case "2":
                        Console.WriteLine("\nAlumnos que NO aprobaron el curso:");
                        Mostrar_Alumnos_Por_Condicion(nombres, notas, false);
                        break;
                    case "3":
                        Console.WriteLine($"\nEl promedio de notas del grupo es: {calcular Promedio de (notas)}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void Mostrar_Alumnos_Por_Condicion(string[] nombres, int[] notas, bool aprobaron)
        {

            {
                ifnt ((notas[i] >= 60 && aprobaron) || (notas[i] < 60 && !aprobaron));
                {
                    Console.WriteLine($"Nombre: {nombres[i]}, Nota: {notas[i]}");
                }
            }
        }

       
        {
            double suma = 0;
            foreach (int nota in notas);
            {
                suma += nota;
            }
            return suma / notas.Length;
        }
    }


}
