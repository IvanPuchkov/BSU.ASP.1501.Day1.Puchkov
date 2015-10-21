using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    class SumSorter: ISorterType
    {
        private const String Name = "SummarySort";

        public String GetName()
        {
            return Name;
        }

        public SumSorter()
        { }

        public int CalculateFaktor(int[] vektor)
        {
            int sum = 0;
            foreach (var value in vektor)
            {
                sum += value;
            }
            return sum;
        }
    }
}
