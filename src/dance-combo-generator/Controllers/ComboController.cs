﻿using dance_combo_generator.DataStore;
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
        private readonly IDataStore dataStore;

        public ComboController()
        {
            this.dataStore = new SpreadSheetDataStore();
        }

        [HttpGet]
        public List<Move> Generate(int numberOfMoves, int numberOfBeats)
        {
            var allMoves = dataStore.GetAllMoves();
            
            var eligibleMoves = allMoves;//.Where(am => am.NumberOfBeats <= numberOfBeats).ToList();

            var randomizer = new Random(DateTime.Now.Second);
            var randomizedMoveIds = new List<int>();
            for (var i = 0; i < numberOfMoves; i++)
            {
                randomizedMoveIds.Add(randomizer.Next(0, eligibleMoves.Count));
            }
            
            return eligibleMoves.Where(em => randomizedMoveIds.Contains(em.Id)).Select(x => x).ToList();
        }
    }
}
