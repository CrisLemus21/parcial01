using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial.Entidaades
{
    class Usuario
    {
        private string NOMBRE;
        private int CONTRA;

        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public int CONTRA1 { get => CONTRA; set => CONTRA = value; }

        public Usuario(string nOMBRE, int cONTRA)
        {
            NOMBRE = nOMBRE;
            CONTRA = cONTRA;
        }
    }
}
