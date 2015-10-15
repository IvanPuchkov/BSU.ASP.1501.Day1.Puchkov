using System;

public class BubbleSorter
{
    public BubbleSorter()
    {
    }

    public enum SortType { MaxValue, Sum, MinValue };

    int GetMax(int[] vektor)
    {
        int max = vektor[0];
        for (int i = 1; i < vektor.Length; i++)
        {
            if (vektor[i] > max)
                max = vektor[i];
        }
        return max;

    }

    int GetMinValue(int[] vektor)
    {
        int min = vektor[0];
        for (int i = 1; i < vektor.Length; i++)
        {
            if (vektor[i] < min)
                min = vektor[i];
        }
        return min;
    }

    int CalculateSumValue(int[] vektor)
    {
        int sum = 0;
        for (int i = 0; i < vektor.Length; i++)
            sum += vektor[i];
        return sum;
    }

    void SwapValuesWithinArray(int[] array, int index1, int index2)
    {
        int c = array[index1];
        array[index1] = array[index2];
        array[index2] = c;
    }

    void SwapArray(int[][] array, int a, int b)
    {
        int[] c = array[a];
        array[a] = array[b];
        array[b] = c;
    }

    public void Sort(int[][] ar, SortType mode, bool asc)
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
                switch (mode)
                {
                    case SortType.Sum:
                        subArray[i] = CalculateSumValue(ar[i]);
                        break;
                    case SortType.MaxValue:
                        subArray[i] = GetMax(ar[i]);
                        break;
                    case SortType.MinValue:
                        subArray[i] = GetMinValue(ar[i]);
                        break;
                }
            }
        }
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < ar.GetLength(0) - 1; j++)
            {
                if (asc ? subArray[j] > subArray[j + 1] : subArray[j] < subArray[j + 1])
                {
                    SwapValuesWithinArray(subArray, j, j + 1);
                    SwapArray(ar, j, j + 1);
                }
            }
        }
    }
}

