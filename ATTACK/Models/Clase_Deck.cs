﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTACK.Models
{
    public class Clase_Deck
    {
        private Clase_Usuario Nombre_Usuario;
        private string Nombre_Deck;
        private Clase_Carta ID_Carta;
        private int Cantidad_Cartas;

        public Clase_Deck() { }
        public Clase_Usuario _Nombre_Usuario { get { return Nombre_Usuario; } set { Nombre_Usuario = value; } }
        public string _Nombre_Deck { get { return Nombre_Deck; } set { Nombre_Deck = value; } }
        public Clase_Carta _ID_Carta { get { return ID_Carta; } set { ID_Carta = value; } }
        public int _Cantidad_Cartas { get { return Cantidad_Cartas; } set { Cantidad_Cartas = value; } }

        public static int Insertar_Usuario(String _Nombre_Usuario, String _Nombre_Deck, int _ID_Carta, int _Cantidad_Cartas) //inserta un deck
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC INGRESAR_DECK ?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_Nombre_Usuario, 2);
            conx_detalles.annadir_parametro(_Nombre_Deck, 2);
            conx_detalles.annadir_parametro(_ID_Carta, 1);
            conx_detalles.annadir_parametro(_Cantidad_Cartas, 1);
            CONTENEDOR = conx_detalles.busca();
            while (CONTENEDOR.Read())
            {
                respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            CONTENEDOR.Close();
            return respuesta;
        }

        public static int Modificar_Usuario(String _Nombre_Usuario, String _Nombre_Deck, int _ID_Carta, int _Cantidad_Cartas) //modificar un deck
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC MODIFICAR_DECK ?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_Nombre_Usuario, 2);
            conx_detalles.annadir_parametro(_Nombre_Deck, 2);
            conx_detalles.annadir_parametro(_ID_Carta, 1);
            conx_detalles.annadir_parametro(_Cantidad_Cartas, 1);
            CONTENEDOR = conx_detalles.busca();
            while (CONTENEDOR.Read())
            {
                respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            CONTENEDOR.Close();
            return respuesta;
        }

        public static int Eliminar_Usuario(String _Nombre_Usuario, String _Nombre_Deck, int _ID_Carta, int _Cantidad_Cartas) //eliminar un deck
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC ELIMINAR_DECK ?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_Nombre_Usuario, 2);
            conx_detalles.annadir_parametro(_Nombre_Deck, 2);
            conx_detalles.annadir_parametro(_ID_Carta, 1);
            conx_detalles.annadir_parametro(_Cantidad_Cartas, 1);
            CONTENEDOR = conx_detalles.busca();
            while (CONTENEDOR.Read())
            {
                respuesta = Convert.ToInt32(CONTENEDOR[0].ToString());
            }
            conx_detalles.conexion.Close();
            conx_detalles.conexion.Dispose();
            CONTENEDOR.Close();
            return respuesta;
        }
    }
}