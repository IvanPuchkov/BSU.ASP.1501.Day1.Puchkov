using System.Collections.Generic;

namespace BubbleSorter
{
    using System;

    public class BubbleSorter
    {

        private readonly List<ISorterType> _sorterTypes;  
        public BubbleSorter()
        {
            _sorterTypes=new List<ISorterType>();
            _sorterTypes.Add(new MaxValueSort());
            _sorterTypes.Add(new SumSorter());
            _sorterTypes.Add(new MinValueSort());
        }

        

        
        void Swap(ref int index1, ref int index2)
        {
            int c = index1;
            index1 =index2;
            index2 = c;
        }

        void Swap(ref int[] a, ref int[] b)
        {
            int[] c = a;
            a = b;
            b = c;
        }

        public void Sort(int[][] ar, bool asc, String sortTypeName)
        {
            if ((sortTypeName==null)||(sortTypeName==string.Empty))
                throw new ArgumentException("'sortTypeName' can't be null or empty!");
            ISorterType sorterTypeObject=null;
            foreach (var sorterType in _sorterTypes)
            {
                if (sorterType.GetName() == sortTypeName)
                    sorterTypeObject = sorterType;
            }
            if(sorterTypeObject==null)
                throw new ArgumentException(string.Format("Can't find sorter object with name {0}", sortTypeName));
            else
                Sort(ar, asc, sorterTypeObject);
        }

        public void Sort(int[][] ar, bool asc, ISorterType sorterTypeObject)
        {
            if (ar == null)
                throw new NullReferenceException();
            int[] subArray = new int[ar.GetLength(0)];
            for (int i = 0; i < ar.GetLength(0); i++)
            {

                if (ar[i] == null)
                    subArray[i] = int.MaxValue;
                else
                {
                    subArray[i] = sorterTypeObject.CalculateFaktor(ar[i]);
                }
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(0) - 1; j++)
                {
                    if (asc ? subArray[j] > subArray[j + 1] : subArray[j] < subArray[j + 1])
                    {
                        Swap(ref subArray[j], ref subArray[j + 1]);
                        Swap(ref ar[j], ref ar[j + 1]);
                    }
                }
            }
        }

        public void AddSorterObjectToCollection(ISorterType sorterTypeObject)
        {
            _sorterTypes.Add(sorterTypeObject);
        }


        public void Sort(int[][] ar, bool asc)
        {
            Sort(ar,asc,_sorterTypes[0]);
        }
    }

}
