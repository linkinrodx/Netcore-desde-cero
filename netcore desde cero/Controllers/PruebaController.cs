using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netcore_desde_cero.Interface;

namespace netcore_desde_cero.Controllers
{
    public class PruebaController : ControllerBase
    {
        private readonly IPruebaRepository pruebaRepository;

        public PruebaController(IPruebaRepository pruebaRepository)
        {
            this.pruebaRepository = pruebaRepository;
        }

        [Route("api/GetPrueba")]
        [HttpGet]
        public JsonResult GetPrueba()
        {
            return new JsonResult(pruebaRepository.GetPrueba());
        }

    }
}