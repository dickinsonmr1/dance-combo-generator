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
        AdLib,
        Progressive    
    }

    public class Move
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MoveClassification Classification { get; set; }
        public int NumberOfBeats { get; set; }
        public int DifficultyLevel { get; set; }
    }
}
