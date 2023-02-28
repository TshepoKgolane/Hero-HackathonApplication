using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ModuleMethods
    {
        public double CalculateFinal(double asses1, double asses2, double asses3, double ice, int weight1, int weight2, int weight3, int iceWeigh)
        {
            double result = 100;
            double assessment1 = asses1 * weight1 / 100;
            double assessment2 = asses2 * weight2 / 100;
            double assessment3 = asses3 * weight3 / 100;
            double assessment4 = ice * iceWeigh / 100;
            result = assessment1 + assessment2 + assessment3 + assessment4;
            return result;
        }
    }
}
