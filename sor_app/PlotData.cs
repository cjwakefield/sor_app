using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sor_app
{
    class PlotData
    {
        private string title;
        private string fileName;
        private int col1;
        private int col2;
        private string with;
        private string where;

        public string Where { get => where; set => where = value; }
        public string With { get => with; set => with = value; }
        public int Col2 { get => col2; set => col2 = value; }
        public int Col1 { get => col1; set => col1 = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string Title { get => title; set => title = value; }

        public PlotData(string title , string fileName, int col1, int col2, string with, string where)
        {
            this.title = title;
            this.fileName = fileName;
            this.col1 = col1;
            this.col2 = col2;
            this.with = with;
            this.where = where;

        }
        public override string ToString()
        {
            return title; 
        }
        public string Function()
        {
            return fileName + " using [" +col1 +":" + col2 + "] w" +with + " wh " + where + " title \"" + title + "\"";
        }


    }
    
}
