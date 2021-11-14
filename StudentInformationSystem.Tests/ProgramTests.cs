using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSystem.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ProgramTests
    {

        [TestCase("Khuwaja", 12012548, "Stream 20")]
        [TestCase("Khuwaja", 12012580, "Stream 21")]
        [TestCase("Yhuwaja", 12012501, "Stream 22")]
        [TestCase("Zhuwaja", 12012580, "Stream 23")]
        public void AllocateStreamTests(string surname, int studentId, string expected)
        {
            //string actual = Program.AllocateStreams(surname, studentId);
            //Assert.AreEqual(expected, actual);
        }
    }
}
