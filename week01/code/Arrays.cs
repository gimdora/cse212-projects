public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1) Create a new double array with the requested size (length).
        // 2) Loop from i = 0 to i = length - 1.
        // 3) For each position i, store number * (i + 1) in the array.
        //    - i = 0 -> number * 1
        //    - i = 1 -> number * 2
        //    - ...
        // 4) Return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan :
        // 1) Let n be data.Count.
        // 2) Compute splitIndex = n - amount.
        //    Everything from splitIndex to the end will move to the front.
        // 3) Copy the last 'amount' items into a new list called tail.
        // 4) Copy the first (n - amount) items into a new list called head.
        // 5) Clear the original list.
        // 6) Add tail items first, then add head items.
        // 7) The original list is now rotated to the right.

        int n = data.Count;
        int splitIndex = n - amount;

        List<int> tail = data.GetRange(splitIndex, amount);
        List<int> head = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
