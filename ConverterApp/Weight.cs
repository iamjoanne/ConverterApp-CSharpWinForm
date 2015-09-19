using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterApp
{
    class Weight
    {
        private double weightInput;

        public Weight() { }
        public Weight(double weightIn)
        {
            this.weightInput = weightIn;
        }

        public double WeightInput
        {
            get { return weightInput; }
            set { weightInput = value; }
        }

        public double LbsToKg()
        {
            return weightInput * 0.4536;
        }

        public double KgToLbs()
        {
            return weightInput * 2.205;
        }
    }
}
