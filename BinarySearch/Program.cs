using System;

namespace DataStructuresAlgorithms
{
    public static class BinarySearch
    {
        static void Main(string[] args)
        {           
            int[] arrayList = { 1,2,4,5,6,8,23 };
            Console.WriteLine($"Actual array: {string.Join(",",arrayList)}");

            // Find an element in the sorted arrya using binary search
            int target = 5;
            int index = SearchWithBinarySearch(arrayList, target);
            Console.WriteLine($"The index of value {target} : {index}");            
        }

        /// <summary>
        /// Binary search with iteration
        /// </summary>
        /// <param name="arrayList"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static int SearchWithBinarySearch(int[] arrayList, int target)
        {
            int start = 0;
            int end = arrayList.Length - 1;            

            while(start <= end)
            {
                int middle = (start + end)/2;
                if (arrayList[middle] == target)
                {
                    return middle;
                }                   
                else if(target < arrayList[middle])
                {                   
                    end = middle-1;
                }
                else
                {
                    start = middle+1;
                }              
            }
            return -1;
        }       
    }
}
