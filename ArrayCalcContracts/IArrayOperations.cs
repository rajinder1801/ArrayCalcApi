namespace ArrayCalcContracts
{
    public interface IArrayOperations
    {
        /// <summary>
        /// Reverses an input array.
        /// </summary>
        /// <param name="inputArray">inputArray</param>
        int[] ReverseArray(int[] inputArray);

        /// <summary>
        /// Removes an element from input array at specified position.
        /// </summary>
        /// <param name="deletePosition">deletePosition</param>
        /// <param name="inputArray">inputArray</param>
        /// <returns>Modified Array</returns>
        int[] DeleteAtPosition(int deletePosition, int[] inputArray);
    }
}
