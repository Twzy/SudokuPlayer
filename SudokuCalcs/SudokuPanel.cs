using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuCalcs
{

    public partial class SudokuPanel : UserControl
    {
        public SudokuPanel()
        {
            InitializeComponent();
            UpStyle();
            IniteSudoku();
        }

        private void UpStyle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        /// <summary>
        /// 只允许输入数字中的1-9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar < '1' || e.KeyChar > '9';//只允许输入数字
            if (e.KeyChar == (char)8)//退格键
            {
                e.Handled = false;
                ResetSudokuBackColor();
            }
            if (!e.Handled && e.KeyChar != (char)8)
            {
                TextBox txt = sender as TextBox;
                TextTagModle v = txt.Tag as TextTagModle;
                ReturnResult r = CheckText(e.KeyChar.ToString(), v.X, v.Y);
                if (!txt.ReadOnly && !r.Result)
                {
                    txt.BackColor = Color.Tomato;
                    SudokuTextArry[r.X, r.Y].BackColor = Color.Tomato;
                }
            }
        }


        /// <summary>
        /// 控件本身的二维数组
        /// </summary>
        TextBox[,] SudokuTextArry = new TextBox[9, 9];
        /// <summary>
        /// 负责数据推断的数组
        /// </summary>
        LiveNumbers[,] SudokuLiveNumbersArry = new LiveNumbers[9, 9];
        /// <summary>
        /// 剔除重复性选择的栈
        /// </summary>
        Stack<RecoderSudoku> SudokuRecoderStack = new Stack<RecoderSudoku>();
        /// <summary>
        /// 信息通知事件
        /// </summary>
        public event SudokuCalcsMessageHanlder SudokuEvnet;
        int RowIndex = 0;
        int ColIndex = 0;
        int TurnCount = 1;
        int CalcsCount = 0;

        #region 初始化部分
        /// <summary>
        /// 初始化数独界面
        /// </summary>
        public void IniteSudoku()
        {
            AddIntoDic();
            RowIndex = 0;
            ColIndex = 0;
            TurnCount = 1;
            CalcsCount = 0;
            ResetSudoku();
            ResetSudokuBackColor();
        }
        /// <summary>
        /// 重置UI
        /// </summary>
        private void ResetSudoku()
        {
            foreach (TextBox t in SudokuTextArry)
            {
                t.Text = "";
                UpdateTextStyle(t, false, false);

            }
        }
        #endregion

        #region 计算信息事件

        private void SetMessage(string msg, SudokuMessageType msgType)
        {
            if (SudokuEvnet != null)
            {
                SudokuEvnet(this, new SudokuEventArgs() { Message = "第" + (++CalcsCount).ToString() + "步：" + msg, MessageType = msgType });
            }
        }
        private string NumberToAscii(int i)
        {
            char t = (char)(65 + i);
            return t.ToString();
        }
        #endregion

        #region 原始数据的加载与读取
        /// <summary>
        /// 设定数据
        /// </summary>
        /// <param name="orgData"></param>
        /// <param name="isSetReally"></param>
        private void DataSet(int[,] orgData, bool isSetReally)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int tmp = orgData[i, j];
                    TextBox tmpText = SudokuTextArry[i, j];
                    tmpText.Text = (tmp == 0) ? "" : tmp.ToString();
                    if (isSetReally && tmp != 0)
                    {
                        SudokuLiveNumbersArry[i, j].IsOrgValue = true;
                        SudokuLiveNumbersArry[i, j].IsSet = true;
                        SudokuLiveNumbersArry[i, j].Value = tmp;
                        tmpText.ReadOnly = true;
                        tmpText.ForeColor = Color.Blue;
                    }
                }
            }
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        private int[,] DataRead()
        {
            int[,] tmpArry = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string s = SudokuTextArry[i, j].Text;
                    if (string.IsNullOrEmpty(s) || s.Length > 1)
                    {
                        tmpArry[i, j] = 0;
                    }
                    else
                    {
                        tmpArry[i, j] = int.Parse(s);
                    }
                }
            }
            return tmpArry;
        }
        #endregion

        #region 数独列表的更新操作
        private void UpdateTextStyle(TextBox txtBox, bool isCacls, bool isSet)
        {
            if (isCacls)
            {
                if (isSet)
                {
                    txtBox.ReadOnly = true;
                    txtBox.ForeColor = Color.Black;
                    txtBox.Font = new Font("黑体", 14.25f, FontStyle.Bold);
                }
                else
                {
                    txtBox.ReadOnly = true;
                    txtBox.ForeColor = Color.Black;
                    txtBox.Font = new Font("宋体", 8f, FontStyle.Regular);
                }
            }
            else
            {

                txtBox.ReadOnly = false;
                txtBox.ForeColor = Color.Black;
                txtBox.Font = new Font("黑体", 14.25f, FontStyle.Bold);
            }
        }

        private void SetCalcFontStyle()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    bool isOrg = SudokuLiveNumbersArry[i, j].IsOrgValue;
                    if (!isOrg)
                    {
                        bool tmpB = SudokuLiveNumbersArry[i, j].IsSet;
                        UpdateTextStyle(SudokuTextArry[i, j], true, tmpB);
                        SudokuTextArry[i, j].Text = SudokuLiveNumbersArry[i, j].NumberStr;
                    }
                }
            }
        }


        /// <summary>
        /// 计算完毕
        /// </summary>
        private bool isCalcsOver
        {
            get
            {
                foreach (var i in SudokuLiveNumbersArry)
                {
                    if (!i.IsSet)
                        return false;
                }
                ResetSudokuBackColor();
                return true;
            }
        }
        #endregion

        #region 绘制背景颜色



        private void DrawPeers(int x, int y)
        {
            ResetSudokuBackColor();//重置文本框的背景颜色
            DrawPeersBackColor(x, y);//绘制当前需要删除数据的区域
        }

        private void ResetSudokuBackColor()
        {
            DrawTextBoxBackColor(Color.White, 0, 2, 0, 2);
            DrawTextBoxBackColor(Color.PowderBlue, 0, 2, 3, 5);
            DrawTextBoxBackColor(Color.White, 0, 2, 6, 8);

            DrawTextBoxBackColor(Color.PowderBlue, 3, 5, 0, 2);
            DrawTextBoxBackColor(Color.White, 3, 5, 3, 5);
            DrawTextBoxBackColor(Color.PowderBlue, 3, 5, 6, 8);

            DrawTextBoxBackColor(Color.White, 6, 8, 0, 2);
            DrawTextBoxBackColor(Color.PowderBlue, 6, 8, 3, 5);
            DrawTextBoxBackColor(Color.White, 6, 8, 6, 8);


        }
        private void DrawTextBoxBackColor(Color color, int sX, int eX, int sY, int eY)
        {
            int tmpY = sY;
            for (; sX <= eX; sX++)
            {
                tmpY = sY;
                for (; tmpY <= eY; tmpY++)
                {
                    SudokuTextArry[sX, tmpY].BackColor = color;
                }
            }
        }

        private void DrawPeersBackColor(int x, int y)
        {
            Color color = Color.Orange;

            for (int i = 0; i < 9; i++)
            {
                SudokuTextArry[x, i].BackColor = color;
            }

            for (int i = 0; i < 9; i++)
            {
                SudokuTextArry[i, y].BackColor = color;
            }

            DrawSelectUnit(color, x, y);
            SudokuTextArry[x, y].BackColor = Color.DodgerBlue;
        }



        private void DrawSelectUnit(Color value, int x, int y)
        {
            if (x >= 0 && x <= 2)
            {
                if (y >= 0 && y <= 2)
                {
                    DrawTextBoxBackColor(value, 0, 2, 0, 2);
                }
                else if (y >= 3 && y <= 5)
                {
                    DrawTextBoxBackColor(value, 0, 2, 3, 5);
                }
                else if (y >= 6 && y <= 8)
                {
                    DrawTextBoxBackColor(value, 0, 2, 6, 8);
                }
            }
            else if (x >= 3 && x <= 5)
            {
                if (y >= 0 && y <= 2)
                {
                    DrawTextBoxBackColor(value, 3, 5, 0, 2);
                }
                else if (y >= 3 && y <= 5)
                {
                    DrawTextBoxBackColor(value, 3, 5, 3, 5);
                }
                else if (y >= 6 && y <= 8)
                {
                    DrawTextBoxBackColor(value, 3, 5, 6, 8);
                }
            }
            else if (x >= 6 && x <= 8)
            {
                if (y >= 0 && y <= 2)
                {
                    DrawTextBoxBackColor(value, 6, 8, 0, 2);
                }
                else if (y >= 3 && y <= 5)
                {
                    DrawTextBoxBackColor(value, 6, 8, 3, 5);
                }
                else if (y >= 6 && y <= 8)
                {
                    DrawTextBoxBackColor(value, 6, 8, 6, 8);
                }
            }
        }
        #endregion

        #region 删除一个Peers中的已经确定的数字

        /// <summary>
        /// 只能用在删除数据的时候
        /// </summary>
        /// <param name="value"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void ShowSudokuDelectNumber(int value, int x, int y)
        {
            DeleteNumber(value, x, y);//删除数据
            SetMessage("[" + NumberToAscii(x) + "," + (y + 1).ToString() + "] = " + value.ToString() + "，在该位置所在的行、列、小九宫中移除值：" + value.ToString(), SudokuMessageType.Delete);
            DrawPeers(x, y);
            this.Refresh();
            //Application.DoEvents();
        }
        /// <summary>
        /// 删除一个Peers中的已经确定的数字
        /// </summary>
        /// <param name="value"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void DeleteNumber(int value, int x, int y)
        {

            for (int i = 0; i < 9; i++)
            {
                if (!SudokuLiveNumbersArry[x, i].IsSet)
                    SudokuLiveNumbersArry[x, i].Numbers.Remove(value);
            }

            for (int i = 0; i < 9; i++)
            {
                if (!SudokuLiveNumbersArry[i, y].IsSet)
                    SudokuLiveNumbersArry[i, y].Numbers.Remove(value);
            }

            DeleteUnit(value, x, y);
        }

        private void DeleteUnit(int value, int x, int y)
        {
            if (x >= 0 && x <= 2)
            {
                if (y >= 0 && y <= 2)
                {
                    DeleteUnitNumber(value, 0, 2, 0, 2);
                }
                else if (y >= 3 && y <= 5)
                {
                    DeleteUnitNumber(value, 0, 2, 3, 5);
                }
                else if (y >= 6 && y <= 8)
                {
                    DeleteUnitNumber(value, 0, 2, 6, 8);
                }
            }
            else if (x >= 3 && x <= 5)
            {
                if (y >= 0 && y <= 2)
                {
                    DeleteUnitNumber(value, 3, 5, 0, 2);
                }
                else if (y >= 3 && y <= 5)
                {
                    DeleteUnitNumber(value, 3, 5, 3, 5);
                }
                else if (y >= 6 && y <= 8)
                {
                    DeleteUnitNumber(value, 3, 5, 6, 8);
                }
            }
            else if (x >= 6 && x <= 8)
            {
                if (y >= 0 && y <= 2)
                {
                    DeleteUnitNumber(value, 6, 8, 0, 2);
                }
                else if (y >= 3 && y <= 5)
                {
                    DeleteUnitNumber(value, 6, 8, 3, 5);
                }
                else if (y >= 6 && y <= 8)
                {
                    DeleteUnitNumber(value, 6, 8, 6, 8);
                }
            }
        }
        private void DeleteUnitNumber(int value, int sX, int eX, int sY, int eY)
        {
            int tmpY = sY;
            for (; sX <= eX; sX++)
            {
                tmpY = sY;
                for (; tmpY <= eY; tmpY++)
                {
                    if (!SudokuLiveNumbersArry[sX, tmpY].IsSet)
                    {
                        SudokuLiveNumbersArry[sX, tmpY].Numbers.Remove(value);
                    }
                }
            }
        }
        #endregion

        #region 复制数据

        /// <summary>
        /// 复制当前列表
        /// </summary>
        /// <returns></returns>
        private LiveNumbers[,] CopySudokuLiveNumber()
        {
            LiveNumbers[,] tmpArr = new LiveNumbers[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tmpArr[i, j] = SudokuLiveNumbersArry[i, j].Clone() as LiveNumbers;
                }
            }
            return tmpArr;
        }
        #endregion

        #region 寻找可用的数值
        /// <summary>
        /// 确定后更新数值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void SetCorrcertNumber(int value, int x, int y)
        {
            SudokuLiveNumbersArry[x, y].IsSet = true;
            SudokuLiveNumbersArry[x, y].Value = value;
            SetMessage("[" + NumberToAscii(x) + "," + (y + 1).ToString() + "] = " + value.ToString() + " 具有唯一值。", SudokuMessageType.Corrcert);
            ShowSudokuDelectNumber(value, x, y);//通过更新至删除peer中确定的数字
            SetCalcFontStyle();//刷新表格

        }
        /// <summary>
        /// 记录数值
        /// </summary>
        /// <param name="Recoder"></param>
        /// <returns></returns>
        private bool LogRecoder(List<RecoderSudoku> Recoder)
        {
            if (Recoder.Count == 1)
            {
                SetCorrcertNumber(Recoder[0].Value, Recoder[0].X, Recoder[0].Y);
                return true;
            }
            else if (Recoder.Count > 1)
            {
                for (int i = 1; i < Recoder.Count; i++)
                {
                    SetMessage("[" + NumberToAscii(Recoder[i].X) + "," + (Recoder[i].Y + 1).ToString() + "]位置具有多个可选值，可选值入栈：" + Recoder[i].Value.ToString(), SudokuMessageType.PushStack);
                    SudokuRecoderStack.Push(Recoder[i]);
                }
                SetCorrcertNumber(Recoder[0].Value, Recoder[0].X, Recoder[0].Y);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 获取剩余值最少的Item
        /// </summary>
        /// <returns></returns>
        private SelectItem GetMinSelectCountItem()
        {
            SelectItem tmp = null;
            int MinCount = 9;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var t = SudokuLiveNumbersArry[i, j];
                    if (t.IsSet) continue;
                    if (t.Numbers.Count < MinCount)
                    {
                        tmp = new SelectItem
                        {
                            IsOrgValue = t.IsOrgValue,
                            IsSet = t.IsSet,
                            Numbers = t.Numbers,
                            Value = t.Value
                        };
                        tmp.X = i;
                        tmp.Y = j;
                        MinCount = t.Numbers.Count;
                    }
                }
            }
            return tmp;
        }

        private void FindItem()
        {
            SelectItem item = GetMinSelectCountItem();
            if (item == null) throw new Exception("1.FindItem()有错误！");

            if (item.Numbers.Count == 0)
            {
                //TODO出栈
                if (SudokuRecoderStack.Count <= 0)
                {

                    SetMessage("该数独模型无解！", SudokuMessageType.Error);
                    StopCalcs();
                    return;
                }
                RecoderSudoku r = SudokuRecoderStack.Pop();
                SudokuLiveNumbersArry = r.SudokuLiveNumbersArry;
                SetMessage("[" + NumberToAscii(r.X) + "," + (r.Y + 1).ToString() + "] 位置在栈中存在可选值，出栈：" + r.Value.ToString(), SudokuMessageType.PopStack);
                List<RecoderSudoku> tmpList = new List<RecoderSudoku>();
                tmpList.Add(new RecoderSudoku { X = r.X, Y = r.Y, Value = r.Value, SudokuLiveNumbersArry = CopySudokuLiveNumber() });
                LogRecoder(tmpList);
                FindItem();
            }
            else //count>0
            {
                List<RecoderSudoku> tmpList = new List<RecoderSudoku>();
                foreach (var i in item.Numbers)
                {
                    tmpList.Add(new RecoderSudoku { X = item.X, Y = item.Y, Value = i, SudokuLiveNumbersArry = CopySudokuLiveNumber() });
                }
                LogRecoder(tmpList);
            }
        }
        #endregion

        #region 验证选定值是否合适

        public bool GetResult()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var tmp = SudokuTextArry[i, j];
                    if (string.IsNullOrEmpty(tmp.Text))
                        return false;
                    if (!CheckText(tmp.Text, i, j).Result)
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        private ReturnResult CheckText(string value, int x, int y)
        {
            for (int i = 0; i < 9; i++)//横纵验证
            {
                var tmp1 = SudokuTextArry[x, i];

                if (tmp1.Text.Length == 1 && tmp1.Text == value && i != y)
                {
                    return new ReturnResult { Result = false, X = x, Y = i, Value = int.Parse(value) };
                }
            }
            for (int i = 0; i < 9; i++)
            {
                var tmp2 = SudokuTextArry[i, y];
                if (tmp2.Text.Length == 1 && tmp2.Text == value && i != x)
                {
                    return new ReturnResult { Result = false, X = i, Y = y, Value = int.Parse(value) };
                }
            }
            return CheckUnitText(value, x, y);
        }
        private ReturnResult CheckUnitText(string value, int x, int y)
        {
            if (x >= 0 && x <= 2)
            {
                if (y >= 0 && y <= 2)
                {
                    return CheckUnitNumberText(value, 0, 2, 0, 2, x, y);
                }
                else if (y >= 3 && y <= 5)
                {
                    return CheckUnitNumberText(value, 0, 2, 3, 5, x, y);
                }
                else if (y >= 6 && y <= 8)
                {
                    return CheckUnitNumberText(value, 0, 2, 6, 8, x, y);
                }
            }
            else if (x >= 3 && x <= 5)
            {
                if (y >= 0 && y <= 2)
                {
                    return CheckUnitNumberText(value, 3, 5, 0, 2, x, y);
                }
                else if (y >= 3 && y <= 5)
                {
                    return CheckUnitNumberText(value, 3, 5, 3, 5, x, y);
                }
                else if (y >= 6 && y <= 8)
                {
                    return CheckUnitNumberText(value, 3, 5, 6, 8, x, y);
                }
            }
            else if (x >= 6 && x <= 8)
            {
                if (y >= 0 && y <= 2)
                {
                    return CheckUnitNumberText(value, 6, 8, 0, 2, x, y);
                }
                else if (y >= 3 && y <= 5)
                {
                    return CheckUnitNumberText(value, 6, 8, 3, 5, x, y);
                }
                else if (y >= 6 && y <= 8)
                {
                    return CheckUnitNumberText(value, 6, 8, 6, 8, x, y);
                }
            }
            throw new Exception("位置的坐标值：" + x.ToString() + "," + y.ToString());
        }
        private ReturnResult CheckUnitNumberText(string value, int sX, int eX, int sY, int eY, int inputX, int inputY)
        {
            int tmpY = sY;
            for (; sX <= eX; sX++)
            {
                tmpY = sY;
                for (; tmpY <= eY; tmpY++)
                {
                    if (inputX != sX && inputY != tmpY &&
                        SudokuTextArry[sX, tmpY].Text.Length == 1 &&
                        SudokuTextArry[sX, tmpY].Text == value)
                    {
                        return new ReturnResult { Result = false, X = sX, Y = tmpY, Value = int.Parse(value) };
                    }
                }
            }
            return new ReturnResult { Result = true, X = sX, Y = tmpY, Value = int.Parse(value) }; ;
        }

        #endregion

        #region 计算部分

        /// <summary>
        /// 确定是否为计算模式
        /// </summary>
        bool IsCalcsMode = false;
        /// <summary>
        /// 初始化计算
        /// </summary>
        public void StartCalcs()
        {
            SetDataToNumberlist();
            if (CalcsCheck())
            {
                IsCalcsMode = true;
                SetCalcFontStyle();
            }
            else
            {
                MessageBox.Show("给定的数字为空，不能进行计算！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void StopCalcs()
        {
            RowIndex = 0;
            ColIndex = 0;
            TurnCount = 1;
            CalcsCount = 0;
            IsCalcsMode = false;
        }
        /// <summary>
        ///读取现有数据，并加载
        /// </summary>
        private void SetDataToNumberlist()
        {
            DataSet(DataRead(), true);
        }
        private bool CalcsCheck()
        {
            int tmp = 0;//不可以执行
            foreach (var i in SudokuLiveNumbersArry)
            {
                if (i.IsSet)
                {
                    tmp++;
                }
            }
            if (tmp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 按步骤进行计算
        /// </summary>
        public void RunCalcsByStep()
        {
            if (!IsCalcsMode)
            {
                MessageBox.Show("计算模式没有开启！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isCalcsOver)
            {
                SetMessage("计算完成。", SudokuMessageType.Success);
                StopCalcs();
                return;
            }

            while (TurnCount == 1&&!isCalcsOver && IsCalcsMode  )
            {
                if (ColIndex >= 9)
                {
                    RowIndex++;
                    ColIndex = 0;
                }
                if (RowIndex >= 9)
                {
                    TurnCount++;
                    return;
                }
                LiveNumbers tmpL = SudokuLiveNumbersArry[RowIndex, ColIndex];
                if (tmpL.IsSet)
                {
                    ShowSudokuDelectNumber(tmpL.Value, RowIndex, ColIndex);
                    ColIndex++;
                    break;
                }
                ColIndex++;
                if (CheckSudoku()) return;
            }

            if (!isCalcsOver && TurnCount >= 2 && IsCalcsMode)
            {
                FindItem();
                if (CheckSudoku()) return;
            }
            SetCalcFontStyle();//更新文本字体
        }
        /// <summary>
        /// 快速计算
        /// </summary>
        public void RunCalcs()
        {
            if (!IsCalcsMode)
            {
                MessageBox.Show("计算模式没有开启！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (CheckSudoku()) return;
            while (TurnCount == 1 && !isCalcsOver && IsCalcsMode)
            {
                if (ColIndex >= 9)
                {
                    RowIndex++;
                    ColIndex = 0;
                }
                if (RowIndex >= 9)
                {
                    TurnCount++;
                    break;
                }
                LiveNumbers tmpL = SudokuLiveNumbersArry[RowIndex, ColIndex];
                if (tmpL.IsSet)
                {
                    ShowSudokuDelectNumber(tmpL.Value, RowIndex, ColIndex);
                    ColIndex++;
                    continue;
                }
                ColIndex++;
                if (CheckSudoku()) return;

            }
            while (!isCalcsOver && IsCalcsMode)
            {
                FindItem();

                if (CheckSudoku()) return;
            }
        }
        private bool CheckSudoku()
        {
            if (isCalcsOver)
            {
                string tmp = "计算完成。";
                SetMessage(tmp, SudokuMessageType.Success);
                StopCalcs();
                return true;
            }
            else
                return false;
        }
        #endregion

        #region 加载与读取
        public void LoadData(string content)
        {
            IniteSudoku();

            try
            {
                DataSet(SudokuFile.ConvertStringToInt(content), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入数据有误," + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IniteSudoku();
                return;
            }
        }
        public void LoadData(int[,] Data)
        {
            IniteSudoku();
            try
            {
                DataSet(Data, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入数据有误," + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IniteSudoku();
                return;
            }
        }
        public string ReadData()
        {
            return SudokuFile.ConvertIntToString(DataRead());
        }

        #endregion

        #region 截图与打印

        public Image GetSudokuPicture()
        {
            Bitmap bit = new Bitmap(this.Width, this.Height);
            Graphics gp = Graphics.FromImage(bit);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gp.Clear(Color.White);
            gp.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(this.Width, this.Height));
            return bit;
        }

        Image printImage;
        public void PrintSudoku()
        {
            printImage = GetSudokuPicture();
            PrintPreviewDialog pr = new PrintPreviewDialog();
            pr.Document = this.printDocument1;

            //pr.UseAntiAlias = true;
            pr.Width = 800;
            pr.Height = 600;
            pr.PrintPreviewControl.Zoom = 1;
            pr.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int LineSpanLeft = (e.PageBounds.Width - 750) / 2;
            int ImageSpanLeft = (e.PageBounds.Width - printImage.Width) / 2;
            Pen p = new Pen(Color.Black, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //页眉
            e.Graphics.DrawImage(Properties.Resources.Sudoku, new Rectangle(LineSpanLeft + 15, 50, 25, 25), new Rectangle(0, 0, Properties.Resources.Sudoku.Width, Properties.Resources.Sudoku.Height), GraphicsUnit.Pixel);
            e.Graphics.DrawString("数独计算器 v1.1", new Font("黑体", 10), new SolidBrush(Color.Black), new PointF(LineSpanLeft + 45, 60));
            e.Graphics.DrawImage(Properties.Resources.moyun, new Rectangle(e.PageBounds.Width - LineSpanLeft - 80, 32, 60, 60), new Rectangle(0, 0, 200, 200), GraphicsUnit.Pixel);
            e.Graphics.DrawLine(p, new Point(LineSpanLeft, 80), new Point(e.PageBounds.Width - LineSpanLeft, 80));


            //画数独
            e.Graphics.DrawImage(printImage, ImageSpanLeft, 120);


            Font txtHeadFont = new System.Drawing.Font("黑体", 13);
            Font txtFont = new System.Drawing.Font("黑体", 10);
            //绘制玩法：
            e.Graphics.DrawString("数独游戏规则", txtHeadFont, new SolidBrush(Color.Black), new PointF(ImageSpanLeft - 100, 540));
            e.Graphics.DrawString(Properties.Resources.GameRule, txtFont, new SolidBrush(Color.Black), new PointF(ImageSpanLeft - 100, 570));
            //绘制算法
            e.Graphics.DrawString("数独算法规则", txtHeadFont, new SolidBrush(Color.Black), new PointF(ImageSpanLeft - 100, 670));
            e.Graphics.DrawString(Properties.Resources.GameArithmetic, txtFont, new SolidBrush(Color.Black), new PointF(ImageSpanLeft - 100, 700));


            //页脚
            int PageFoot = e.PageBounds.Height - 80;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(LineSpanLeft, PageFoot), new Point(e.PageBounds.Width - LineSpanLeft, PageFoot));
            e.Graphics.DrawString("SudokuCalcs Lib v1.2.    Copyright © 墨云软件 LTD 2013.                                       " + DateTime.Now.ToLocalTime().ToString(),
                      new Font("宋体", 9), new SolidBrush(Color.Black), new PointF(LineSpanLeft + 10, PageFoot + 10));

        }
        #endregion

        #region 生成各种形式的数独表型方式

        public override string ToString()
        {
            StringBuilder sbr = new StringBuilder();
            foreach (var i in SudokuLiveNumbersArry)
            {
                sbr.Append(i.IsSet ? i.Value.ToString() : "0");
            }
            return BuilderSudoku.ConvertToSudokuStr(sbr.ToString());
        }

        #endregion


    }
}
