using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuCalcs
{
    class RecoderSudoku
    {
        public int Value { get; set; }
        public int X { get;set;}
        public int Y { get; set; }
        public LiveNumbers[,] SudokuLiveNumbersArry { get; set; }
    }
}
