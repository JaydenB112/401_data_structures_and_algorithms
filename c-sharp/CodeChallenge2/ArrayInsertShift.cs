namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      int midindex = array.Length / 2;
      int[] newArray = new int[array.Length + 1];
      for (int i = 0; i < midindex; i++)
      {
        newArray[i] = array[i];
      }
      newArray[midindex] = value;
      for (int i = midindex + 1; i < newArray.Length; i++)
      {
        newArray[i] = array[i - 1];
      }
        return newArray;
      

      
    }
  }
}
