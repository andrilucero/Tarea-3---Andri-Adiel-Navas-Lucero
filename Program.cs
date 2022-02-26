using System;

using static System.Console;

namespace Tarea3_AndriLucero
{
    class Cajero
    {
        static void Main()
        {
            int CAN, CA200, CA100, CA50, CA20, CA10, CA5, CA1, CA050, CA025, CA010, CA05, CA01;
            CA200 = CA100 = CA50 = CA20 = CA10 = CA5 = CA1 = CA050 = CA025 = CA010 = CA05 = CA01 = 0;
            double tipodecambio;
            float valor;
            tipodecambio = 7.71;


            Console.WriteLine("\n\t\tBienvenidos al CAJERO\n");
            Console.WriteLine("\t1.- Conversión dólares a quetzales");
            Console.WriteLine("\t2.- Saber el tipo de cambio");
            Console.WriteLine("\t3.- Salir");
            Console.WriteLine("\tIngrese la operación que desea hacer:");
            String linea = Console.ReadLine();
            String opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":

                    Console.WriteLine("\tIngrese la cantidad en dólares:\t");
                    CAN = Convert.ToInt32(Console.ReadLine());
                    valor = ((float)(CAN * tipodecambio));
                    linea = Console.ReadLine();
                    Console.WriteLine("\tUsted ha ingresado\t" + "$" + CAN);
                    Console.WriteLine("\tSegun lo ingresado en quetzales es:\t" + "Q" + CAN * tipodecambio);

                    if ((valor >= 200))
                    {
                        CA200 = ((int)valor / 200);
                        valor = valor - (CA200 * 200);

                    }

                    if ((valor >= 100))
                    {
                        CA100 = ((int)valor / 100);
                        valor = valor - (CA100 * 100);

                    }

                    if ((valor >= 50))
                    {
                        CA50 = ((int)valor / 50);
                        valor = valor - (CA50 * 50);

                    }

                    if ((valor >= 20))
                    {
                        CA20 = ((int)valor / 20);
                        valor = valor - (CA20 * 20);

                    }

                    if ((valor >= 10))
                    {
                        CA10 = ((int)valor / 10);
                        valor = valor - (CA10 * 10);

                    }

                    if ((valor >= 5))
                    {
                        CA5 = ((int)valor / 5);
                        valor = valor - (CA5 * 5);

                    }

                    if ((valor >= 1))
                    {
                        CA1 = ((int)valor / 1);
                        valor = valor - (CA1 * 1);

                    }

                    if ((valor >= 0.50))
                    {
                        CA050 = ((int)(valor / 0.50));
                        valor = valor - (float)(CA050 * 0.50);


                    }

                    if ((valor >= 0.25))
                    {
                        CA025 = ((int)(valor / 0.25));
                        valor = (valor - (float)(CA025 * 0.25));


                    }

                    if ((valor >= 0.10))
                    {
                        CA010 = ((int)(valor / 0.10));
                        valor = valor - (float)(CA010 * 0.10);

                    }

                    if ((valor >= 0.05))
                    {
                        CA05 = ((int)(valor / 0.05));
                        valor = valor - (float)(CA05 * 0.05);

                    }

                    if ((valor >= 0.01))
                    {
                        CA01 = ((int)Math.Round(valor / 0.01));
                        valor = valor - (float)(CA01 * 0.01);

                    }
                    Console.WriteLine("\tEntonces el cambio será entregado de la siguiente manera:\t");
                    Console.WriteLine($"\t\tBilletes de Q200:{CA200}");
                    Console.WriteLine($"\t\tBilletes de Q100:{CA100}");
                    Console.WriteLine($"\t\tBilletes de Q50:{CA50}");
                    Console.WriteLine($"\t\tBilletes de Q20:{CA20}");
                    Console.WriteLine($"\t\tBilletes de Q10:{CA10}");
                    Console.WriteLine($"\t\tBilletes de Q5:{CA5}");
                    Console.WriteLine($"\t\tBilletes de Q1:{CA1}");
                    Console.WriteLine($"\t\tMonedas de 50 centavos:{CA050}");
                    Console.WriteLine($"\t\tMonedas de 25 centavos:{CA025}");
                    Console.WriteLine($"\t\tMonedas de 10 centavos:{CA010}");
                    Console.WriteLine($"\t\tMonedas de 5 centavos:{CA05}");
                    Console.WriteLine($"\t\tMonedas de 1 centavo:{CA01}");

                    break;

                case "2":
                    Console.WriteLine("\tEl tipo de cambio actualmente está a:\t" + "Q" + tipodecambio + "\tquetzales");

                    break;


                case "3":

                default:
                    Console.WriteLine("Fue un gusto haberte ayudado!");
                    break;
            }

            Console.ReadKey();
            Main();

        }
    }
}
