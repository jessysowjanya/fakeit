using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1.classes
{
    public class Simpleinterest 
    {
        public readonly IMaths iMaths;
        public Simpleinterest(IMaths IMaths)
        {
            this.iMaths = IMaths;
        }
        public double CalulateSimpleinterest(int principle, int rate, int time)
        {
            return (principle * rate * time) / 100;
        }
    }
}


