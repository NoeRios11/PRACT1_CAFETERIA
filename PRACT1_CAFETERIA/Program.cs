using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT1_CAFETERIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string tamano;
            float precio;

            // BEBIDA 1
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            Console.WriteLine("CAFE"+"\n" + "CHOCOMILK"+"\n"+"CAFE NEGRO");    //MUESTRA LOS PRODUCTOS
            Console.WriteLine("INGRESE EL NOMBRE DE LA BEBIDA:");
            nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("TAMAÑOS:");
            Console.WriteLine("CHICO" + "\n" + "MEDIANO" + "\n" + "GRANDE"); //MUESTRA LOS TAMAÑOS
            Console.WriteLine("INGRESE EL TAMAÑO DEL "+nombre);
            tamano = Console.ReadLine();
            Console.WriteLine("INGRESE EL COSTO");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Bebida bebida_1 = new Bebida(nombre, tamano, precio);


            //BEBIDA 2
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            Console.WriteLine("CAFE" + "\n" + "CHOCOMILK" + "\n" + "CAFE NEGRO");//MUESTRA LOS PRODUCTOS
            Console.WriteLine("INGRESE EL NOMBRE DE LA BEBIDA:");
            nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("TAMAÑOS:");
            Console.WriteLine("CHICO" + "\n" + "MEDIANO" + "\n" + "GRANDE");  //MUESTRA LOS TAMAÑOS
            Console.WriteLine("INGRESE EL TAMAÑO DEL "+nombre);
            tamano = Console.ReadLine();
            Console.WriteLine("INGRESE EL COSTO:");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Bebida bebida_2 = new Bebida(nombre, tamano, precio);


            //BEBIDA 3
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            Console.WriteLine("CAFE" + "\n" + "CHOCOMILK" + "\n" + "CAFE NEGRO");  //MUESTRA LOS PRODUCTOS
            Console.WriteLine("INGRESE EL NOMBRE DE LA BEBIDA:");
            nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("TAMAÑOS:");
            Console.WriteLine("CHICO" + "\n" + "MEDIANO" + "\n" + "GRANDE"); //MUESTRA LOS TAMAÑOS
            Console.WriteLine("INGRESE EL TAMAÑO DEL "+nombre);
            tamano = Console.ReadLine();
            Console.WriteLine("INGRESE EL COSTO");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Bebida bebida_3 = new Bebida(nombre, tamano, precio);




            bebida_1.AplicarDescuento(10);
            bebida_2.AplicarDescuento(25);
            bebida_3.AplicarDescuento(35);

            Console.WriteLine("\n PREPARACION DE LAS BEBIDAS");
            bebida_1.Preparar();
            bebida_2.Preparar();
            bebida_3.Preparar();

            Console.WriteLine("\n DESCRIPCION DE LAS BEBIDAS");
            bebida_1.MostrarDescripcion();
            bebida_2.MostrarDescripcion();
            bebida_3.MostrarDescripcion();

            Console.ReadKey();
        }
    }
}
