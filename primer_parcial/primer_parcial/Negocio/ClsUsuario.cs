using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using primer_parcial.Entidaades;

namespace primer_parcial.Negocio
{
    class ClsUsuario
    { public string confirmacion;
        Usuario datos = new Usuario("cristian", 123);

        public string ACCESO()
        {
            
            Console.WriteLine("ingrese el nombre de su usuario");
            datos.NOMBRE1 = Console.ReadLine();
            
            if (datos.NOMBRE1 == "cristian")
            {
               
                Console.WriteLine("ingrese su contraseña");
                datos.CONTRA1 = int.Parse(Console.ReadLine());

                if (datos.CONTRA1 == 123)
                {
                    Console.WriteLine("INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA");
                    confirmacion = "";
                    return confirmacion;
                }
                if (datos.CONTRA1 != 123)
                {
                    Console.WriteLine("error contraseña incorrecta\nprecione enter para volver a iniciar el programa");
                    return ".";
                }



            }
            else
                Console.WriteLine("su nombre de usuario es incorrecto\nprecione enter para cerrar el programa");



            return "";
        }

    }
}
