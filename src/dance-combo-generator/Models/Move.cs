using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dance_combo_generator.Models
{
    public enum MoveClassification
    {
        Basic,
        Lollies,
        OutAndIn,
        TossOut,
        PopTurn,
        AdLib,
        Progressive,
        Style,
        PrefabCombo,
        Connection,
        Redirect,
        Turn
    }

    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MoveClassification Classification { get; set; }
        public int NumberOfBeats { get; set; }
        public int DifficultyLevel { get; set; }
    }
}
