using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            sudokuPanel1.SudokuEvnet += sudokuPanel1_SudokuEvnet;
        }
        #region RichTextBox
        void sudokuPanel1_SudokuEvnet(object sender, SudokuCalcs.SudokuEventArgs e)
        {
            Color c = Color.Black;
            switch (e.MessageType)
            {
                case SudokuCalcs.SudokuMessageType.Delete:
                    c = Color.DarkSlateGray;
                    break;
                case SudokuCalcs.SudokuMessageType.Corrcert:
                    c = Color.ForestGreen;
                    break;
                case SudokuCalcs.SudokuMessageType.Error:
                    c = Color.Red;
                    break;
                case SudokuCalcs.SudokuMessageType.Success:
                    c = Color.Green;
                    break;
                case SudokuCalcs.SudokuMessageType.PushStack:
                    c = Color.DarkOrange;
                    break;
                case SudokuCalcs.SudokuMessageType.PopStack:
                    c = Color.Peru;
                    break;
            }
            richTextBox1.SelectionColor = c;
            richTextBox1.AppendText(e.Message+"\r\n");
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;
            richTextBox1.ScrollToCaret();
        }
        #endregion

        #region 操作部分
        private void btnInite_Click(object sender, EventArgs e)
        {
            sudokuPanel1.IniteSudoku();
        }


        //读取当前数据
        private void btnReadData_Click(object sender, EventArgs e)
        {
            string tmps = sudokuPanel1.ReadData();
            richTextBox1.AppendText(tmps+"\r\n");
        }
        //验证
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (sudokuPanel1.GetResult())
            {
                msg = "恭喜你取得胜利！";
            }
            else
            {
                msg = "还没有完成，再接再厉！";
            }
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string rawText = "";
        //加载数据 通过数据库
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            IniteSys();
            var loadForm = new LoadDataForm();
            if (loadForm.ShowDialog() == DialogResult.OK)
            {
                rawText = loadForm.textBox1.Text;
                sudokuPanel1.LoadData(loadForm.textBox1.Text);
            }
        }
        //从本地库随机读取
        private void btnLoadDataRandm_Click(object sender, EventArgs e)
        {
            IniteSys();
            string st = new LoadDataForm().RandomRead();
            rawText = st;
            sudokuPanel1.LoadData(st);
        }
        //重新加载
        private void btnReload_Click(object sender, EventArgs e)
        {
            IniteSys();
            if (!string.IsNullOrEmpty(rawText))
            {
                sudokuPanel1.LoadData(rawText);
            }
        }
        private void IniteSys()
        {
            IniteByTextInput();
        }
        private void IniteByTextInput()
        {
            richTextBox1.Clear();
            sudokuPanel1.IniteSudoku(); ;
        }
        #endregion

        #region 计算部分
        private void calcsStart_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
             sudokuPanel1.StartCalcs();
        }
        private void calcsStep_Click(object sender, EventArgs e)
        {
            sudokuPanel1.RunCalcsByStep();
        }
        private void calcsAll_Click(object sender, EventArgs e)
        {
            sudokuPanel1.RunCalcs();
        }
        #endregion
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sudokuPanel1.PrintSudoku();
        }





    }
}
