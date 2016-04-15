using System.Collections.Generic;
using System.Linq;
using dance_combo_generator.Models;

namespace dance_combo_generator.DataStore
{
    public class SpreadSheetDataStore : IDataStore
    {
        private List<Move> allMoves;
        public SpreadSheetDataStore()
        {            
            allMoves = new List<Move>();

            // http://www.codeproject.com/Articles/670377/Use-Cross-Platform-OSS-ExcelDataReader-to-Read-Exc
            const string path = "wwwroot/movespreadsheet.xlsx";
            var excelData = new ExcelData(path);
            var moves = excelData.getData("Sheet1");

            foreach (var row in moves)
            {
                if (row.ItemArray.Any())
                {
                    var move = new Move
                    {
                        Id = int.Parse(row["Id"].ToString()),
                        Name = row["Name"].ToString(),
                        NumberOfBeats = int.Parse(row["NumberOfBeats"].ToString()),
                        DifficultyLevel = int.Parse(row["DifficultyLevel"].ToString())
                    };
                    allMoves.Add(move);
                }
            }
        }

        public List<Move> GetAllMoves()
        {
            return allMoves;
        }
    }
}