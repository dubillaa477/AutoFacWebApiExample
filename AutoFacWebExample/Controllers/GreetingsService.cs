using System;

namespace AutoFacWebExample.Controllers
{
    public class GreetingsService : IGreetingsService
    {

        public string GetGreeting() {
            return "Hello at " + DateTime.Now;
        }
    }
}