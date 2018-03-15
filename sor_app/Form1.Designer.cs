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
            this.button2 = new System.Windows.Forms.Button();
            this.SizeDistPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MakeData = new System.Windows.Forms.TabPage();
            this.Plot = new System.Windows.Forms.TabPage();
            this.GnuCheckBoxSettings = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label6.Location = new System.Drawing.Point(745, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loaded Files";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "MakeGraph";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Plot.Controls.Add(this.label9);
            this.Plot.Controls.Add(this.GnuCheckBoxSettings);
            this.Plot.Controls.Add(this.label6);
            this.Plot.Controls.Add(this.button2);
            this.Plot.Controls.Add(this.loadedFiles);
            this.Plot.Location = new System.Drawing.Point(4, 22);
            this.Plot.Name = "Plot";
            this.Plot.Padding = new System.Windows.Forms.Padding(3);
            this.Plot.Size = new System.Drawing.Size(954, 275);
            this.Plot.TabIndex = 1;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = true;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "GraphSettinsg ";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SizeDistPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MakeData;
        private System.Windows.Forms.TabPage Plot;
        private System.Windows.Forms.CheckedListBox GnuCheckBoxSettings;
        private System.Windows.Forms.Label label9;
    }
}

