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

        private void MakeGraph_Click(object sender, EventArgs e)
        {
            gh.Plots = Plots;
            LoadUsersSettings(); 
            gh.graphPlot();
        }
        private CheckedListBox GnuSettingsInIt()
        {
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("logscale", "logscale"));
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("key invert", "key invert"));
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("parametric", "parametric"));
            GnuSetting.GnuBoolSettingsList.Add(new GnuSetting("polar", "polar"));


            for (int x = 0; x < GnuSetting.GnuBoolSettingsList.Count; x++)
            {
                GnuCheckBoxSettings.Items.Add(GnuSetting.GnuBoolSettingsList[x]);
            }

            return GnuCheckBoxSettings; 
        }



        /*private void editGraph_Click(object sender, EventArgs e)
        {
            PlotData tmpPlot = (PlotData)loadedFiles.SelectedItems[0];

            title.Text = tmpPlot.Title;

            fileName.Text = tmpPlot.FileName;

            col1.Text = Convert.ToString(tmpPlot.Col1); 
                
            col2.Text = Convert.ToString(tmpPlot.Col2);

            with.Text = tmpPlot.With;
                
            where.Text = tmpPlot.Where;
             
            colorDialog1.Color = (Color)System.Drawing.ColorTranslator.FromHtml(tmpPlot.Color);

            color.BackColor = colorDialog1.Color;

            lineType.Text = tmpPlot.LineType; 



        }*/

        private void saveGraph_Click(object sender, EventArgs e)
        {
            try
            {
                string rgb =  (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6") + "\""; 
                Plots.Add(new PlotData(title.Text, openFile.FileName, Convert.ToInt32(col1.Text), Convert.ToInt32(col2.Text), with.Text, where.Text , rgb , lineType.Text));
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
            string rgb =  (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6") + "\"";
            try
            {
                Plots[loadedFiles.SelectedIndex] = new PlotData(title.Text, openFile.FileName, Convert.ToInt32(col1.Text), Convert.ToInt32(col2.Text), with.Text, where.Text, rgb, lineType.Text);
                loadedFiles.DataSource = null;
                loadedFiles.DataSource = Plots;
            }catch(Exception)
            {

            }
        }

        private void removeGraph_Click(object sender, EventArgs e)
        {
            try
            {
                Plots.RemoveAt(loadedFiles.SelectedIndex);
                loadedFiles.DataSource = null;
                loadedFiles.DataSource = Plots;
            }catch(Exception)
            {

            }
        }

        private void LoadUsersSettings()
        {
            GnuSetting.GnuUserSettingsList.Clear(); 
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("xlabel", "xlabel " +"\"" + xLable.Text+ "\""));
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("ylabel", "ylabel " + "\""+ yLable.Text+ "\""));
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("formatx", "format x " + "\""+FormatX.Text+ "\""));
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("formaty", "format y " + "\"" +FormatY.Text + "\""));
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("key", "key " + Key.Text));
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("xrange", "xrange[" + XRangeStart.Text + ":"+ XRangeStop.Text + "]"));
            GnuSetting.GnuUserSettingsList.Add(new GnuSetting("yrange", "yrange[" + YRangeStart.Text + ":" + YRangeStop.Text + "]"));

        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color.BackColor = colorDialog1.Color; 
            }

        }

        private void loadedFiles_DoubleClick(object sender, EventArgs e)
        {
            if (loadedFiles.SelectedItem != null)
            {
                PlotData pdtmp = (PlotData)loadedFiles.SelectedItem;
                MessageBox.Show(pdtmp.Function() + "\n" + pdtmp.FileName);
            }
        }
    }
}
