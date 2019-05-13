using System;
namespace Coche_Solid.Algoritmos
{
    public class MissingNumber
    {
       
        public int GetMissingNumber(int[] numbers, int totalCount)
        {
            int expectedSum = totalCount * ((totalCount + 1) / 2);
            int actualSum = 0;

            foreach (var i in numbers)
            {
                actualSum += i;
            }
           

            return expectedSum - actualSum;
        }
    }

}
