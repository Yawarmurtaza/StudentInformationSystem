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
            while (i < arr.Length + 1 && arr[i] == arr[i + 1] - 1)
            {
                i++;
            }

            return arr[i];
        }


        /// <summary>
        /// Binary Search
        /// index = 0,1,2,3,4,5,6,7
        /// value = 0,1,2,3,4,4,5,6
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FindOneRepeatingNumberInAConsecutiveSequenceV3(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int midIndex = start + (end - start) / 2;

                if (midIndex > arr[midIndex])
                {
                    end = midIndex - 1;
                }
                else
                {
                    start = midIndex + 1;
                }
            }

            return arr[start];
        }

    }
}