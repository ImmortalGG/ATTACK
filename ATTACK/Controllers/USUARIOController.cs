using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace ATTACK.Controllers
{
    public class USUARIOController : ApiController
    {
        [HttpPost]
      
        public HttpResponseMessage Post(FormDataCollection form)
        {
            switch (form.Get("op"))
            {
                case "Insertar":
                    {
                        Models.Clase_Usuario.Insertar_Usuario(form.Get("NOMBRE"),form.Get("CORREO"),form.Get("CONTRA"),Convert.ToInt32(form.Get("TIPO")));
                        break;
                    }
                case "Modificar":
                    {
                        Models.Clase_Usuario.Modificar_Usuario(form.Get("NOMBRE"), form.Get("CORREO"), form.Get("CONTRA"), Convert.ToInt32(form.Get("TIPO")));
                        break;
                    }
                case "Eliminar":
                    {
                        Models.Clase_Usuario.Eliminar_Usuario(form.Get("NOMBRE"));
                        break;
                    }
                case "Login":
                    {

                        HttpResponseMessage response = Request.CreateResponse<int>(HttpStatusCode.Created, Models.Clase_Usuario.Login(form.Get("NOMBRE"), form.Get("CONTRA")));
                        return response;
                        break;
                    }
                case "listar":
                    {
                        List<Models.Clase_Usuario> LISTAVACIA = new List<Models.Clase_Usuario>();
                       
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Usuario>>(HttpStatusCode.Created, Models.Clase_Usuario.Todos_los_usuarios());
                        return response;
                    }


            }
            HttpResponseMessage Response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
            return Response;
        }
    }
}
