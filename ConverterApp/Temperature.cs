using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    class Temperature
    {
        private double tempInput;

        public Temperature() { }
        public Temperature(double tempIn)
        {
            this.tempInput = tempIn;
        }

        public double TempInput
        {
            get { return tempInput; }
            set { tempInput = value; }
        }

        public double FahrToCel()
        {
            return ((tempInput - 32) * 5) / 9;
        }

        public double CelToFahr()
        {
            return (tempInput * 9 / 5) + 32;
        }
    }
}
