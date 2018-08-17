using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static char opcion;
        static void Main(string[] args)
        {
            do
            {
                ////////////////////////////// MENU //////////////////////////
                //////////////////////////////Starlin Hernandez  15-MISN-1-201  seccion 0908  ////////////
                Console.WriteLine();
                Console.WriteLine("\\\\\\\\ Sistema de Facturación ////");
                Console.WriteLine();
                Console.WriteLine(" 1) Facturar Producto" + "       2) Salir" + "\n");
                Console.Write(" Seleccione una opción: ");
                opcion = char.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case '1':
                        Console.WriteLine();
                        Console.WriteLine(" -Listado de Laptops: ");
                        Console.WriteLine();
                        Console.WriteLine(
                    "_ Lenovo Yoga 900                  - 12,500.00 pesos" + "\n" +
                    "_ Dell XPS 13                      - 25,700.00 pesos" + "\n" +
                    "_ Alienware 17                     - 11,300.00 pesos" + "\n" +
                    "_ Asus X200MA                      - 13,800.00 pesos" + "\n" +
                    "_ Toshiba Chromebook 2 CB35        - 19,000.00 pesos" + "\n" +
                    "_ Acer Aspire E1-572               - 14,800.00 pesos" + "\n" +
                    "_ HP-15 Pavilon Notebook           - 14,900.00 pesos" + "\n" +
                    "_ Apple MacBook Air                - 25,000.00 pesos" + "\n" +
                    "_ Dell Inspiron 15 50000           - 32,000.00 pesos" + "\n");
                        Program d1 = new Program();
                        d1.desarrollo();
                        break;
                    default:
                        Console.WriteLine("\nPor favor elegir una opción de la lista que se valido");
                        break;
                }
            } while (opcion != '2');
        }
         ///////////////////////////////////////////////////////////////////
        public void desarrollo()
        {   //////////////////////////////Starlin Hernandez  15-MISN-1-201  seccion 0908  //////////////////////////////////////////////////////////////
            double precio = 0, numeroarticulos = 0, precioventa = 0, descuento = 0, preciobruto = 0, iva = 0, totalpagar = 0;

            ////////////////////////////////////// PROCESOS //////////////////////////////////
            Console.Write("Ingrese el precio del producto que desea adquirir: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad que desea: ");
            numeroarticulos = double.Parse(Console.ReadLine());
            precioventa = precio ;
            iva = Math.Round(precioventa * 0.15);
            preciobruto = precioventa * numeroarticulos;
            totalpagar = preciobruto * descuento; 
            //////////////////////////////////// DESICIONES /////////////////////////////
            if (preciobruto >= 10000)
            {
                descuento = Math.Round((preciobruto * 3) / 100);
            }
            else if (preciobruto >= 15000)
            {
                descuento = Math.Round((preciobruto * 5) / 100);
            }
            else  if (preciobruto >= 20000)
            {
                descuento = Math.Round((preciobruto * 7) / 100);
            }
           else if (preciobruto >= 70000)
            {
                descuento = Math.Round((preciobruto * 10) / 100);
            }
            else
            {
                descuento = 0;
            }
            ///////////////////////////////////// IMPRIMIR ///////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine(" Datos de la factura "); Console.WriteLine();
            Console.WriteLine(" Precio de venta: " + precioventa);
            Console.WriteLine(" Impuesto sobre el valor añadido (IVA) es: " + iva);
            Console.WriteLine(" Precio bruto es: " + preciobruto);
            Console.WriteLine(" Descuento es: " + descuento);
            Console.WriteLine(" Total a pagar: " + totalpagar);
            Console.WriteLine("////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
        }
    }
}







    