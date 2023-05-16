namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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



        static void opciones_menu()
        {


            while (true)

            
        }




        static void logica_de_resta()
        {


            bool salir_a_menu_2 = false;

            while (!salir_a_menu_2)
            {

                try
                {

                    // declaracion

                    int numero3;
                    int numero4;
                    int resResta;

                    //perdir datos

                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el primer numero  ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el segundo numero ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    salir_a_menu_2 = true;
                    // realizar operaciones

                    resResta = numero3 - numero4;

                    // mostrar resultado
                    Console.WriteLine("╔══════════════════════════════════════════════════╗");
                    Console.WriteLine("       El resultado de la resta es " + resResta);
                    Console.WriteLine("╚══════════════════════════════════════════════════╝");
                    Console.WriteLine();

                }

                catch (FormatException)

                {

                    Console.WriteLine();
                    Console.WriteLine("       ╔═════════════════════════════╗");
                    Console.WriteLine("       ║  usted no coloco un numero  ║");
                    Console.WriteLine("       ╚═════════════════════════════╝");
                    Console.WriteLine();

                }

                catch (OverflowException)

                {

                    Console.WriteLine();
                    Console.WriteLine("  ╔════════════════════════════════════════╗");
                    Console.WriteLine("  ║  usted exedio el numero de caracteres  ║");
                    Console.WriteLine("  ╚════════════════════════════════════════╝");
                    Console.WriteLine();

                }

            }


        }


        static void logica_de_division()
        {

            bool salir_a_menu_3 = false;

            while (!salir_a_menu_3)
            {


                try
                {

                    // declaracion

                    decimal numero5;
                    decimal numero6;
                    decimal resDivision;

                    //perdir datos

                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el primer numero  ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el segundo numero ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero6 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    salir_a_menu_3 = true;
                    // realizar operaciones

                    resDivision = numero5 / numero6;

                    // mostrar resultado

                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("          El resultado de la division es " + resDivision);
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine();

                }

                catch (FormatException)

                {

                    Console.WriteLine();
                    Console.WriteLine("       ╔═════════════════════════════╗");
                    Console.WriteLine("       ║  usted no coloco un numero  ║");
                    Console.WriteLine("       ╚═════════════════════════════╝");
                    Console.WriteLine();

                }
                catch (OverflowException)

                {

                    Console.WriteLine();
                    Console.WriteLine("  ╔════════════════════════════════════════╗");
                    Console.WriteLine("  ║  usted exedio el numero de caracteres  ║");
                    Console.WriteLine("  ╚════════════════════════════════════════╝");
                    Console.WriteLine();

                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("usted a dividio entre 0");
                }

            }






        }
        static void logica_de_multiplicacion()
        {

            bool salir_a_menu_4 = false;

            while (!salir_a_menu_4)
            {


                try
                {

                    // declaracion

                    int numero7;
                    int numero8;
                    int resMultiplicacion;

                    //perdir datos

                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el primer numero  ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el segundo numero ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero8 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    salir_a_menu_4 = true;
                    // realizar operaciones

                    resMultiplicacion = numero7 * numero8;

                    // mostrar resultado

                    Console.WriteLine("       ╔═════════════════════════════════════════════╗");
                    Console.WriteLine("         El resultado de la multiplicacion " + resMultiplicacion);
                    Console.WriteLine("       ╚═════════════════════════════════════════════╝");
                    Console.WriteLine();

                }

                catch (FormatException)

                {

                    Console.WriteLine();
                    Console.WriteLine("       ╔═════════════════════════════╗");
                    Console.WriteLine("       ║  usted no coloco un numero  ║");
                    Console.WriteLine("       ╚═════════════════════════════╝");
                    Console.WriteLine();

                }
                catch (OverflowException)

                {

                    Console.WriteLine();
                    Console.WriteLine("  ╔════════════════════════════════════════╗");
                    Console.WriteLine("  ║  usted exedio el numero de caracteres  ║");
                    Console.WriteLine("  ╚════════════════════════════════════════╝");
                    Console.WriteLine();

                }


            }

        }



    }
}