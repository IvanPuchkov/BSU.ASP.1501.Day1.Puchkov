using System;

class NewtonRoot
{
    public static double Root(double c, int n, double eps)
    {
        if (n <= 0)
            throw new ArgumentException();
        if ((c < 0) && (n % 2 == 0))
        {
            return double.NaN;
        }

        double prevValue;
        double curValue = 1;
        double pow;
        int iteration = 0;
        do
        {
            prevValue = curValue;
            iteration++;
            pow = 1;
            for (int i = 0; i < n - 1; i++)
                pow *= prevValue;


            curValue = (prevValue * (n - 1) + c / pow) / n;
        }
        while (Math.Abs(curValue - prevValue) > eps);

        return curValue;
    }
}
