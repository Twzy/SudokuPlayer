namespace SudokuPlayer
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sudokuPanel1 = new SudokuCalcs.SudokuPanel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRandomLoad = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnGetString = new System.Windows.Forms.Button();
            this.btnCalcsStep = new System.Windows.Forms.Button();
            this.btnStartCalcs = new System.Windows.Forms.Button();
            this.btnCalcsAll = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(613, 224);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // sudokuPanel1
            // 
            this.sudokuPanel1.BackColor = System.Drawing.Color.White;
            this.sudokuPanel1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sudokuPanel1.Location = new System.Drawing.Point(25, 5);
            this.sudokuPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.sudokuPanel1.Name = "sudokuPanel1";
            this.sudokuPanel1.Size = new System.Drawing.Size(369, 367);
            this.sudokuPanel1.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(400, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 28);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "加  载";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnRandomLoad
            // 
            this.btnRandomLoad.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRandomLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomLoad.Location = new System.Drawing.Point(520, 47);
            this.btnRandomLoad.Name = "btnRandomLoad";
            this.btnRandomLoad.Size = new System.Drawing.Size(109, 28);
            this.btnRandomLoad.TabIndex = 11;
            this.btnRandomLoad.Text = "随  机";
            this.btnRandomLoad.UseVisualStyleBackColor = false;
            this.btnRandomLoad.Click += new System.EventHandler(this.btnLoadDataRandm_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(400, 155);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(109, 28);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "校  验";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnGetString
            // 
            this.btnGetString.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetString.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetString.Location = new System.Drawing.Point(520, 155);
            this.btnGetString.Name = "btnGetString";
            this.btnGetString.Size = new System.Drawing.Size(109, 28);
            this.btnGetString.TabIndex = 11;
            this.btnGetString.Text = "获  取";
            this.btnGetString.UseVisualStyleBackColor = false;
            this.btnGetString.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // btnCalcsStep
            // 
            this.btnCalcsStep.BackColor = System.Drawing.Color.Lime;
            this.btnCalcsStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcsStep.Location = new System.Drawing.Point(400, 320);
            this.btnCalcsStep.Name = "btnCalcsStep";
            this.btnCalcsStep.Size = new System.Drawing.Size(109, 28);
            this.btnCalcsStep.TabIndex = 11;
            this.btnCalcsStep.Text = "单  步";
            this.btnCalcsStep.UseVisualStyleBackColor = false;
            this.btnCalcsStep.Click += new System.EventHandler(this.calcsStep_Click);
            // 
            // btnStartCalcs
            // 
            this.btnStartCalcs.BackColor = System.Drawing.Color.Lime;
            this.btnStartCalcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCalcs.Location = new System.Drawing.Point(400, 275);
            this.btnStartCalcs.Name = "btnStartCalcs";
            this.btnStartCalcs.Size = new System.Drawing.Size(109, 28);
            this.btnStartCalcs.TabIndex = 11;
            this.btnStartCalcs.Text = "计  算";
            this.btnStartCalcs.UseVisualStyleBackColor = false;
            this.btnStartCalcs.Click += new System.EventHandler(this.calcsStart_Click);
            // 
            // btnCalcsAll
            // 
            this.btnCalcsAll.BackColor = System.Drawing.Color.Lime;
            this.btnCalcsAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcsAll.Location = new System.Drawing.Point(520, 320);
            this.btnCalcsAll.Name = "btnCalcsAll";
            this.btnCalcsAll.Size = new System.Drawing.Size(109, 28);
            this.btnCalcsAll.TabIndex = 11;
            this.btnCalcsAll.Text = "全  部";
            this.btnCalcsAll.UseVisualStyleBackColor = false;
            this.btnCalcsAll.Click += new System.EventHandler(this.calcsAll_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(600, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "打印";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(519, 101);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(109, 28);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "重新加载";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(14, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 226);
            this.panel1.TabIndex = 13;
            // 
            // btnInite
            // 
            this.btnInite.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInite.Location = new System.Drawing.Point(400, 47);
            this.btnInite.Name = "btnInite";
            this.btnInite.Size = new System.Drawing.Size(109, 28);
            this.btnInite.TabIndex = 11;
            this.btnInite.Text = "初始化";
            this.btnInite.UseVisualStyleBackColor = false;
            this.btnInite.Click += new System.EventHandler(this.btnInite_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCalcsAll);
            this.Controls.Add(this.btnGetString);
            this.Controls.Add(this.btnRandomLoad);
            this.Controls.Add(this.btnStartCalcs);
            this.Controls.Add(this.btnCalcsStep);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnInite);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.sudokuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SudokuPlayer--墨云软件";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SudokuCalcs.SudokuPanel sudokuPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRandomLoad;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnGetString;
        private System.Windows.Forms.Button btnCalcsStep;
        private System.Windows.Forms.Button btnStartCalcs;
        private System.Windows.Forms.Button btnCalcsAll;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInite;
    }
}

