using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dance_combo_generator.Models;
using System.IO;
using Excel;
using System.Data;

namespace dance_combo_generator.DataStore
{
    public class SpreadSheetDataStore : IDataStore
    {
        private List<Move> allMoves;
        public SpreadSheetDataStore()
        {            
            allMoves = new List<Move>();

            // http://www.codeproject.com/Articles/670377/Use-Cross-Platform-OSS-ExcelDataReader-to-Read-Exc
            string path = "movespreadsheet.xlsx";
            var excelData = new ExcelData(path);
            var moves = excelData.getData("Sheet1");

            foreach (var row in moves)
            {
                if (row.ItemArray.Any())
                {
                    var move = new Move
                    {
                        //Id = int.Parse(row["Id"].ToString()),
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
