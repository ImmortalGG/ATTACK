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

        public static int Insertar_Carta(int _ID, String _Nombre_Carta, int _ATK, int _DEF, int _HP, String _PODER, String _elemento) //inserta una carta
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC INGRESAR_CARTA ?,?,?,?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_ID, 1);
            conx_detalles.annadir_parametro(_Nombre_Carta, 2);
            conx_detalles.annadir_parametro(_ATK, 1);
            conx_detalles.annadir_parametro(_DEF, 1);
            conx_detalles.annadir_parametro(_HP, 1);
            conx_detalles.annadir_parametro(_PODER, 2);
            conx_detalles.annadir_parametro(_elemento, 2);
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

        public static int Modificar_Carta(int _ID, String _Nombre_Carta, int _ATK, int _DEF, int _HP, String _PODER, String _elemento) //modifica una carta
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC MODIFICAR_CARTA ?,?,?,?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_ID, 1);
            conx_detalles.annadir_parametro(_Nombre_Carta, 2);
            conx_detalles.annadir_parametro(_ATK, 1);
            conx_detalles.annadir_parametro(_DEF, 1);
            conx_detalles.annadir_parametro(_HP, 1);
            conx_detalles.annadir_parametro(_PODER, 2);
            conx_detalles.annadir_parametro(_elemento, 2);
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

        public static int Eliminar_Carta(int _ID, String _Nombre_Carta, int _ATK, int _DEF, int _HP, String _PODER, String _elemento) //eliminar una carta
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC ELIMINAR_CARTA ?,?,?,?,?,?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_ID, 1);
            conx_detalles.annadir_parametro(_Nombre_Carta, 2);
            conx_detalles.annadir_parametro(_ATK, 1);
            conx_detalles.annadir_parametro(_DEF, 1);
            conx_detalles.annadir_parametro(_HP, 1);
            conx_detalles.annadir_parametro(_PODER, 2);
            conx_detalles.annadir_parametro(_elemento, 2);
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