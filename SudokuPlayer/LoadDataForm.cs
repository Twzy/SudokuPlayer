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
    public partial class LoadDataForm : Form
    {
        public LoadDataForm()
        {
            InitializeComponent();
            Sudoku = new SudokuCalcs.SudokuPanel();
            IniteData();
        }
        public SudokuCalcs.SudokuPanel Sudoku;
        string[] SudokuArrys = { "000000800400208051083900007040500082005000400870009030200007160360105004004000000",
                                 "090036000005207000060000300030000078004000290009080000100040500000600407000820003",
                                 "001050000007100804000070320800000040000063090200508006000402000000000107060000000"};

        string[] FromFileSudokuList;
        string filePath = Application.StartupPath + "\\sudoku.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("不是合法的数据！");
            }
        }

        private bool Check()
        {
            if (textBox1.Text.Length < 81)
                return false;
            for (int i = 0; i < 81; i++)
            {
                int t;
                bool c = int.TryParse(textBox1.Text[i].ToString(), out t);
                if (!c)
                {
                    return false;
                }

            }
            return true;
        }

        private void IniteData()
        {

            if (System.IO.File.Exists(filePath))
            {
                FromFileSudokuList = System.IO.File.ReadAllLines(filePath);
                foreach (var i in FromFileSudokuList)
                {
                    if (i.Length < 81)
                        continue;
                    if (listBox1.Items.Contains(i))
                        continue;
                    else
                        listBox1.Items.Add(i);
                }
            }
            else
            {
                listBox1.Items.AddRange(SudokuArrys);
            }
            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Sudoku.LoadData(listBox1.Text);
            label1.Text = SudokuCalcs.BuilderSudoku.ConvertToSudokuStr(listBox1.Text);
            textBox1.Text = listBox1.Text;
        }
        /// <summary>
        /// 随机读取一个数据
        /// </summary>
        /// <returns></returns>
        public string RandomRead()
        {
            Random t = new Random(DateTime.Now.Millisecond);
            int i = t.Next(0, listBox1.Items.Count);
            return listBox1.Items[i] as string;

        }
    }
}
