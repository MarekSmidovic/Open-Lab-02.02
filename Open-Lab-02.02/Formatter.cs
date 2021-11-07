using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {

        public void Format(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " " );
            }         
        }
    }
}
