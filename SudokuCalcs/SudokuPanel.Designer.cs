using System.Drawing;
namespace SudokuCalcs
{
    partial class SudokuPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// 将TextBox与组关联起来
        /// </summary>
        void AddIntoDic()
        {
            #region  初始化文本框数组
            //0
            SudokuTextArry[0, 0] = textBox1;
            SudokuTextArry[0, 1] = textBox2;
            SudokuTextArry[0, 2] = textBox3;
            SudokuTextArry[0, 3] = textBox4;
            SudokuTextArry[0, 4] = textBox5;
            SudokuTextArry[0, 5] = textBox6;
            SudokuTextArry[0, 6] = textBox7;
            SudokuTextArry[0, 7] = textBox8;
            SudokuTextArry[0, 8] = textBox9;


            //1
            SudokuTextArry[1, 0] = textBox10;
            SudokuTextArry[1, 1] = textBox11;
            SudokuTextArry[1, 2] = textBox12;
            SudokuTextArry[1, 3] = textBox13;
            SudokuTextArry[1, 4] = textBox14;
            SudokuTextArry[1, 5] = textBox15;
            SudokuTextArry[1, 6] = textBox16;
            SudokuTextArry[1, 7] = textBox17;
            SudokuTextArry[1, 8] = textBox18;


            //2
            SudokuTextArry[2, 0] = textBox19;
            SudokuTextArry[2, 1] = textBox20;
            SudokuTextArry[2, 2] = textBox21;
            SudokuTextArry[2, 3] = textBox22;
            SudokuTextArry[2, 4] = textBox23;
            SudokuTextArry[2, 5] = textBox24;
            SudokuTextArry[2, 6] = textBox25;
            SudokuTextArry[2, 7] = textBox26;
            SudokuTextArry[2, 8] = textBox27;


            //3
            SudokuTextArry[3, 0] = textBox28;
            SudokuTextArry[3, 1] = textBox29;
            SudokuTextArry[3, 2] = textBox30;
            SudokuTextArry[3, 3] = textBox31;
            SudokuTextArry[3, 4] = textBox32;
            SudokuTextArry[3, 5] = textBox33;
            SudokuTextArry[3, 6] = textBox34;
            SudokuTextArry[3, 7] = textBox35;
            SudokuTextArry[3, 8] = textBox36;


            //4
            SudokuTextArry[4, 0] = textBox37;
            SudokuTextArry[4, 1] = textBox38;
            SudokuTextArry[4, 2] = textBox39;
            SudokuTextArry[4, 3] = textBox40;
            SudokuTextArry[4, 4] = textBox41;
            SudokuTextArry[4, 5] = textBox42;
            SudokuTextArry[4, 6] = textBox43;
            SudokuTextArry[4, 7] = textBox44;
            SudokuTextArry[4, 8] = textBox45;


            //5
            SudokuTextArry[5, 0] = textBox46;
            SudokuTextArry[5, 1] = textBox47;
            SudokuTextArry[5, 2] = textBox48;
            SudokuTextArry[5, 3] = textBox49;
            SudokuTextArry[5, 4] = textBox50;
            SudokuTextArry[5, 5] = textBox51;
            SudokuTextArry[5, 6] = textBox52;
            SudokuTextArry[5, 7] = textBox53;
            SudokuTextArry[5, 8] = textBox54;


            //6
            SudokuTextArry[6, 0] = textBox55;
            SudokuTextArry[6, 1] = textBox56;
            SudokuTextArry[6, 2] = textBox57;
            SudokuTextArry[6, 3] = textBox58;
            SudokuTextArry[6, 4] = textBox59;
            SudokuTextArry[6, 5] = textBox60;
            SudokuTextArry[6, 6] = textBox61;
            SudokuTextArry[6, 7] = textBox62;
            SudokuTextArry[6, 8] = textBox63;


            //7
            SudokuTextArry[7, 0] = textBox64;
            SudokuTextArry[7, 1] = textBox65;
            SudokuTextArry[7, 2] = textBox66;
            SudokuTextArry[7, 3] = textBox67;
            SudokuTextArry[7, 4] = textBox68;
            SudokuTextArry[7, 5] = textBox69;
            SudokuTextArry[7, 6] = textBox70;
            SudokuTextArry[7, 7] = textBox71;
            SudokuTextArry[7, 8] = textBox72;


            //8
            SudokuTextArry[8, 0] = textBox73;
            SudokuTextArry[8, 1] = textBox74;
            SudokuTextArry[8, 2] = textBox75;
            SudokuTextArry[8, 3] = textBox76;
            SudokuTextArry[8, 4] = textBox77;
            SudokuTextArry[8, 5] = textBox78;
            SudokuTextArry[8, 6] = textBox79;
            SudokuTextArry[8, 7] = textBox80;
            SudokuTextArry[8, 8] = textBox81;
            #endregion


            #region 每个文本框带有自己的坐标
            //0
            textBox1.Tag = new TextTagModle { X = 0, Y = 0 };
            textBox2.Tag = new TextTagModle { X = 0, Y = 1 };
            textBox3.Tag = new TextTagModle { X = 0, Y = 2 };
            textBox4.Tag = new TextTagModle { X = 0, Y = 3 };
            textBox5.Tag = new TextTagModle { X = 0, Y = 4 };
            textBox6.Tag = new TextTagModle { X = 0, Y = 5 };
            textBox7.Tag = new TextTagModle { X = 0, Y = 6 };
            textBox8.Tag = new TextTagModle { X = 0, Y = 7 };
            textBox9.Tag = new TextTagModle { X = 0, Y = 8 };


            //1
            textBox10.Tag = new TextTagModle { X = 1, Y = 0 };
            textBox11.Tag = new TextTagModle { X = 1, Y = 1 };
            textBox12.Tag = new TextTagModle { X = 1, Y = 2 };
            textBox13.Tag = new TextTagModle { X = 1, Y = 3 };
            textBox14.Tag = new TextTagModle { X = 1, Y = 4 };
            textBox15.Tag = new TextTagModle { X = 1, Y = 5 };
            textBox16.Tag = new TextTagModle { X = 1, Y = 6 };
            textBox17.Tag = new TextTagModle { X = 1, Y = 7 };
            textBox18.Tag = new TextTagModle { X = 1, Y = 8 };


            //2
            textBox19.Tag = new TextTagModle { X = 2, Y = 0 };
            textBox20.Tag = new TextTagModle { X = 2, Y = 1 };
            textBox21.Tag = new TextTagModle { X = 2, Y = 2 };
            textBox22.Tag = new TextTagModle { X = 2, Y = 3 };
            textBox23.Tag = new TextTagModle { X = 2, Y = 4 };
            textBox24.Tag = new TextTagModle { X = 2, Y = 5 };
            textBox25.Tag = new TextTagModle { X = 2, Y = 6 };
            textBox26.Tag = new TextTagModle { X = 2, Y = 7 };
            textBox27.Tag = new TextTagModle { X = 2, Y = 8 };


            //3
            textBox28.Tag = new TextTagModle { X = 3, Y = 0 };
            textBox29.Tag = new TextTagModle { X = 3, Y = 1 };
            textBox30.Tag = new TextTagModle { X = 3, Y = 2 };
            textBox31.Tag = new TextTagModle { X = 3, Y = 3 };
            textBox32.Tag = new TextTagModle { X = 3, Y = 4 };
            textBox33.Tag = new TextTagModle { X = 3, Y = 5 };
            textBox34.Tag = new TextTagModle { X = 3, Y = 6 };
            textBox35.Tag = new TextTagModle { X = 3, Y = 7 };
            textBox36.Tag = new TextTagModle { X = 3, Y = 8 };


            //4
            textBox37.Tag = new TextTagModle { X = 4, Y = 0 };
            textBox38.Tag = new TextTagModle { X = 4, Y = 1 };
            textBox39.Tag = new TextTagModle { X = 4, Y = 2 };
            textBox40.Tag = new TextTagModle { X = 4, Y = 3 };
            textBox41.Tag = new TextTagModle { X = 4, Y = 4 };
            textBox42.Tag = new TextTagModle { X = 4, Y = 5 };
            textBox43.Tag = new TextTagModle { X = 4, Y = 6 };
            textBox44.Tag = new TextTagModle { X = 4, Y = 7 };
            textBox45.Tag = new TextTagModle { X = 4, Y = 8 };


            //5
            textBox46.Tag = new TextTagModle { X = 5, Y = 0 };
            textBox47.Tag = new TextTagModle { X = 5, Y = 1 };
            textBox48.Tag = new TextTagModle { X = 5, Y = 2 };
            textBox49.Tag = new TextTagModle { X = 5, Y = 3 };
            textBox50.Tag = new TextTagModle { X = 5, Y = 4 };
            textBox51.Tag = new TextTagModle { X = 5, Y = 5 };
            textBox52.Tag = new TextTagModle { X = 5, Y = 6 };
            textBox53.Tag = new TextTagModle { X = 5, Y = 7 };
            textBox54.Tag = new TextTagModle { X = 5, Y = 8 };


            //6
            textBox55.Tag = new TextTagModle { X = 6, Y = 0 };
            textBox56.Tag = new TextTagModle { X = 6, Y = 1 };
            textBox57.Tag = new TextTagModle { X = 6, Y = 2 };
            textBox58.Tag = new TextTagModle { X = 6, Y = 3 };
            textBox59.Tag = new TextTagModle { X = 6, Y = 4 };
            textBox60.Tag = new TextTagModle { X = 6, Y = 5 };
            textBox61.Tag = new TextTagModle { X = 6, Y = 6 };
            textBox62.Tag = new TextTagModle { X = 6, Y = 7 };
            textBox63.Tag = new TextTagModle { X = 6, Y = 8 };


            //7
            textBox64.Tag = new TextTagModle { X = 7, Y = 0 };
            textBox65.Tag = new TextTagModle { X = 7, Y = 1 };
            textBox66.Tag = new TextTagModle { X = 7, Y = 2 };
            textBox67.Tag = new TextTagModle { X = 7, Y = 3 };
            textBox68.Tag = new TextTagModle { X = 7, Y = 4 };
            textBox69.Tag = new TextTagModle { X = 7, Y = 5 };
            textBox70.Tag = new TextTagModle { X = 7, Y = 6 };
            textBox71.Tag = new TextTagModle { X = 7, Y = 7 };
            textBox72.Tag = new TextTagModle { X = 7, Y = 8 };


            //8
            textBox73.Tag = new TextTagModle { X = 8, Y = 0 };
            textBox74.Tag = new TextTagModle { X = 8, Y = 1 };
            textBox75.Tag = new TextTagModle { X = 8, Y = 2 };
            textBox76.Tag = new TextTagModle { X = 8, Y = 3 };
            textBox77.Tag = new TextTagModle { X = 8, Y = 4 };
            textBox78.Tag = new TextTagModle { X = 8, Y = 5 };
            textBox79.Tag = new TextTagModle { X = 8, Y = 6 };
            textBox80.Tag = new TextTagModle { X = 8, Y = 7 };
            textBox81.Tag = new TextTagModle { X = 8, Y = 8 };



            #endregion 
            //数组
            #region 初始化剩余数字数组
            //0
            SudokuLiveNumbersArry[0, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[0, 8] = new LiveNumbers();


            //1
            SudokuLiveNumbersArry[1, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[1, 8] = new LiveNumbers();


            //2
            SudokuLiveNumbersArry[2, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[2, 8] = new LiveNumbers();


            //3
            SudokuLiveNumbersArry[3, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[3, 8] = new LiveNumbers();


            //4
            SudokuLiveNumbersArry[4, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[4, 8] = new LiveNumbers();


            //5
            SudokuLiveNumbersArry[5, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[5, 8] = new LiveNumbers();


            //6
            SudokuLiveNumbersArry[6, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[6, 8] = new LiveNumbers();


            //7
            SudokuLiveNumbersArry[7, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[7, 8] = new LiveNumbers();


            //8
            SudokuLiveNumbersArry[8, 0] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 1] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 2] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 3] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 4] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 5] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 6] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 7] = new LiveNumbers();
            SudokuLiveNumbersArry[8, 8] = new LiveNumbers();
            #endregion



        }
        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(7, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox1.MaxLength = 1;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(42, 8);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 35);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(77, 8);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox3.MaxLength = 1;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 35);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(112, 8);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox4.MaxLength = 1;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 35);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(147, 8);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox5.MaxLength = 1;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 35);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(182, 8);
            this.textBox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox6.MaxLength = 1;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 35);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(217, 8);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox7.MaxLength = 1;
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(35, 35);
            this.textBox7.TabIndex = 6;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(252, 8);
            this.textBox8.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox8.MaxLength = 1;
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(35, 35);
            this.textBox8.TabIndex = 7;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(287, 8);
            this.textBox9.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox9.MaxLength = 1;
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(35, 35);
            this.textBox9.TabIndex = 8;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(7, 43);
            this.textBox10.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox10.MaxLength = 1;
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(35, 35);
            this.textBox10.TabIndex = 9;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(42, 43);
            this.textBox11.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox11.MaxLength = 1;
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(35, 35);
            this.textBox11.TabIndex = 10;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.Location = new System.Drawing.Point(77, 43);
            this.textBox12.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox12.MaxLength = 1;
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(35, 35);
            this.textBox12.TabIndex = 11;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox13.Location = new System.Drawing.Point(112, 43);
            this.textBox13.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox13.MaxLength = 1;
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(35, 35);
            this.textBox13.TabIndex = 12;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox14.Location = new System.Drawing.Point(147, 43);
            this.textBox14.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox14.MaxLength = 1;
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(35, 35);
            this.textBox14.TabIndex = 13;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox15.Location = new System.Drawing.Point(182, 43);
            this.textBox15.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox15.MaxLength = 1;
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(35, 35);
            this.textBox15.TabIndex = 14;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.Location = new System.Drawing.Point(217, 43);
            this.textBox16.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox16.MaxLength = 1;
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(35, 35);
            this.textBox16.TabIndex = 15;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.White;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox17.Location = new System.Drawing.Point(252, 43);
            this.textBox17.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox17.MaxLength = 1;
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(35, 35);
            this.textBox17.TabIndex = 16;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.White;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox18.Location = new System.Drawing.Point(287, 43);
            this.textBox18.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox18.MaxLength = 1;
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(35, 35);
            this.textBox18.TabIndex = 17;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.White;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox19.Location = new System.Drawing.Point(7, 78);
            this.textBox19.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox19.MaxLength = 1;
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(35, 35);
            this.textBox19.TabIndex = 18;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.White;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox20.Location = new System.Drawing.Point(42, 78);
            this.textBox20.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox20.MaxLength = 1;
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(35, 35);
            this.textBox20.TabIndex = 19;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.White;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox21.Location = new System.Drawing.Point(77, 78);
            this.textBox21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox21.MaxLength = 1;
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(35, 35);
            this.textBox21.TabIndex = 20;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox22.Location = new System.Drawing.Point(112, 78);
            this.textBox22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox22.MaxLength = 1;
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(35, 35);
            this.textBox22.TabIndex = 21;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox23.Location = new System.Drawing.Point(147, 78);
            this.textBox23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox23.MaxLength = 1;
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(35, 35);
            this.textBox23.TabIndex = 22;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox23.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox24.Location = new System.Drawing.Point(182, 78);
            this.textBox24.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox24.MaxLength = 1;
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(35, 35);
            this.textBox24.TabIndex = 23;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox24.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.White;
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox25.Location = new System.Drawing.Point(217, 78);
            this.textBox25.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox25.MaxLength = 1;
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(35, 35);
            this.textBox25.TabIndex = 24;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.White;
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox26.Location = new System.Drawing.Point(252, 78);
            this.textBox26.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox26.MaxLength = 1;
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(35, 35);
            this.textBox26.TabIndex = 25;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox26.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.White;
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox27.Location = new System.Drawing.Point(287, 78);
            this.textBox27.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox27.MaxLength = 1;
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(35, 35);
            this.textBox27.TabIndex = 26;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox27.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox28.Location = new System.Drawing.Point(7, 113);
            this.textBox28.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox28.MaxLength = 1;
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(35, 35);
            this.textBox28.TabIndex = 27;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox28.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox29.Location = new System.Drawing.Point(42, 113);
            this.textBox29.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox29.MaxLength = 1;
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(35, 35);
            this.textBox29.TabIndex = 28;
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox29.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox30.Location = new System.Drawing.Point(77, 113);
            this.textBox30.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox30.MaxLength = 1;
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(35, 35);
            this.textBox30.TabIndex = 29;
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox30.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.Color.White;
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox31.Location = new System.Drawing.Point(112, 113);
            this.textBox31.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox31.MaxLength = 1;
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(35, 35);
            this.textBox31.TabIndex = 30;
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox31.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.Color.White;
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox32.Location = new System.Drawing.Point(147, 113);
            this.textBox32.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox32.MaxLength = 1;
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(35, 35);
            this.textBox32.TabIndex = 31;
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.Color.White;
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox33.Location = new System.Drawing.Point(182, 113);
            this.textBox33.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox33.MaxLength = 1;
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(35, 35);
            this.textBox33.TabIndex = 32;
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox33.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox34.Location = new System.Drawing.Point(217, 113);
            this.textBox34.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox34.MaxLength = 1;
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(35, 35);
            this.textBox34.TabIndex = 33;
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox34.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox35.Location = new System.Drawing.Point(252, 113);
            this.textBox35.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox35.MaxLength = 1;
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(35, 35);
            this.textBox35.TabIndex = 34;
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox35.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox36
            // 
            this.textBox36.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox36.Location = new System.Drawing.Point(287, 113);
            this.textBox36.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox36.MaxLength = 1;
            this.textBox36.Multiline = true;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(35, 35);
            this.textBox36.TabIndex = 35;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox36.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox37
            // 
            this.textBox37.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox37.Location = new System.Drawing.Point(7, 148);
            this.textBox37.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox37.MaxLength = 1;
            this.textBox37.Multiline = true;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(35, 35);
            this.textBox37.TabIndex = 36;
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox37.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox38.Location = new System.Drawing.Point(42, 148);
            this.textBox38.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox38.MaxLength = 1;
            this.textBox38.Multiline = true;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(35, 35);
            this.textBox38.TabIndex = 37;
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox38.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox39
            // 
            this.textBox39.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox39.Location = new System.Drawing.Point(77, 148);
            this.textBox39.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox39.MaxLength = 1;
            this.textBox39.Multiline = true;
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(35, 35);
            this.textBox39.TabIndex = 38;
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox39.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox40
            // 
            this.textBox40.BackColor = System.Drawing.Color.White;
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox40.Location = new System.Drawing.Point(112, 148);
            this.textBox40.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox40.MaxLength = 1;
            this.textBox40.Multiline = true;
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(35, 35);
            this.textBox40.TabIndex = 39;
            this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox40.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox41
            // 
            this.textBox41.BackColor = System.Drawing.Color.White;
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox41.Location = new System.Drawing.Point(147, 148);
            this.textBox41.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox41.MaxLength = 1;
            this.textBox41.Multiline = true;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(35, 35);
            this.textBox41.TabIndex = 40;
            this.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox41.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox42
            // 
            this.textBox42.BackColor = System.Drawing.Color.White;
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox42.Location = new System.Drawing.Point(182, 148);
            this.textBox42.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox42.MaxLength = 1;
            this.textBox42.Multiline = true;
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(35, 35);
            this.textBox42.TabIndex = 41;
            this.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox42.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox43
            // 
            this.textBox43.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox43.Location = new System.Drawing.Point(217, 148);
            this.textBox43.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox43.MaxLength = 1;
            this.textBox43.Multiline = true;
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(35, 35);
            this.textBox43.TabIndex = 42;
            this.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox43.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox44.Location = new System.Drawing.Point(252, 148);
            this.textBox44.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox44.MaxLength = 1;
            this.textBox44.Multiline = true;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(35, 35);
            this.textBox44.TabIndex = 43;
            this.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox44.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox45
            // 
            this.textBox45.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox45.Location = new System.Drawing.Point(287, 148);
            this.textBox45.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox45.MaxLength = 1;
            this.textBox45.Multiline = true;
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(35, 35);
            this.textBox45.TabIndex = 44;
            this.textBox45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox45.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox46
            // 
            this.textBox46.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox46.Location = new System.Drawing.Point(7, 183);
            this.textBox46.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox46.MaxLength = 1;
            this.textBox46.Multiline = true;
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(35, 35);
            this.textBox46.TabIndex = 45;
            this.textBox46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox46.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox47
            // 
            this.textBox47.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox47.Location = new System.Drawing.Point(42, 183);
            this.textBox47.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox47.MaxLength = 1;
            this.textBox47.Multiline = true;
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(35, 35);
            this.textBox47.TabIndex = 46;
            this.textBox47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox47.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox48
            // 
            this.textBox48.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox48.Location = new System.Drawing.Point(77, 183);
            this.textBox48.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox48.MaxLength = 1;
            this.textBox48.Multiline = true;
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(35, 35);
            this.textBox48.TabIndex = 47;
            this.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox48.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox49
            // 
            this.textBox49.BackColor = System.Drawing.Color.White;
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox49.Location = new System.Drawing.Point(112, 183);
            this.textBox49.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox49.MaxLength = 1;
            this.textBox49.Multiline = true;
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(35, 35);
            this.textBox49.TabIndex = 48;
            this.textBox49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox49.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox50
            // 
            this.textBox50.BackColor = System.Drawing.Color.White;
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox50.Location = new System.Drawing.Point(147, 183);
            this.textBox50.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox50.MaxLength = 1;
            this.textBox50.Multiline = true;
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(35, 35);
            this.textBox50.TabIndex = 49;
            this.textBox50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox50.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox51
            // 
            this.textBox51.BackColor = System.Drawing.Color.White;
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox51.Location = new System.Drawing.Point(182, 183);
            this.textBox51.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox51.MaxLength = 1;
            this.textBox51.Multiline = true;
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(35, 35);
            this.textBox51.TabIndex = 50;
            this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox51.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox52
            // 
            this.textBox52.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox52.Location = new System.Drawing.Point(217, 183);
            this.textBox52.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox52.MaxLength = 1;
            this.textBox52.Multiline = true;
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(35, 35);
            this.textBox52.TabIndex = 51;
            this.textBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox52.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox53
            // 
            this.textBox53.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox53.Location = new System.Drawing.Point(252, 183);
            this.textBox53.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox53.MaxLength = 1;
            this.textBox53.Multiline = true;
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(35, 35);
            this.textBox53.TabIndex = 52;
            this.textBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox53.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox54
            // 
            this.textBox54.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox54.Location = new System.Drawing.Point(287, 183);
            this.textBox54.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox54.MaxLength = 1;
            this.textBox54.Multiline = true;
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(35, 35);
            this.textBox54.TabIndex = 53;
            this.textBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox54.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox55
            // 
            this.textBox55.BackColor = System.Drawing.Color.White;
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox55.Location = new System.Drawing.Point(7, 218);
            this.textBox55.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox55.MaxLength = 1;
            this.textBox55.Multiline = true;
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(35, 35);
            this.textBox55.TabIndex = 54;
            this.textBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox55.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox56
            // 
            this.textBox56.BackColor = System.Drawing.Color.White;
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox56.Location = new System.Drawing.Point(42, 218);
            this.textBox56.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox56.MaxLength = 1;
            this.textBox56.Multiline = true;
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(35, 35);
            this.textBox56.TabIndex = 55;
            this.textBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox56.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox57
            // 
            this.textBox57.BackColor = System.Drawing.Color.White;
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox57.Location = new System.Drawing.Point(77, 218);
            this.textBox57.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox57.MaxLength = 1;
            this.textBox57.Multiline = true;
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(35, 35);
            this.textBox57.TabIndex = 56;
            this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox57.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox58
            // 
            this.textBox58.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox58.Location = new System.Drawing.Point(112, 218);
            this.textBox58.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox58.MaxLength = 1;
            this.textBox58.Multiline = true;
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(35, 35);
            this.textBox58.TabIndex = 57;
            this.textBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox58.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox59
            // 
            this.textBox59.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox59.Location = new System.Drawing.Point(147, 218);
            this.textBox59.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox59.MaxLength = 1;
            this.textBox59.Multiline = true;
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(35, 35);
            this.textBox59.TabIndex = 58;
            this.textBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox59.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox60
            // 
            this.textBox60.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox60.Location = new System.Drawing.Point(182, 218);
            this.textBox60.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox60.MaxLength = 1;
            this.textBox60.Multiline = true;
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(35, 35);
            this.textBox60.TabIndex = 59;
            this.textBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox60.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox61
            // 
            this.textBox61.BackColor = System.Drawing.Color.White;
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox61.Location = new System.Drawing.Point(217, 218);
            this.textBox61.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox61.MaxLength = 1;
            this.textBox61.Multiline = true;
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(35, 35);
            this.textBox61.TabIndex = 60;
            this.textBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox61.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox62
            // 
            this.textBox62.BackColor = System.Drawing.Color.White;
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox62.Location = new System.Drawing.Point(252, 218);
            this.textBox62.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox62.MaxLength = 1;
            this.textBox62.Multiline = true;
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(35, 35);
            this.textBox62.TabIndex = 61;
            this.textBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox62.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox63
            // 
            this.textBox63.BackColor = System.Drawing.Color.White;
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox63.Location = new System.Drawing.Point(287, 218);
            this.textBox63.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox63.MaxLength = 1;
            this.textBox63.Multiline = true;
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(35, 35);
            this.textBox63.TabIndex = 62;
            this.textBox63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox63.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox64
            // 
            this.textBox64.BackColor = System.Drawing.Color.White;
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox64.Location = new System.Drawing.Point(7, 253);
            this.textBox64.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox64.MaxLength = 1;
            this.textBox64.Multiline = true;
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(35, 35);
            this.textBox64.TabIndex = 63;
            this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox64.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox65
            // 
            this.textBox65.BackColor = System.Drawing.Color.White;
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox65.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox65.Location = new System.Drawing.Point(42, 253);
            this.textBox65.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox65.MaxLength = 1;
            this.textBox65.Multiline = true;
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(35, 35);
            this.textBox65.TabIndex = 64;
            this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox65.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.Color.White;
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox66.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox66.Location = new System.Drawing.Point(77, 253);
            this.textBox66.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox66.MaxLength = 1;
            this.textBox66.Multiline = true;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(35, 35);
            this.textBox66.TabIndex = 65;
            this.textBox66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox66.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox67
            // 
            this.textBox67.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox67.Location = new System.Drawing.Point(112, 253);
            this.textBox67.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox67.MaxLength = 1;
            this.textBox67.Multiline = true;
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(35, 35);
            this.textBox67.TabIndex = 66;
            this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox67.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox68
            // 
            this.textBox68.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox68.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox68.Location = new System.Drawing.Point(147, 253);
            this.textBox68.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox68.MaxLength = 1;
            this.textBox68.Multiline = true;
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(35, 35);
            this.textBox68.TabIndex = 67;
            this.textBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox68.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox69
            // 
            this.textBox69.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox69.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox69.Location = new System.Drawing.Point(182, 253);
            this.textBox69.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox69.MaxLength = 1;
            this.textBox69.Multiline = true;
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(35, 35);
            this.textBox69.TabIndex = 68;
            this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox69.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox70
            // 
            this.textBox70.BackColor = System.Drawing.Color.White;
            this.textBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox70.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox70.Location = new System.Drawing.Point(217, 253);
            this.textBox70.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox70.MaxLength = 1;
            this.textBox70.Multiline = true;
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(35, 35);
            this.textBox70.TabIndex = 69;
            this.textBox70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox70.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox71
            // 
            this.textBox71.BackColor = System.Drawing.Color.White;
            this.textBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox71.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox71.Location = new System.Drawing.Point(252, 253);
            this.textBox71.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox71.MaxLength = 1;
            this.textBox71.Multiline = true;
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(35, 35);
            this.textBox71.TabIndex = 70;
            this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox71.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox72
            // 
            this.textBox72.BackColor = System.Drawing.Color.White;
            this.textBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox72.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox72.Location = new System.Drawing.Point(287, 253);
            this.textBox72.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox72.MaxLength = 1;
            this.textBox72.Multiline = true;
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(35, 35);
            this.textBox72.TabIndex = 71;
            this.textBox72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox72.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox73
            // 
            this.textBox73.BackColor = System.Drawing.Color.White;
            this.textBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox73.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox73.Location = new System.Drawing.Point(7, 288);
            this.textBox73.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox73.MaxLength = 1;
            this.textBox73.Multiline = true;
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(35, 35);
            this.textBox73.TabIndex = 72;
            this.textBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox73.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox74
            // 
            this.textBox74.BackColor = System.Drawing.Color.White;
            this.textBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox74.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox74.Location = new System.Drawing.Point(42, 288);
            this.textBox74.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox74.MaxLength = 1;
            this.textBox74.Multiline = true;
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(35, 35);
            this.textBox74.TabIndex = 73;
            this.textBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox74.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox75
            // 
            this.textBox75.BackColor = System.Drawing.Color.White;
            this.textBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox75.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox75.Location = new System.Drawing.Point(77, 288);
            this.textBox75.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox75.MaxLength = 1;
            this.textBox75.Multiline = true;
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(35, 35);
            this.textBox75.TabIndex = 74;
            this.textBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox75.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox76
            // 
            this.textBox76.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox76.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox76.Location = new System.Drawing.Point(112, 288);
            this.textBox76.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox76.MaxLength = 1;
            this.textBox76.Multiline = true;
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(35, 35);
            this.textBox76.TabIndex = 75;
            this.textBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox76.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox77
            // 
            this.textBox77.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox77.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox77.Location = new System.Drawing.Point(147, 288);
            this.textBox77.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox77.MaxLength = 1;
            this.textBox77.Multiline = true;
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(35, 35);
            this.textBox77.TabIndex = 76;
            this.textBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox77.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox78
            // 
            this.textBox78.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox78.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox78.Location = new System.Drawing.Point(182, 288);
            this.textBox78.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox78.MaxLength = 1;
            this.textBox78.Multiline = true;
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(35, 35);
            this.textBox78.TabIndex = 77;
            this.textBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox78.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox79
            // 
            this.textBox79.BackColor = System.Drawing.Color.White;
            this.textBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox79.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox79.Location = new System.Drawing.Point(217, 288);
            this.textBox79.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox79.MaxLength = 1;
            this.textBox79.Multiline = true;
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(35, 35);
            this.textBox79.TabIndex = 78;
            this.textBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox79.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox80
            // 
            this.textBox80.BackColor = System.Drawing.Color.White;
            this.textBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox80.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox80.Location = new System.Drawing.Point(252, 288);
            this.textBox80.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox80.MaxLength = 1;
            this.textBox80.Multiline = true;
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(35, 35);
            this.textBox80.TabIndex = 79;
            this.textBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox80.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox81
            // 
            this.textBox81.BackColor = System.Drawing.Color.White;
            this.textBox81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox81.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox81.Location = new System.Drawing.Point(287, 288);
            this.textBox81.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox81.MaxLength = 1;
            this.textBox81.Multiline = true;
            this.textBox81.Name = "textBox81";
            this.textBox81.Size = new System.Drawing.Size(35, 35);
            this.textBox81.TabIndex = 80;
            this.textBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox81.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox71);
            this.panel1.Controls.Add(this.textBox81);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox72);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox63);
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.textBox54);
            this.panel1.Controls.Add(this.textBox28);
            this.panel1.Controls.Add(this.textBox45);
            this.panel1.Controls.Add(this.textBox37);
            this.panel1.Controls.Add(this.textBox36);
            this.panel1.Controls.Add(this.textBox46);
            this.panel1.Controls.Add(this.textBox27);
            this.panel1.Controls.Add(this.textBox55);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.textBox64);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox73);
            this.panel1.Controls.Add(this.textBox80);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox62);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.textBox53);
            this.panel1.Controls.Add(this.textBox29);
            this.panel1.Controls.Add(this.textBox44);
            this.panel1.Controls.Add(this.textBox38);
            this.panel1.Controls.Add(this.textBox35);
            this.panel1.Controls.Add(this.textBox47);
            this.panel1.Controls.Add(this.textBox26);
            this.panel1.Controls.Add(this.textBox56);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.textBox65);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox74);
            this.panel1.Controls.Add(this.textBox79);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox70);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox61);
            this.panel1.Controls.Add(this.textBox21);
            this.panel1.Controls.Add(this.textBox52);
            this.panel1.Controls.Add(this.textBox30);
            this.panel1.Controls.Add(this.textBox43);
            this.panel1.Controls.Add(this.textBox39);
            this.panel1.Controls.Add(this.textBox34);
            this.panel1.Controls.Add(this.textBox48);
            this.panel1.Controls.Add(this.textBox25);
            this.panel1.Controls.Add(this.textBox57);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox66);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox75);
            this.panel1.Controls.Add(this.textBox78);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox69);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox60);
            this.panel1.Controls.Add(this.textBox22);
            this.panel1.Controls.Add(this.textBox51);
            this.panel1.Controls.Add(this.textBox31);
            this.panel1.Controls.Add(this.textBox42);
            this.panel1.Controls.Add(this.textBox40);
            this.panel1.Controls.Add(this.textBox33);
            this.panel1.Controls.Add(this.textBox49);
            this.panel1.Controls.Add(this.textBox24);
            this.panel1.Controls.Add(this.textBox58);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.textBox67);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox76);
            this.panel1.Controls.Add(this.textBox77);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox68);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox59);
            this.panel1.Controls.Add(this.textBox23);
            this.panel1.Controls.Add(this.textBox50);
            this.panel1.Controls.Add(this.textBox32);
            this.panel1.Controls.Add(this.textBox41);
            this.panel1.Location = new System.Drawing.Point(33, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 331);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(119, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(154, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(189, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(224, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(259, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(294, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(329, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(12, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(12, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(12, 116);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(12, 151);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "D";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(12, 186);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "E";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(12, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "F";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(12, 256);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "G";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(12, 291);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 19);
            this.label17.TabIndex = 2;
            this.label17.Text = "H";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(12, 326);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "I";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "SudokuPage";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SudokuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SudokuPanel";
            this.Size = new System.Drawing.Size(369, 367);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
