using dance_combo_generator.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dance_combo_generator.Controllers
{
    [Route("api/combo")]
    public class ComboController : Controller
    {
        [HttpGet]
        public List<Move> Generate(int numberOfBeats)
        {
            return new List<Move>
            {
                new Move { Name = "Basic" },
                new Move { Name = "Comearound" },
                new Move { Name = "Tossout" }
            };
        }
    }
}
