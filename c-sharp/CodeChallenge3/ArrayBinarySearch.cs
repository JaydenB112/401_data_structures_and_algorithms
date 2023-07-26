using System.ComponentModel.Design;

namespace CodeChallenges 
{
    public class CodeChallenge3
    {
        public static int BinarySearch(int[] array, int key)
        {
        int high = array.Length - 1;
        int low = 0;

        while(low <= high)
      {
        int mid = low +(high - low) / 2 ;
        if (array[mid] == key)
        {
          while(mid > 0 && array[mid - 1] == key)
          {
            mid--;
          }return mid;
          { 
         else if  
          }
        }
      }
            int foundElementIndex = -1;
            return foundElementIndex;
        }
    }
}
