using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwokeKnowing.GnuplotCSharp;
using System.Windows.Forms;

namespace sor_app
{
    class GnuHandler
    {
        private List<string> fileNames = new List<string>();
        public static CheckedListBox CheckListBox ; 

        public GnuHandler()
        {

        }

        public GnuHandler(List<string> fileNames)
        {
            this.fileNames = fileNames; 

        }

        public List<string> FileNames
        {
            get
            {
                return fileNames; 
            }
            set
            {
                fileNames = value; 
            }
        }

        public void graphPlot()
        { 
            GnuPlot.Reset();

            for(int x = 0; x < GnuSetting.GnuBoolSettingsList.Count; x++)
            {
                if(CheckListBox.GetItemChecked(x))
                GnuPlot.Set(GnuSetting.GnuBoolSettingsList[x].Function);
            }

                //GnuPlot.Set("multiplot");
                GnuPlot.Set("xlabel \"qR\" font \", 20\"");
                GnuPlot.Set("ylabel \"Perpendicularly polarized\" font \",20\"");
                //GnuPlot.Set("logscale");
                GnuPlot.Set("format y \"10^{%L}\"");
                GnuPlot.Set("format x \"10^{% L}\"");
                GnuPlot.Set("key bottom left");
                GnuPlot.Set("key font \",20\"");
                GnuPlot.Set("xrange[-10:100]");
                GnuPlot.Set("yrange[-10:10000]");
                //GnuPlot.Set("key invert");
                GnuPlot.HoldOn();
            
            for (int i = 0; i < FileNames.Count; i++)
            {
                GnuPlot.Plot(FileNames[i], "using 2:3 w l lw 2 title \"m = 1.3 p'=14.5\"");
            }

        }
        public void MakePlotString()
        {

        }

    }
}
