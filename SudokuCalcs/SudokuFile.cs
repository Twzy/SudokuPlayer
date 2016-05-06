using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace SudokuCalcs
{
    class SudokuFile
    {
        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="path">路径</param>
        public static void Write(string path,int[,] Data)
        {
            try
            {
                File.WriteAllText(path, ConvertIntToString(Data));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 读文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>数独数组</returns>
        public static int[,] Read(string path)
        {
            try
            {
                return ConvertStringToInt(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 字符串转换为原始数据
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static int[,] ConvertStringToInt(string Content)
        {
            if (Content.Length < 81)
            {
                throw new Exception("数据数量不够：" + Content);
            }
            int[,] tmp = new int[9, 9];
            int index = 0;
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        tmp[i, j] = int.Parse(Content[index++].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return tmp;
        }
        /// <summary>
        /// 数组转换为字符串
        /// </summary>
        /// <param name="Datas"></param>
        /// <returns></returns>
        public static string ConvertIntToString(int[,] Datas)
        {
            StringBuilder sbr = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sbr.Append(Datas[i,j].ToString ());
                }
            }

            return  sbr.ToString();
        }
    }
}
