using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    class MinValueSort:ISorterType
    {
        private string name = "MinValueSort";

        public string GetName() => name;

        public int CalculateFaktor(int[] vektor)
        {
            int min = vektor[0];
            for (int i = 1; i < vektor.Length; i++)
            {
                if (vektor[i] < min)
                    min = vektor[i];
            }
            return min;
        }
    }
}
