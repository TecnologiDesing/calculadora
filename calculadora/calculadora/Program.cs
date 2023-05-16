namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
         //<<<<<< HEAD

            MostrarMenu();
            opciones_menu();

            
        }
        static void MostrarMenu()
        {

            Console.WriteLine();
            Console.WriteLine("    Elige la operacion que quiere realizar     ");
            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                * #1 Suma *                 ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                * #2 Resta *                ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║               * #3 Dividir *               ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║             * #4 Multiplicar *             ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                * #5 Salir *                ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
         //>>>>>>> menu

        }




=======
            
        }

        static void opciones_menu()
        {


            while (true)
            {

                try
                {

                    int opciones;

                    opciones = Convert.ToInt32(Console.ReadLine());

                    switch (opciones)
                    {

                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("       ╔══════════════════════════════╗");
                            Console.WriteLine("       ║  Has elegido hacer una suma  ║");
                            Console.WriteLine("       ╚══════════════════════════════╝");
                            Console.WriteLine();
                            logica_de_Suma();
                            MostrarMenu();

                            break;

                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("      ╔═══════════════════════════════╗");
                            Console.WriteLine("      ║  Has elegido hacer una resta  ║");
                            Console.WriteLine("      ╚═══════════════════════════════╝");
                            Console.WriteLine();
                            logica_de_resta();
                            MostrarMenu();

                            break;

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("   ╔══════════════════════════════════╗");
                            Console.WriteLine("   ║  Has elegido hacer una division  ║");
                            Console.WriteLine("   ╚══════════════════════════════════╝");
                            Console.WriteLine();
                            logica_de_division();
                            MostrarMenu();

                            break;

                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Has elegido hacer una multiplicacion");
                            Console.WriteLine();
                            logica_de_multiplicacion();
                            MostrarMenu();

                            break;

                        case 5:
                            Console.WriteLine();
                            Console.WriteLine("   ╔══════════════════════════════════════╗");
                            Console.WriteLine("   ║  Has elegido salir de la aplicación  ║");
                            Console.WriteLine("   ╚══════════════════════════════════════╝");
                            salir_de_app();

                            break;



                        default:
                            Console.WriteLine();
                            Console.WriteLine("╔════════════════════════════════════════════════╗");
                            Console.WriteLine("║  Opcion incorrecta, ingrese una opcion valida  ║");
                            Console.WriteLine("╚════════════════════════════════════════════════╝");
                            Console.WriteLine();
                            MostrarMenu();

                            break;

                    }

                }

                catch (FormatException)

                {

                    Console.WriteLine();
                    Console.WriteLine("       ╔═════════════════════════════╗");
                    Console.WriteLine("       ║  usted no coloco un numero  ║");
                    Console.WriteLine("       ╚═════════════════════════════╝");
                    Console.WriteLine();
                    MostrarMenu();

                }

                catch (OverflowException)

                {

                    Console.WriteLine();
                    Console.WriteLine("  ╔════════════════════════════════════════╗");
                    Console.WriteLine("  ║  usted exedio el numero de caracteres  ║");
                    Console.WriteLine("  ╚════════════════════════════════════════╝");
                    Console.WriteLine();
                    MostrarMenu();
                }

            }

        }

>>>>>>> opciones
    }
}