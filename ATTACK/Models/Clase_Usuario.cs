﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTACK.Models
{
    public class Clase_Usuario
    {
        //parametros de la clase usuario
        private string Nombre;
        private string Correo;
        private string Contra;
        private int Tipo;

        public Clase_Usuario() { }
        //volver publicos los parametros de la clase usuario
        public string _Nombre { get { return Nombre; } set { Nombre = value; } }
        public string _Correo { get { return Correo; } set { Correo = value; } }
        public string _Contra { get { return Contra; } set { Contra = value; } }
        public int _Tipo { get { return Tipo; } set { Tipo = value; } }

        public static int Insertar_Usuario(String _Nombre, String _Correo, String _Contra, int _Tipo) //inserta un usuario
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC CREAR_USUARIO ?,?,?,?";//ejecuta la funcion de la base que permite crear un nuevo usuario
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_Nombre, 2);
            conx_detalles.annadir_parametro(_Correo, 2);
            conx_detalles.annadir_parametro(_Contra, 2);
            conx_detalles.annadir_parametro(_Tipo, 1);
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

        public static int Modificar_Usuario(String _Nombre, String _Correo, String _Contra, int _Tipo) //modifica un usuario
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC MODIFICAR_USUARIO ?,?,?,?";//ejecuta la funcion de la base que permite modificar un usuario
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_Nombre, 2);
            conx_detalles.annadir_parametro(_Correo, 2);
            conx_detalles.annadir_parametro(_Contra, 2);
            conx_detalles.annadir_parametro(_Tipo, 1);
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

        public static int Eliminar_Usuario(String _Nombre) //elimina un usuario
        {
            int respuesta = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC ELIMINAR_USUARIO ?";//ejecuta la funcion de la base que permite eliminar un usuario
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_Nombre, 2);

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


        public static List<Clase_Usuario> Todos_los_usuarios()
        {
            List<Clase_Usuario> listaadevolver = new List<Clase_Usuario>(); //busqueda de los usuarios existentes en la base de datos


            Conexion cnx = new Conexion();
            cnx.parametro();
            cnx.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC SELECCIONAR_USUARIO ?";//ejecuta la funcion de la base que permite seleccionar un usuario
            cnx.annadir_consulta(CONSULTA);
            cnx.annadir_parametro(0, 1);
            CONTENEDOR = cnx.busca();
            while (CONTENEDOR.Read())
            {
                Models.Clase_Usuario nuevousuario = new Models.Clase_Usuario();
                nuevousuario._Contra = CONTENEDOR["CONTRA"].ToString();
                nuevousuario._Correo = CONTENEDOR["CORREO"].ToString();
                nuevousuario._Nombre = CONTENEDOR["NOMBRE"].ToString();
                nuevousuario._Tipo = Convert.ToInt32(CONTENEDOR["TIPO"].ToString());
                listaadevolver.Add(nuevousuario);

            }
            cnx.conexion.Close();
            cnx.conexion.Dispose();
            CONTENEDOR.Close();
            return listaadevolver;

        }

        public static int Login(String _NOMBRE, String _CONTRA)
        { //permite ingresar a una cuenta existente
            int resultado = 0;

            Conexion conx_detalles = new Conexion();
            conx_detalles.parametro();
            conx_detalles.inicializa();
            string CONSULTA;
            System.Data.OleDb.OleDbDataReader CONTENEDOR;

            CONSULTA = "EXEC Login ?,?";
            conx_detalles.annadir_consulta(CONSULTA);
            conx_detalles.annadir_parametro(_NOMBRE, 2);
            conx_detalles.annadir_parametro(_CONTRA, 2);
            CONTENEDOR = conx_detalles.busca();
            while (CONTENEDOR.Read())
            {
                resultado = Convert.ToInt32(CONTENEDOR[0].ToString());
            }
            return resultado;
        }
    
    }
}