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
        public string Title { get; set; }
    }
}
