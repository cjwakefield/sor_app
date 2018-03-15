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
        List<string> fileNames = new List<string>();
        GnuHandler gh = new GnuHandler();
        List<Panel> Panels = new List<Panel>(); 

        public Form1()
        {
            InitializeComponent();
            GnuHandler.CheckListBox =  GnuSettingsInIt(); 
        }

        private void button1_Click(object sender, EventArgs e)
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

            fileNames.Add(openFile.FileName);

            loadedFiles.DataSource = null; 
            loadedFiles.DataSource = fileNames; 
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gh.FileNames = fileNames;

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


    }
}
