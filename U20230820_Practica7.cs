using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable buleana para poder hacer el ciclo con las opciones
            bool salir = false;

            do
            {
                Console.WriteLine("\n************************************************************");
                Console.WriteLine("Menu de Opciones:");
                Console.WriteLine("1. Opción 1: Suma de Números Pares e Impares en un Rango");
                Console.WriteLine("2. Opción 2: Adivina el número secreto (entre 1 y 10)");
                Console.WriteLine("3. Opción 3: Tablas de multiplicar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("************************************************************");

                Console.Write("Seleccione una opción: ");
                string? opcion = Convert.ToString(Console.ReadLine());

                switch (opcion)
                {
                    case "1": 
                        numImp();
                        break;

                    case "2":
                        numSecret(); 
                        break;

                    case "3":
                        tablaMultiplicar(); 
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del programa......");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine(); // Salto de línea para separar las iteraciones del menú

            } while (!salir);

            Console.ReadKey();
        }//Fin del principal

        static void numImp () 
        {
            Console.WriteLine("\n**********Suma de Números Pares e Impares en un Rango**********\n");
                        Console.Write("Ingrese un número entero positivo: ");

                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                        {
                            int sumaPares = 0;
                            int sumaImpares = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    sumaPares += i; // Si es par, suma al acumulador de pares
                                }
                                else
                                {
                                    sumaImpares += i; // Si es impar, suma al acumulador de impares
                                }
                            }

                            Console.WriteLine("\nLa suma de los números pares en el rango es: " + sumaPares);
                            Console.WriteLine("La suma de los números impares en el rango es: " + sumaImpares);
                        }

                        else
                        {
                            Console.WriteLine("Debe ingresar un número entero positivo válido.");
                        }
        }//Fin codigo Numero par e impar

        static void numSecret() 
        {
            //Se llama la funcion Random para que se pueda usar en los numeros secretos aleatoriamente.
                        Random random = new();
                        //La variable numeroSecreto es igual a un rango del 1 al 11 porque en C# cuenta tambien el 0
                        int numeroSecreto = random.Next(1, 11);
                        int intentos = 0;
                        int intentoUsuario;

                        Console.WriteLine("\n**********Adivina el número secreto (entre 1 y 10)**********");

                        while (true)
                        {
                            intentos++;

                            Console.Write("\nIngresa tu intento: ");
                            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
                            {
                                if (intentoUsuario == numeroSecreto)
                                {
                                    Console.WriteLine("¡Felicitaciones! Adivinaste el número secreto el cual es " + numeroSecreto + " y fue adivinado en " + intentos + " intentos.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Intenta de nuevo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingresa un número válido.");
                            }
                        }
        }//Fin del codigo de adivinar numero secreto

        static void tablaMultiplicar () 
        {
            Console.WriteLine("\n**********Tablas de multiplicar**********");
                        Console.Write("\nIngresa un número para ver su tabla de multiplicar: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nTabla de multiplicar del " + numero + ":");

                        // Utilizamos un bucle for para imprimir la tabla de multiplicar del número ingresado
                        for (int i = 1; i <= 10; i++)
                    {
                        int resultado = numero * i;
                        Console.WriteLine(numero + " x " + i + " = " + resultado);
                    }
        }//Fin de tabla de multiplicar

    }
}