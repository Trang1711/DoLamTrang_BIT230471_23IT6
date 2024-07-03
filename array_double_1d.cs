using System;

namespace ex4
{
    public class array_double_1d
    {
        private double[] numbers;

        public void SetNumbers(double[] arr)
        {
            numbers = arr;
        }

        public double FindMin()
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new InvalidOperationException("Array is null or empty");
            }

            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public double FindMax()
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new InvalidOperationException("Array is null or empty");
            }

            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }
}
