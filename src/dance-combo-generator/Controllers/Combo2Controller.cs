using System;
using System.Collections.Generic;
using System.Linq;
using dance_combo_generator.DataStore;
using dance_combo_generator.Models;
using Microsoft.AspNet.Mvc;

namespace dance_combo_generator.Controllers
{
    [Route("api/combobeats")]
    public class ComboBeatsController : Controller
    {
        private readonly IDataStore dataStore;

        public ComboBeatsController()
        {
            this.dataStore = new SpreadSheetDataStore();
        }

        [HttpGet]
        public List<Move> Generate(int numberOfBeats, int difficultyLevel)
        {
            var allMoves = dataStore.GetAllMoves();

            var eligibleMoves = allMoves.Where(x => x.DifficultyLevel <= difficultyLevel).ToList();
            //.Where(am => am.NumberOfBeats <= numberOfBeats).ToList();

            var randomizer = new Random(DateTime.Now.Second);
            var randomizedMoves = new List<Move>();

            while (randomizedMoves.Select(x => x.NumberOfBeats).Sum() < numberOfBeats)
            {
                var availableBeats = numberOfBeats - randomizedMoves.Select(x => x.NumberOfBeats).Sum();
                var eligibleMovesForAvailableBeats = eligibleMoves.Where(x => x.NumberOfBeats <= availableBeats).ToList();

                var nextId = randomizer.Next(0, eligibleMovesForAvailableBeats.Count);
                var moveToAdd = eligibleMovesForAvailableBeats[nextId];
                if (moveToAdd == null)
                    break;
                randomizedMoves.Add(moveToAdd);
            }

            return randomizedMoves;
        }
    }
}