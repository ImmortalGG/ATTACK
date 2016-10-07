using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace ATTACK.Controllers
{
    public class DECKController : ApiController
    {
        public HttpResponseMessage Post(FormDataCollection form)
        //le llegan las funciones de la pagina que conectan con el visual y luego las envia a la clase que le corresponde
        {
            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        Models.Clase_Deck.Insertar_Deck(form.Get("NOMBRE_USUARIO"), form.Get("NOMBRE_DECK"), Convert.ToInt32(form.Get("ID_CARTA")), Convert.ToInt32(form.Get("CANTIDAD_CARTAS")));
                        break;
                    }
                case "Modificar":
                    {
                        Models.Clase_Deck.Modificar_Deck(form.Get("NOMBRE_USUARIO"), form.Get("NOMBRE_DECK"), Convert.ToInt32(form.Get("ID_CARTA")), Convert.ToInt32(form.Get("CANTIDAD_CARTAS")));
                        break;
                    }
                case "Eliminar":
                    {
                        Models.Clase_Deck.Eliminar_Deck(form.Get("NOMBRE_USUARIO"), form.Get("NOMBRE_DECK"), Convert.ToInt32(form.Get("ID_CARTA")), Convert.ToInt32(form.Get("CANTIDAD_CARTAS")));
                        break;
                    }
                case "listar":
                    {


                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Deck>>(HttpStatusCode.Created, Models.Clase_Deck.Todos_los_decks());
                        return response;
                    }

            }
            HttpResponseMessage Response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
            return Response;
        }
    }
}
