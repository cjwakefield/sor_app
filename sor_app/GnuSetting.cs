using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sor_app
{
    class GnuSetting
    {
        private String title;
        private String function;

        public static List<GnuSetting> GnuBoolSettingsList = new List<GnuSetting>();
        public static List<GnuSetting> GnuUserSettingsList = new List<GnuSetting>();

        public GnuSetting(String title , String function  )
        {
            this.title = title;
            this.function = function;

        }

        public string Title
        {
            get
            {
                return  title;
            }
            set
            {
                title = value; 
            }
        }

        public string Function
        {
            get
            {
                return function;
            }
            set
            {
                function = value;
            }
        }


        public override string ToString()
        {
            return title; 
        }

        public static void Remove(GnuSetting gs)
        {
            GnuBoolSettingsList.Remove(gs); 
        }

        public static void Add(GnuSetting gs)
        {
            GnuBoolSettingsList.Add(gs); 
        }

    }
}
