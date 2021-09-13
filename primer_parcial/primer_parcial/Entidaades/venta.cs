using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial.Negocio
{
    class venta
    {
        private int IDENTIFICADO_DE_PRODUCTO;
        private string NOMBRE_DEL_PRODUCTO;
        private string DESCRIPCIÓN_DEL_PRODUCTO;
        private double PRECIO_DEL_PRODUCTO;
        private int CANTIDAD_DE_PRODUCTO;
        private double total;

        public int IDENTIFICADO_DE_PRODUCTO1 { get => IDENTIFICADO_DE_PRODUCTO; set => IDENTIFICADO_DE_PRODUCTO = value; }
        public string NOMBRE_DEL_PRODUCTO1 { get => NOMBRE_DEL_PRODUCTO; set => NOMBRE_DEL_PRODUCTO = value; }
        public string DESCRIPCIÓN_DEL_PRODUCTO1 { get => DESCRIPCIÓN_DEL_PRODUCTO; set => DESCRIPCIÓN_DEL_PRODUCTO = value; }
        public double PRECIO_DEL_PRODUCTO1 { get => PRECIO_DEL_PRODUCTO; set => PRECIO_DEL_PRODUCTO = value; }
        public int CANTIDAD_DE_PRODUCTO1 { get => CANTIDAD_DE_PRODUCTO; set => CANTIDAD_DE_PRODUCTO = value; }
        public double Total { get => total; set => total = value; }


        public venta()
        {
        }

        public venta(string nOMBRE_DEL_PRODUCTO, double pRECIO_DEL_PRODUCTO, int cANTIDAD_DE_PRODUCTO)
        {
            NOMBRE_DEL_PRODUCTO = nOMBRE_DEL_PRODUCTO;
            PRECIO_DEL_PRODUCTO = pRECIO_DEL_PRODUCTO;
            CANTIDAD_DE_PRODUCTO = cANTIDAD_DE_PRODUCTO;
            

        }

        public override string ToString()
        {
            return "usted compro una " + NOMBRE_DEL_PRODUCTO + " con un precio de " + PRECIO_DEL_PRODUCTO + " dolares y compro la cantidad de " + CANTIDAD_DE_PRODUCTO  ;
        }
    }


}
