using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutoFacWebExample.Controllers
{
    public class GreetingsController : ApiController
    {

        IGreetingsService service;

        //Do not delete because it is necessary to build the container
        public GreetingsController() {

            service = new GreetingsService();
            
        }

        public GreetingsController(IGreetingsService service) {

            this.service = service;
        }

        public string Get() {

            return service.GetGreeting();

            //return "Hello world!";
        }






    }
}
