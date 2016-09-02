using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTACK.Models
{
    public class Clase_Carta //datos de las cartas
    {
        //atributos de las cartas 
        private int ID;
        private string Nombre_Carta;
        private int ATK;
        private int DEF;
        private int HP;
        private string PODER;
        private string elemento;

        public Clase_Carta() { }
        public int _ID { get { return ID; } set { ID = value; } }
        public string _Nombre_Carta { get { return Nombre_Carta; } set { Nombre_Carta = value; } }
        public int _ATK { get { return ATK; } set { ATK = value; } }
        public int _DEF { get { return DEF; } set { DEF = value; } }
        public int _HP { get { return HP; } set { HP = value; } }
        public string _PODER { get { return PODER; } set { PODER = value; } }
        public string _elemento { get { return elemento; } set { elemento = value; } }
        

    }
}