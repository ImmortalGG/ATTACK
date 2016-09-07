﻿using System;
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
                        Models.Clase_combo.Modificar_Combo(Convert.ToInt32(form.Get("Id")), form.Get("Nombre"), Convert.ToInt32(form.Get("Precio")));
                        break;
                    }
                case "Eliminar":
                    {
                        Models.Clase_combo.Elimina_Combo(Convert.ToInt32(form.Get("Id")));
                        break;
                    }
                case "listar":
                    {

                       
                        HttpResponseMessage response = Request.CreateResponse<List<Models.Clase_Usuario>>(HttpStatusCode.Created, Models.Clase_Usuario.Todos_los_usuarios());
                        return response;
                    }

            }
            HttpResponseMessage Response = Request.CreateResponse<int>(HttpStatusCode.Created, 1);
            return Response;
        }
    }
}
