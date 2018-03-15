using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sor_app
{
    class DataMaker
    {
        private double lambda, sigma, realm, kappa, mu;
        public DataMaker()
        {
            //.532 1.2 1.33 0 3
            lambda = .532;
            sigma = 1.2;
            realm = 1.33;
            kappa = 0;
            mu = 3;

        }
        public DataMaker(double lambda, double sigma, double realm, double kappa, double mu)
        {
            //.532 1.2 1.33 0 3
            this.lambda = lambda;
            this.sigma = sigma;
            this.realm = realm;
            this.kappa = kappa;
            this.mu = mu;

        }
        public void createData()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "DataMakerSor.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = " " + lambda + " " + sigma + " " + realm + " " + kappa + " " + mu;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch(Exception)
            {
                
            }
        }
    }
}
