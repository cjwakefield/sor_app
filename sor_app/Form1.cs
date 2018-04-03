using AwokeKnowing.GnuplotCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sor_app
{
   
    public partial class Form1 : Form
    {
        List<PlotData> Plots = new List<PlotData>();
        GnuHandler gh = new GnuHandler();

        public Form1()
        {
            InitializeComponent();
            GnuHandler.CheckListBox =  GnuSettingsInIt(); 
        }

        private void MakeDataClick_Click(object sender, EventArgs e)
        {
            try
            {

                DataMaker Dm = new DataMaker(Convert.ToDouble(uxlambda.Text), Convert.ToDouble(uxsigma.Text), Convert.ToDouble(uxrealm.Text), Convert.ToDouble(uxkappa.Text), Convert.ToDouble(uxmu.Text)); ;
                Dm.createData();

            }catch(Exception)
            {
                MessageBox.Show("Data not input correctly");

            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();

            Plots.Add(new PlotData(title.Text , openFile.FileName , Convert.ToInt32(col1.Text) , Convert.ToInt32(col2.Text) , with.Text , where.Text));

            loadedFiles.DataSource = null; 
            loadedFiles.DataSource = Plots; 
           

        }

        private void MakeGraph_Click(object sender, EventArgs e)
        {
            gh.Plots = Plots;

            gh.graphPlot();
        }
        private CheckedListBox GnuSettingsInIt()
        {
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("multiplot" , "multiplot"));
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("logscale", "logscale"));
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("key invert", "key invert"));


            for (int x = 0; x < GnuSetting.GnuBoolSettingsList.Count; x++)
            {
                GnuCheckBoxSettings.Items.Add(GnuSetting.GnuBoolSettingsList[x]);
            }

            return GnuCheckBoxSettings; 
        }



        private void editGraph_Click(object sender, EventArgs e)
        {
            PlotData tmpPlot = (PlotData)loadedFiles.SelectedItems[0];

            title.Text = tmpPlot.Title;

            fileName.Text = tmpPlot.FileName;

            col1.Text = Convert.ToString(tmpPlot.Col1); 
                
            col2.Text = Convert.ToString(tmpPlot.Col2);

            with.Text = tmpPlot.With;
                
            where.Text = tmpPlot.Where;
        }

        private void saveGraph_Click(object sender, EventArgs e)
        {
            try
            {
            Plots.Add(new PlotData(title.Text, openFile.FileName, Convert.ToInt32(col1.Text), Convert.ToInt32(col2.Text), with.Text, where.Text));
            }catch(Exception)
            {
                MessageBox.Show("you need col numbers"); 

            }
            loadedFiles.DataSource = null;
            loadedFiles.DataSource = Plots; 

        }

        private void loadFileName_Click(object sender, EventArgs e)
        {
            openFile.FileName = ""; 
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFile.FileName; 

            }
        }

        private void overWrite_Click(object sender, EventArgs e)
        {

            Plots[loadedFiles.SelectedIndex] = new PlotData(title.Text, openFile.FileName, Convert.ToInt32(col1.Text), Convert.ToInt32(col2.Text), with.Text, where.Text);
            loadedFiles.DataSource = null;
            loadedFiles.DataSource = Plots;
        }
    }
}
