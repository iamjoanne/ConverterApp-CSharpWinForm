using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    class Speed
    {
        private double speedInput;

        public Speed() { }
        public Speed(double speedIn)
        {
            this.speedInput = speedIn;
        }

        public double SpeedInput
        {
            get { return speedInput; }
            set { speedInput = value; }
        }

        public double KmphToMph()
        {
            return speedInput / 1.609344;
        }

        public double MphToKmph()
        {
            return speedInput * 1.609344;
        }
    }
}
