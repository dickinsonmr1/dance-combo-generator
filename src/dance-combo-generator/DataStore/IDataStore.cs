using dance_combo_generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dance_combo_generator.DataStore
{
    public interface IDataStore
    {
        List<Move> GetAllMoves();
    }
}
