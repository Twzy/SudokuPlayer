using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace SudokuCalcs
{
    /// <summary>
    /// 创建数独的各种现实方式
    /// </summary>
    public class BuilderSudoku
    {
        /// <summary>
        /// 将字符串转化为数独
        /// </summary>
        /// <param name="contents"></param>
        /// <returns></returns>
        public static string ConvertToSudokuStr(string contents)
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendLine("┌───┬───┬───┐");

            for (int i = 0; i < 81; i++)
            {
                if (i == 27 || i == 54)
                {
                    sbr.AppendLine("├───┼───┼───┤");
                }
                if (i % 9 == 0)//必须在数字输入之前
                {
                    sbr.Append("│");
                }
                sbr.Append(((contents[i] == '0') ? ". " : contents[i].ToString() + " "));
                if (i % 3 == 2)//必须在数字输入之后
                {
                    sbr.Append("│");
                }
                if (i % 9 == 8)
                {
                    sbr.AppendLine();
                }
            }
            sbr.AppendLine("└───┴───┴───┘");
            return sbr.ToString();
        }

        public static string GameArithmetic
        {
            get
            {
                return Properties.Resources.GameArithmetic;
            }
        }

        //public static Image ConvertToImage(string contents)
        //{
        //    int Width = 350;
        //    int span=
        //}

        //public static Image ConvertToImage(int[,] data)
        //{
           
        //}
    }
}
