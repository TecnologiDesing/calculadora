namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }





        static void logica_de_Suma()
        {


            bool salir_a_menu = false;

            while (!salir_a_menu)
            {

                try
                {

                    // declaracion

                    int numero1;
                    int numero2;
                    int resSuma;

                    //perdir datos
                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el primer numero  ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("        ╔════════════════════════════╗");
                    Console.WriteLine("        ║  ingrese el segundo numero ║");
                    Console.WriteLine("        ╚════════════════════════════╝");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    salir_a_menu = true;
                    // realizar operaciones

                    resSuma = numero1 + numero2;

                    // mostrar resultado
                    Console.WriteLine("       ╔══════════════════════════════════════╗");
                    Console.WriteLine("           El resultado de la suma es " + resSuma);
                    Console.WriteLine("       ╚══════════════════════════════════════╝");
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