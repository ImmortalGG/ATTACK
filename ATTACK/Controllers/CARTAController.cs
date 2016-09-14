using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ATTACK.Controllers
{
    public class CARTAController : ApiController
    {
         [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        Models.Clase_Carta.Insertar_Carta(Convert.ToInt32(form.Get("ID")), form.Get("NOMBRE_CARTA"), Convert.ToInt32(form.Get("ATK")), Convert.ToInt32(form.Get("DEF")), Convert.ToInt32(form.Get("HP")), form.Get("PODER"), form.Get("ELEMENTO"));
                        break;
                    }
                case "Modificar":
                    {
                        Models.Clase_Carta.Modificar_Carta(Convert.ToInt32(form.Get("ID")), form.Get("NOMBRE_CARTA"), Convert.ToInt32(form.Get("ATK")), Convert.ToInt32(form.Get("DEF")), Convert.ToInt32(form.Get("HP")), form.Get("PODER"), form.Get("ELEMENTO"));
                        break;
                    }
                case "Eliminar":
                    {
                        Models.Clase_Carta.Insertar_Carta(Convert.ToInt32(form.Get("ID")), form.Get("NOMBRE_CARTA"), Convert.ToInt32(form.Get("ATK")), Convert.ToInt32(form.Get("DEF")), Convert.ToInt32(form.Get("HP")), form.Get("PODER"), form.Get("ELEMENTO"));
                        break;
                    }
                case "listar":
                    {


                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Carta>>(HttpStatusCode.Created, Models.Clase_Carta.Todos_las_cartas());
                        return response;
                    }

            }
            HttpResponseMessage Response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
            return Response;
        }
    }
}
