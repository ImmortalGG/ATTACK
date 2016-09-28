using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATTACK.Models
{
    public class Cadenaconexion
    {



        public static String cadena_armada(string _usuario, string _ip, string _bd, string _clave)
        {
            String cadena = "";
            String machineName = Environment.MachineName;
            //cadena = "Provider=SQLOLEDB;Data Source=207.210.83.157,1443;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=mjimenez;Password=hotel99;Pooling=False";
            //cadena = "Provider=SQLOLEDB;Data Source=173.201.35.40,1433;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012;Pooling=False";
            //cadena = "Provider=SQLOLEDB;Data Source=SrvrEspressivo/ICG;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012;Pooling=False";
            if (machineName == "DESARROLLO-PC")
            {
                //cadena = "Provider=SQLOLEDB;Data Source=173.201.35.40,1433;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012;Pooling=False";
                //cadena = "Provider=SQLOLEDB;Data Source=DESARROLLO-PC\\SQLDESARROLLO;Initial Catalog=IBS_taquilla_web;Integrated Security=True;Pooling=False";
                // cadena = "Provider=SQLOLEDB;Data Source=MILFOIL.arvixe.com;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=mavar84;Password=Candelabro27;Pooling=False";
                cadena = "Provider=SQLOLEDB;Data Source=192.168.59.150;Initial Catalog=ATTACK;Persist Security Info=True;User ID=desarrollo;Password=pass123;Pooling=False";
                //  cadena = "Provider=SQLOLEDB;Data Source=sistemcr.com;Initial Catalog=Approvecha2;Persist Security Info=True;User ID=Mavar84;Password=Candelabro27;Pooling=False";

            }
            else
            {
                //cadena = "Provider=SQLOLEDB;Data Source=SrvrEspressivo\\ICG;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012";
                //cadena = "Provider=SQLOLEDB;Data Source=DESARROLLO-PC\\SQLDESARROLLO;Initial Catalog=IBS_taquilla_web;Integrated Security=True;Pooling=False";
                //cadena = "Provider=SQLOLEDB;Data Source=MILFOIL.arvixe.com;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=mavar84;Password=Candelabro27;Pooling=False";
                cadena = "Provider=SQLOLEDB;Data Source=192.168.59.150;Initial Catalog=ATTACK;Persist Security Info=True;User ID=desarrollo;Password=pass123;Pooling=False";
                //cadena = "Provider=SQLOLEDB;Data Source=sistemcr.com;Initial Catalog=Approvecha2;Persist Security Info=True;User ID=Mavar84;Password=Candelabro27;Pooling=False";

            }
            return cadena;
        }

        public static String cadena_crm()
        {
            String cadena = "";
            String machineName = Environment.MachineName;
            //cadena = "Provider=SQLOLEDB;Data Source=207.210.83.157,1443;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=mjimenez;Password=hotel99;Pooling=False";
            //cadena = "Provider=SQLOLEDB;Data Source=173.201.35.40,1433;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012;Pooling=False";
            //cadena = "Provider=SQLOLEDB;Data Source=SrvrEspressivo/ICG;Initial Catalog=IBS_taquilla_web;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012;Pooling=False";
            if (machineName == "Sisscr-PC")
            {
                //cadena = "Provider=SQLOLEDB;Data Source=173.201.35.40,1433;Initial Catalog=Espressivo;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012;Pooling=False";
                cadena = "Provider=SQLOLEDB;Data Source=192.168.59.150;Initial Catalog=ATTACK;Persist Security Info=True;User ID=desarrollo;Password=pass123;Pooling=False";
                //cadena = "Data Source=DESARROLLO-PC;Initial Catalog=IBS_taquilla_web;Integrated Security=True";
            }
            else
            {
                //cadena = "Provider=SQLOLEDB;Data Source=SrvrEspressivo\\ICG;Initial Catalog=Espressivo;Persist Security Info=True;User ID=IBS_user;Password=Dionisio2012";
                cadena = "Provider=SQLOLEDB;Data Source=192.168.59.150;Initial Catalog=ATTACK;Persist Security Info=True;User ID=desarrollo;Password=pass123;Pooling=False";
                // cadena = "Data Source=DESARROLLO-PC;Initial Catalog=IBS_taquilla_web;Integrated Security=True";
            }
            return cadena;
        }
    }
}