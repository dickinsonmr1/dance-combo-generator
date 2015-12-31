using dance_combo_generator.DataStore;
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
        private IDataStore dataStore;

        public ComboController()
        {
            this.dataStore = new SpreadSheetDataStore();
        }

        [HttpGet]
        public List<Move> Generate(int numberOfBeats)
        {
            var allMoves = dataStore.GetAllMoves();

            return allMoves;//.Where()
        }
    }
}
