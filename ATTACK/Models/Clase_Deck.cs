using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTACK.Models
{
    public class Clase_Deck
    {
        private string Nombre_Usuario;
        private string Nombre_Deck;
        private int ID_Carta;
        private int Cantidad_Cartas;

        public Clase_Deck() { }
        public string _Nombre_Usuario { get { return Nombre_Usuario; } set { Nombre_Usuario = value; } }
        public string _Nombre_Deck { get { return Nombre_Deck; } set { Nombre_Deck = value; } }
        public int _ID_Carta { get { return ID_Carta; } set { ID_Carta = value; } }
        public int _Cantidad_Cartas { get { return Cantidad_Cartas; } set { Cantidad_Cartas = value; } }


    }
}