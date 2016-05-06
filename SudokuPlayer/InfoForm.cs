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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SudokuCalcs.BuilderSudoku.GameArithmetic,"算法原理",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
