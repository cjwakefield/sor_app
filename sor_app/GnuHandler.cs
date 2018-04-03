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
        private List<PlotData> plots = new List<PlotData>();
        public static CheckedListBox CheckListBox ; 

        public GnuHandler()
        {

        }

        public GnuHandler(List<PlotData> plots)
        {
            this.plots = plots; 

        }

        public List<PlotData> Plots
        {
            get
            {
                return plots; 
            }
            set
            {
                plots = value; 
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

            for (int x = 0; x < GnuSetting.GnuUserSettingsList.Count; x++)
            {
                    GnuPlot.Set(GnuSetting.GnuUserSettingsList[x].Function);
            }

                /*GnuPlot.Set("xlabel \"qR\" font \", 20\"");
                GnuPlot.Set("ylabel \"Perpendicularly polarized\" font \",20\"");
                GnuPlot.Set("format y \"10^{%L}\"");
                GnuPlot.Set("format x \"10^{%L}\"");
                GnuPlot.Set("key bottom left");
                GnuPlot.Set("key font \",20\"");
                GnuPlot.Set("xrange[-10:100]");
                GnuPlot.Set("yrange[-10:10000]");*/
                //dash types 
                // format toa drop down 
                // color 
                //
                GnuPlot.HoldOn();

            for (int i = 0; i < plots.Count; i++)
            {
                //GnuPlot.Plot(plots[i].FileName, "using 2:3 w l lw 2 title \"m = 1.3 p'=14.5\"");
                GnuPlot.Plot(plots[i].FileName ,plots[i].Function());
            }

        }
    }
}
