namespace StudentInformationSystem
{
    public class InterviewQuestions_Canada
    {
        public int FindOneRepeatingNumberInAConsecutiveSequence(int[] arr)
        {
            int originalTotal = 0;
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                originalTotal += i;
                total += arr[i];
            }

            int index = originalTotal - total;
            return arr[arr.Length - index];
        }

        public int FindOneRepeatingNumberInAConsecutiveSequenceV2(int[] arr)
        {
            int i = 0;
            while (i < arr.Length + 1 && arr[i] == arr[i + 1] -1)
            {
                i++;
            }

            return arr[i];
        }
    }
}