namespace sor_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.uxlambda = new System.Windows.Forms.TextBox();
            this.uxkappa = new System.Windows.Forms.TextBox();
            this.uxmu = new System.Windows.Forms.TextBox();
            this.uxrealm = new System.Windows.Forms.TextBox();
            this.uxsigma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadedFiles = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.makeGraph = new System.Windows.Forms.Button();
            this.SizeDistPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MakeData = new System.Windows.Forms.TabPage();
            this.Plot = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.FormatY = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.FormatX = new System.Windows.Forms.TextBox();
            this.YRangeStop = new System.Windows.Forms.TextBox();
            this.XRangeStop = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.YRangeStart = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.XRangeStart = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.yLable = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.xLable = new System.Windows.Forms.TextBox();
            this.removeGraph = new System.Windows.Forms.Button();
            this.overWrite = new System.Windows.Forms.Button();
            this.loadFileName = new System.Windows.Forms.Button();
            this.saveGraph = new System.Windows.Forms.Button();
            this.editGraph = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.where = new System.Windows.Forms.TextBox();
            this.with = new System.Windows.Forms.TextBox();
            this.col2 = new System.Windows.Forms.TextBox();
            this.col1 = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GnuCheckBoxSettings = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.SizeDistPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MakeData.SuspendLayout();
            this.Plot.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MakeDataClick_Click);
            // 
            // uxlambda
            // 
            this.uxlambda.Location = new System.Drawing.Point(119, 10);
            this.uxlambda.Name = "uxlambda";
            this.uxlambda.Size = new System.Drawing.Size(100, 20);
            this.uxlambda.TabIndex = 1;
            // 
            // uxkappa
            // 
            this.uxkappa.Location = new System.Drawing.Point(119, 88);
            this.uxkappa.Name = "uxkappa";
            this.uxkappa.Size = new System.Drawing.Size(100, 20);
            this.uxkappa.TabIndex = 2;
            // 
            // uxmu
            // 
            this.uxmu.Location = new System.Drawing.Point(119, 114);
            this.uxmu.Name = "uxmu";
            this.uxmu.Size = new System.Drawing.Size(100, 20);
            this.uxmu.TabIndex = 3;
            // 
            // uxrealm
            // 
            this.uxrealm.Location = new System.Drawing.Point(119, 62);
            this.uxrealm.Name = "uxrealm";
            this.uxrealm.Size = new System.Drawing.Size(100, 20);
            this.uxrealm.TabIndex = 4;
            // 
            // uxsigma
            // 
            this.uxsigma.Location = new System.Drawing.Point(119, 36);
            this.uxsigma.Name = "uxsigma";
            this.uxsigma.Size = new System.Drawing.Size(100, 20);
            this.uxsigma.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lambda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sigma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "RI real";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "RI imaginary ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mean size";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // loadedFiles
            // 
            this.loadedFiles.FormattingEnabled = true;
            this.loadedFiles.Location = new System.Drawing.Point(623, 34);
            this.loadedFiles.Name = "loadedFiles";
            this.loadedFiles.Size = new System.Drawing.Size(320, 186);
            this.loadedFiles.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loaded Files";
            // 
            // makeGraph
            // 
            this.makeGraph.Location = new System.Drawing.Point(464, 239);
            this.makeGraph.Name = "makeGraph";
            this.makeGraph.Size = new System.Drawing.Size(75, 23);
            this.makeGraph.TabIndex = 15;
            this.makeGraph.Text = "MakeGraph";
            this.makeGraph.UseVisualStyleBackColor = true;
            this.makeGraph.Click += new System.EventHandler(this.MakeGraph_Click);
            // 
            // SizeDistPanel
            // 
            this.SizeDistPanel.Controls.Add(this.label1);
            this.SizeDistPanel.Controls.Add(this.button1);
            this.SizeDistPanel.Controls.Add(this.uxlambda);
            this.SizeDistPanel.Controls.Add(this.uxkappa);
            this.SizeDistPanel.Controls.Add(this.uxmu);
            this.SizeDistPanel.Controls.Add(this.label5);
            this.SizeDistPanel.Controls.Add(this.uxrealm);
            this.SizeDistPanel.Controls.Add(this.label4);
            this.SizeDistPanel.Controls.Add(this.uxsigma);
            this.SizeDistPanel.Controls.Add(this.label3);
            this.SizeDistPanel.Controls.Add(this.label2);
            this.SizeDistPanel.Location = new System.Drawing.Point(17, 34);
            this.SizeDistPanel.Name = "SizeDistPanel";
            this.SizeDistPanel.Size = new System.Drawing.Size(253, 175);
            this.SizeDistPanel.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MakeData);
            this.tabControl1.Controls.Add(this.Plot);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 301);
            this.tabControl1.TabIndex = 17;
            // 
            // MakeData
            // 
            this.MakeData.Controls.Add(this.SizeDistPanel);
            this.MakeData.Location = new System.Drawing.Point(4, 22);
            this.MakeData.Name = "MakeData";
            this.MakeData.Padding = new System.Windows.Forms.Padding(3);
            this.MakeData.Size = new System.Drawing.Size(954, 275);
            this.MakeData.TabIndex = 0;
            this.MakeData.Text = "Make Data";
            this.MakeData.UseVisualStyleBackColor = true;
            // 
            // Plot
            // 
            this.Plot.Controls.Add(this.label20);
            this.Plot.Controls.Add(this.Key);
            this.Plot.Controls.Add(this.label18);
            this.Plot.Controls.Add(this.FormatY);
            this.Plot.Controls.Add(this.label19);
            this.Plot.Controls.Add(this.FormatX);
            this.Plot.Controls.Add(this.YRangeStop);
            this.Plot.Controls.Add(this.XRangeStop);
            this.Plot.Controls.Add(this.label17);
            this.Plot.Controls.Add(this.YRangeStart);
            this.Plot.Controls.Add(this.label16);
            this.Plot.Controls.Add(this.XRangeStart);
            this.Plot.Controls.Add(this.label15);
            this.Plot.Controls.Add(this.yLable);
            this.Plot.Controls.Add(this.label14);
            this.Plot.Controls.Add(this.xLable);
            this.Plot.Controls.Add(this.removeGraph);
            this.Plot.Controls.Add(this.overWrite);
            this.Plot.Controls.Add(this.loadFileName);
            this.Plot.Controls.Add(this.saveGraph);
            this.Plot.Controls.Add(this.editGraph);
            this.Plot.Controls.Add(this.label13);
            this.Plot.Controls.Add(this.label12);
            this.Plot.Controls.Add(this.label11);
            this.Plot.Controls.Add(this.label10);
            this.Plot.Controls.Add(this.label8);
            this.Plot.Controls.Add(this.label7);
            this.Plot.Controls.Add(this.where);
            this.Plot.Controls.Add(this.with);
            this.Plot.Controls.Add(this.col2);
            this.Plot.Controls.Add(this.col1);
            this.Plot.Controls.Add(this.fileName);
            this.Plot.Controls.Add(this.title);
            this.Plot.Controls.Add(this.label9);
            this.Plot.Controls.Add(this.GnuCheckBoxSettings);
            this.Plot.Controls.Add(this.label6);
            this.Plot.Controls.Add(this.makeGraph);
            this.Plot.Controls.Add(this.loadedFiles);
            this.Plot.Location = new System.Drawing.Point(4, 22);
            this.Plot.Name = "Plot";
            this.Plot.Padding = new System.Windows.Forms.Padding(3);
            this.Plot.Size = new System.Drawing.Size(954, 275);
            this.Plot.TabIndex = 1;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(134, 181);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Key";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(196, 181);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(100, 20);
            this.Key.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(134, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Format Y";
            // 
            // FormatY
            // 
            this.FormatY.Location = new System.Drawing.Point(196, 155);
            this.FormatY.Name = "FormatY";
            this.FormatY.Size = new System.Drawing.Size(100, 20);
            this.FormatY.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(134, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Format X";
            // 
            // FormatX
            // 
            this.FormatX.Location = new System.Drawing.Point(196, 129);
            this.FormatX.Name = "FormatX";
            this.FormatX.Size = new System.Drawing.Size(100, 20);
            this.FormatX.TabIndex = 49;
            // 
            // YRangeStop
            // 
            this.YRangeStop.Location = new System.Drawing.Point(247, 103);
            this.YRangeStop.Name = "YRangeStop";
            this.YRangeStop.Size = new System.Drawing.Size(49, 20);
            this.YRangeStop.TabIndex = 48;
            // 
            // XRangeStop
            // 
            this.XRangeStop.Location = new System.Drawing.Point(247, 77);
            this.XRangeStop.Name = "XRangeStop";
            this.XRangeStop.Size = new System.Drawing.Size(49, 20);
            this.XRangeStop.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(134, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Y  Range";
            // 
            // YRangeStart
            // 
            this.YRangeStart.Location = new System.Drawing.Point(196, 103);
            this.YRangeStart.Name = "YRangeStart";
            this.YRangeStart.Size = new System.Drawing.Size(45, 20);
            this.YRangeStart.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(134, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "X Range";
            // 
            // XRangeStart
            // 
            this.XRangeStart.Location = new System.Drawing.Point(196, 77);
            this.XRangeStart.Name = "XRangeStart";
            this.XRangeStart.Size = new System.Drawing.Size(45, 20);
            this.XRangeStart.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(134, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Y Lable";
            // 
            // yLable
            // 
            this.yLable.Location = new System.Drawing.Point(196, 51);
            this.yLable.Name = "yLable";
            this.yLable.Size = new System.Drawing.Size(100, 20);
            this.yLable.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "X Lable";
            // 
            // xLable
            // 
            this.xLable.Location = new System.Drawing.Point(196, 25);
            this.xLable.Name = "xLable";
            this.xLable.Size = new System.Drawing.Size(100, 20);
            this.xLable.TabIndex = 39;
            // 
            // removeGraph
            // 
            this.removeGraph.Location = new System.Drawing.Point(789, 238);
            this.removeGraph.Name = "removeGraph";
            this.removeGraph.Size = new System.Drawing.Size(88, 23);
            this.removeGraph.TabIndex = 38;
            this.removeGraph.Text = "RemoveGraph";
            this.removeGraph.UseVisualStyleBackColor = true;
            this.removeGraph.Click += new System.EventHandler(this.removeGraph_Click);
            // 
            // overWrite
            // 
            this.overWrite.Location = new System.Drawing.Point(707, 239);
            this.overWrite.Name = "overWrite";
            this.overWrite.Size = new System.Drawing.Size(75, 23);
            this.overWrite.TabIndex = 37;
            this.overWrite.Text = "OverWrite";
            this.overWrite.UseVisualStyleBackColor = true;
            this.overWrite.Click += new System.EventHandler(this.overWrite_Click);
            // 
            // loadFileName
            // 
            this.loadFileName.Location = new System.Drawing.Point(358, 56);
            this.loadFileName.Name = "loadFileName";
            this.loadFileName.Size = new System.Drawing.Size(97, 20);
            this.loadFileName.TabIndex = 36;
            this.loadFileName.Text = "LoadFilePath";
            this.loadFileName.UseVisualStyleBackColor = true;
            this.loadFileName.Click += new System.EventHandler(this.loadFileName_Click);
            // 
            // saveGraph
            // 
            this.saveGraph.Location = new System.Drawing.Point(626, 239);
            this.saveGraph.Name = "saveGraph";
            this.saveGraph.Size = new System.Drawing.Size(75, 23);
            this.saveGraph.TabIndex = 35;
            this.saveGraph.Text = "SaveGraph";
            this.saveGraph.UseVisualStyleBackColor = true;
            this.saveGraph.Click += new System.EventHandler(this.saveGraph_Click);
            // 
            // editGraph
            // 
            this.editGraph.Location = new System.Drawing.Point(545, 239);
            this.editGraph.Name = "editGraph";
            this.editGraph.Size = new System.Drawing.Size(75, 23);
            this.editGraph.TabIndex = 34;
            this.editGraph.Text = "EditGraph";
            this.editGraph.UseVisualStyleBackColor = true;
            this.editGraph.Click += new System.EventHandler(this.editGraph_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(461, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Where";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "With";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Col 2 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Col 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(461, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "FilePath";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Graph Title";
            // 
            // where
            // 
            this.where.Location = new System.Drawing.Point(517, 164);
            this.where.Name = "where";
            this.where.Size = new System.Drawing.Size(100, 20);
            this.where.TabIndex = 27;
            // 
            // with
            // 
            this.with.Location = new System.Drawing.Point(517, 138);
            this.with.Name = "with";
            this.with.Size = new System.Drawing.Size(100, 20);
            this.with.TabIndex = 26;
            // 
            // col2
            // 
            this.col2.Location = new System.Drawing.Point(517, 112);
            this.col2.Name = "col2";
            this.col2.Size = new System.Drawing.Size(100, 20);
            this.col2.TabIndex = 25;
            // 
            // col1
            // 
            this.col1.Location = new System.Drawing.Point(517, 86);
            this.col1.Name = "col1";
            this.col1.Size = new System.Drawing.Size(100, 20);
            this.col1.TabIndex = 24;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(517, 60);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 20);
            this.fileName.TabIndex = 23;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(517, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Graph Settings";
            // 
            // GnuCheckBoxSettings
            // 
            this.GnuCheckBoxSettings.CheckOnClick = true;
            this.GnuCheckBoxSettings.FormattingEnabled = true;
            this.GnuCheckBoxSettings.Location = new System.Drawing.Point(8, 34);
            this.GnuCheckBoxSettings.Name = "GnuCheckBoxSettings";
            this.GnuCheckBoxSettings.Size = new System.Drawing.Size(120, 199);
            this.GnuCheckBoxSettings.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 338);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "sor_app";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SizeDistPanel.ResumeLayout(false);
            this.SizeDistPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MakeData.ResumeLayout(false);
            this.Plot.ResumeLayout(false);
            this.Plot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uxlambda;
        private System.Windows.Forms.TextBox uxkappa;
        private System.Windows.Forms.TextBox uxmu;
        private System.Windows.Forms.TextBox uxrealm;
        private System.Windows.Forms.TextBox uxsigma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ListBox loadedFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button makeGraph;
        private System.Windows.Forms.Panel SizeDistPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MakeData;
        private System.Windows.Forms.TabPage Plot;
        private System.Windows.Forms.CheckedListBox GnuCheckBoxSettings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox with;
        private System.Windows.Forms.TextBox col2;
        private System.Windows.Forms.TextBox col1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox where;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editGraph;
        private System.Windows.Forms.Button saveGraph;
        private System.Windows.Forms.Button loadFileName;
        private System.Windows.Forms.Button overWrite;
        private System.Windows.Forms.Button removeGraph;
        private System.Windows.Forms.TextBox YRangeStop;
        private System.Windows.Forms.TextBox XRangeStop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox YRangeStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox XRangeStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox yLable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox xLable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FormatY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox FormatX;
    }
}

