using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuCalcs
{
    /// <summary>
    /// 候选数字
    /// </summary>
    class LiveNumbers : ICloneable
    {
        /// <summary>
        /// 每个空格候选数字
        /// </summary>
        public List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        /// <summary>
        /// 该位是否被占用，默认没有
        /// </summary>
        public bool IsSet = false;

        /// <summary>
        /// 记录是否是在原始的数据
        /// </summary>
        public bool IsOrgValue = false;
        /// <summary>
        /// 如果被占用，该值为当前设定的值，如果没被占用，则无效
        /// </summary>
        public int Value = 0;
        /// <summary>
        /// 将数字转换为字符串
        /// </summary>
        public string NumberStr
        {
            get
            {
                if (IsOrgValue || IsSet)
                {
                    return Value.ToString();
                }
                else
                {
                    StringBuilder sbr = new StringBuilder();
                    foreach (var i in Numbers)
                    {
                        sbr.Append(i);
                    }
                    return sbr.ToString();
                }
            }
        }


        /// <summary>
        /// 复制数据
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            List<int> tmpList=new List<int> ();
            foreach(var i in this.Numbers)
            {
                tmpList .Add(i);
            }
            return new LiveNumbers
            {
                IsOrgValue = this.IsOrgValue,
                IsSet = this.IsSet,
                Value = this.Value,
                Numbers = tmpList
            };
        }
    }
}
