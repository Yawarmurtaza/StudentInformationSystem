namespace StudentInformationSystem.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class InterviewQuestions_CanadaTests
    {
        private InterviewQuestions_Canada runner;
        [SetUp]
        public void Setup()
        {
            runner = new InterviewQuestions_Canada();
        }

        [TestCase(new[] { 0, 1, 2, 2, 3, 4 }, 2)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11 }, 9)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 6)]
        [TestCase(new[] { 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 1)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 14 }, 14)]
        public void FindOneRepeatingNumberInAConsecutiveSequence(int[] arr, int expected)
        {
            int actual = runner.FindOneRepeatingNumberInAConsecutiveSequence(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 0, 0,1, 2, 3, 4 }, 0)]
        [TestCase(new[] { 0, 1, 2, 2, 3, 4 }, 2)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11 }, 9)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 6)]
        [TestCase(new[] { 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 1)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 14 }, 14)]
        public void FindOneRepeatingNumberInAConsecutiveSequenceV2(int[] arr, int expected)
        {
            int actual = runner.FindOneRepeatingNumberInAConsecutiveSequenceV2(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 0, 0, 1, 2, 3, 4 }, 0)]
        [TestCase(new[] { 0, 1, 2, 2, 3, 4 }, 2)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11 }, 9)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 6)]
        [TestCase(new[] { 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, 1)]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 14 }, 14)]
        public void FindOneRepeatingNumberInAConsecutiveSequenceV3(int[] arr, int expected)
        {
            int actual = runner.FindOneRepeatingNumberInAConsecutiveSequenceV3(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}