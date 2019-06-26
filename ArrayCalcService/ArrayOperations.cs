using ArrayCalcContracts;
using System.Collections.Generic;

namespace ArrayCalcService
{
    /// <summary>
    /// Array Operations Class
    /// </summary>
    public class ArrayOperations : IArrayOperations
    {
        /// <summary>
        /// Reverses an input array.
        /// </summary>
        /// <param name="inputArray">arraylist</param>
        public int[] ReverseArray(int[] inputArray)
        {
            //Assigning the input to a new array in order to avoid input modification.
            var outputArray = inputArray;

            //no operation if array is empty or has a single item
            if (outputArray == null || outputArray.Length < 2)
            {
                return outputArray;
            }

            int lowerbound = default(int);
            int upperbound = outputArray.Length - 1;

            //interchange items to reverse the arraylist
            while (lowerbound < upperbound)
            {
                var temp = outputArray[lowerbound];
                outputArray[lowerbound] = outputArray[upperbound];
                outputArray[upperbound] = temp;
                lowerbound++;
                upperbound--;
            }

            return outputArray;
        }

        /// <summary>
        /// Removes an element from input array at specified position.
        /// </summary>
        /// <param name="deletePosition">deletePosition</param>
        /// <param name="inputArray">inputArray</param>
        /// <returns>Modified Array</returns>
        public int[] DeleteAtPosition(int deletePosition, int[] inputArray)
        {
            if (inputArray == null)
                return inputArray;

            if (deletePosition <= default(int))
                return inputArray;

            //subtracting 1 from deletePosition as Arrays are zero index based 
            deletePosition--;

            //no operation if deletePosition is out of range from arraylist length
            if (deletePosition >= inputArray.Length)
            {
                return inputArray;
            }

            var processedList = new List<int>();

            //Adding array items to a new list except deleteposition item 
            for (int id = 0; id < inputArray.Length; id++)
            {
                if (id != deletePosition)
                {
                    processedList.Add(inputArray[id]);
                }
            }
            return processedList.ToArray();
        }
    }
}
