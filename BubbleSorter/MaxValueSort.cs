using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorter
{
    class MaxValueSort:ISorterType
    {
        private string Name = "MaxValueSort";

        public string GetName() => Name;

        public int CalculateFaktor(int[] vektor)
        {
            int max = vektor[0];
            for (int i = 1; i < vektor.Length; i++)
            {
                if (vektor[i] > max)
                    max = vektor[i];
            }
            return max;

        }




    }
}
