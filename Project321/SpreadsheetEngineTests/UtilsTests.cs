using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace UtilsTests
{
    /// <summary>
    /// This is the class that will be conducting all tests on the Utils.cs file.
    /// </summary>
    public class UtilsTests
    {
        //---------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// This test tests for an exceptional case.
        /// </summary>
        [Test]
        public void IntToBase26TestException()
        {
            int testCase = -1;

            Assert.Throws<ArgumentException>(() => Utils.Utils.IntToBase26(testCase));
        }

        /// <summary>
        /// Test case for when the number that is input is zero.
        /// </summary>
        [Test]
        public void IntToBase27TestBoundary()
        {
            int testCase = 0;
            string expectedResult = new string("A");

            Assert.That(Utils.Utils.IntToBase26(testCase), Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// Regular test case when the returned value is supposed to be a size two string.
        /// </summary>
        [Test]
        public void IntToBase28TestregularOne()
        {
            int testCase = 26;
            string expectedResult = new string("AA");

            Assert.That(Utils.Utils.IntToBase26(testCase), Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// Regular test case when the returned value is supposed to be a size one string.
        /// </summary>
        [Test]
        public void IntToBase28TestregularTwo()
        {
            int testCase = 2;
            string expectedResult = new string("C");

            Assert.That(Utils.Utils.IntToBase26(testCase), Is.EqualTo(expectedResult));
        }

        //---------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Tests for an exception in the Base28ToInt function in utils.
        /// </summary>
        [Test]
        public void Base28ToIntTestExceptionOne()
        {
            string testCase = "$#^&*&^%#";

            Assert.Throws<ArgumentException>(() => Utils.Utils.Base26ToInt(testCase));
        }

        /// <summary>
        /// Tests for an exception in the Base28ToInt function in utils.
        /// </summary>
        [Test]
        public void Base28ToIntTestExceptionTwo()
        {
            string testCase = string.Empty;

            Assert.Throws<ArgumentException>(() => Utils.Utils.Base26ToInt(testCase));
        }

        /// <summary>
        /// Tests for an exception in the Base28ToInt function in utils.
        /// </summary>
        [Test]
        public void Base28ToIntTestExceptionThree()
        {
            string testCase = "-AAA";

            Assert.Throws<ArgumentException>(() => Utils.Utils.Base26ToInt(testCase));
        }

        /// <summary>
        /// Tests for a zero value in the function.
        /// </summary>
        [Test]
        public void Base28ToIntTestBoundary()
        {
            string testCase = "A";

            int expectedResult = 0;

            Assert.That(Utils.Utils.Base26ToInt(testCase), Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// Tests for a regular value in the function.
        /// </summary>
        [Test]
        public void Base28ToIntTestRegular()
        {
            string testCase = "AZ";

            int expectedResult = 51;

            Assert.That(Utils.Utils.Base26ToInt(testCase), Is.EqualTo(expectedResult));
        }

        //---------------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// tests the pattern matching function when the it is possible.
        /// </summary>
        [Test]
        public void MatchesCellReferencePatternTestTrue()
        {
            string testCase = "AA10";
            bool expectedResult = true;

            Assert.That(Utils.Utils.MatchesCellReferencePattern(testCase), Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// tests the pattern matching function when the it is not possible.
        /// </summary>
        [Test]
        public void MatchesCellReferencePatternTestFalseOne()
        {
            string testCase = "A1A10";
            bool expectedResult = false;

            Assert.That(Utils.Utils.MatchesCellReferencePattern(testCase), Is.EqualTo(expectedResult));
        }

        /// <summary>
        /// tests the pattern matching function when the it is not possible.
        /// </summary>
        [Test]
        public void MatchesCellReferencePatternTestFalseTwo()
        {
            string testCase = "*&(*&#";
            bool expectedResult = false;

            Assert.That(Utils.Utils.MatchesCellReferencePattern(testCase), Is.EqualTo(expectedResult));
        }
    }
}