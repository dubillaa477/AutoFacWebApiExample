using System;

namespace AutoFacWebExample.Controllers
{
    internal class GreetingsService : IGreetingsService
    {

        public string GetGreeting() {
            return "Hello at " + DateTime.Now;
        }
    }
}