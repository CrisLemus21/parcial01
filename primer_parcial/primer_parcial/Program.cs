using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using primer_parcial.Negocio;
using primer_parcial.Entidaades;

namespace primer_parcial
{
    class Program

    {
        
       
        static void Main(string[] args)
        {
            
            ClsUsuario login = new ClsUsuario();
            venta ven = new venta();
            ClsVenta pro = new ClsVenta();

            Console.WriteLine(login.ACCESO());



            if (login.confirmacion == "")
            {
                int validar = 1;
                while (validar == 1)
                {
                    Console.WriteLine("ingrese el producto que quiere comprar");
                    ven.NOMBRE_DEL_PRODUCTO1 = Console.ReadLine();
                    Console.WriteLine("ingrese el precio del producto");
                    ven.PRECIO_DEL_PRODUCTO1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la catidad que desea comprar");
                    ven.CANTIDAD_DE_PRODUCTO1 = int.Parse(Console.ReadLine());

                    venta datoslle = new venta(ven.NOMBRE_DEL_PRODUCTO1, ven.PRECIO_DEL_PRODUCTO1, ven.CANTIDAD_DE_PRODUCTO1);
                    Console.WriteLine(pro.COBRO(datoslle));
                    Console.WriteLine(ven.ToString());

                }


            }
            
            

            Console.ReadLine();
        }
    }
}
