using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using primer_parcial.Entidaades;

namespace primer_parcial.Negocio
{
    class ClsVenta
    {
        double total_descuento;
        
        public string COBRO(venta datoslle)
        {
            venta nue = new venta();
            nue.Total = datoslle.PRECIO_DEL_PRODUCTO1 * datoslle.CANTIDAD_DE_PRODUCTO1;

            if (nue.Total > 50)
            {
                total_descuento = (nue.Total) - (nue.Total * 0.20);
                Console.WriteLine("se aplico un descuento de un 20% por que su compra es mayor de 50 dolares\n el total a pagar es" + total_descuento+" dolares");
            }
            Console.WriteLine("el pago total a pagar es " + nue.Total +" dolares");

            return "";


        }
    }
}
