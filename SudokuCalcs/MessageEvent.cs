using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuCalcs
{
    public delegate void SudokuCalcsMessageHanlder(object sender, SudokuEventArgs e);
    public class SudokuEventArgs : EventArgs
    {
        public string Message { get; set; }
        public SudokuMessageType MessageType { get; set; }
    }
    public enum SudokuMessageType
    {
        Delete,
        Corrcert,
        Error,
        Success,
        PopStack,
        PushStack
    }
}
