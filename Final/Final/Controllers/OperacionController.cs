using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionController : ControllerBase
    {

        [HttpGet]
        public string operacion (int numero)
        {
            string respuesta = "";
            if(numero < 0)
            { respuesta = "ERROR";
            }
            if (numero == 0)
            {
                respuesta = "Realizado por Anahi Agreda";
            }
            if (numero > 0)
            {
                respuesta = "Usted ingreso el número" + numero;
            }

            return respuesta;
        }
        [HttpPost]
        public string operacionpost([FromHeader]int numero)
        {
            string respuesta = "";
            if (numero < 0)
            {
                respuesta = "ERROR";
            }
            if (numero == 0)
            {
                respuesta = "Realizado por Anahi Agreda";
            }
            if (numero > 0)
            {
                respuesta = "Usted ingreso el número" + numero;
            }

            return respuesta;
        }

    }
}
