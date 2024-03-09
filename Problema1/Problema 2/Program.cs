using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] listaPreciosProductos = new double [3];
            
            Console.WriteLine("Ingrese el precio de 3 productos: ");

            listaPreciosProductos[0] = double.Parse(Console.ReadLine());
            listaPreciosProductos[1] = double.Parse(Console.ReadLine());
            listaPreciosProductos[2] = double.Parse(Console.ReadLine());


            calcularDescuento(listaPreciosProductos);

            Console.ReadKey(true);
        }


        public static void calcularDescuento(double[] lista_productos)
        {
            double sumatotalDescuentos = 0;
            double compraBruta = 0;
            for (int i = 0; i < lista_productos.Length; i++ ){
                compraBruta += lista_productos[i];
                if (lista_productos[i] >= 100)
                {
                    Console.WriteLine("Se aplico un decuento del 15% por ser mayor a 100Q al producto {0}", i+1);
                    sumatotalDescuentos += lista_productos[i] *0.15;

                }

            }

            Console.WriteLine("La compra con descuentos sale en: {0}", sumatotalDescuentos);
            Console.WriteLine("La compra bruta es {0}", compraBruta);
        }
    }
}
