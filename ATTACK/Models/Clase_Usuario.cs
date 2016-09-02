using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTACK.Models
{
    public class Clase_Usuario
    {
        private string Nombre;
        private string Correo;
        private string Contra;
        private int Tipo;

        public Clase_Usuario() { }

        public string _Nombre { get { return Nombre; } set { Nombre = value; } }
        public string _Correo { get { return Correo; } set { Correo = value; } }
        public string _Contra { get { return Contra; } set { Contra = value; } }
        public int _Tipo { get { return Tipo; } set { Tipo = value; } }
    }
}