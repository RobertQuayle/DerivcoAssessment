using NUnit.Framework;
using System;
using DerivcoUtil;

namespace QuestionOne.NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        { }

        [Test]
        public void Test1()
        {
            // String for testing
            string test_string = "This is a test string";

            // Execute = Encode & Decode
            string encoded = DerivcoUtil.Encoding.Encode(test_string);
            string decoded = DerivcoUtil.Encoding.Decode(encoded);

            // Assert
            string result = (String.Equals(test_string, decoded)) ? "Pass" : "Fail";
            Assert.Pass(result, "Pass");
        }

        [Test]
        public void Test2()
        {
            // String for testing
            string test_string = "This is another test string.";

            // Execute = Encode & Decode
            string encoded = DerivcoUtil.Encoding.Encode(test_string);
            string decoded = DerivcoUtil.Encoding.Decode(encoded);

            // Assert
            string result = (String.Equals(test_string, decoded)) ? "Pass" : "Fail";
            Assert.Pass(result, "Pass");
        }

        [Test]
        public void Test3()
        {
            // String for testing
            string test_string = "Cameron is very handsome.";

            // Execute = Encode & Decode
            string encoded = DerivcoUtil.Encoding.Encode(test_string);
            string decoded = DerivcoUtil.Encoding.Decode(encoded);

            // Assert
            string result = (String.Equals(test_string, decoded)) ? "Pass" : "Fail";
            Assert.Pass(result, "Pass");
        }

        [Test]
        public void Test4()
        {
            // String for testing
            string test_string = "Cameron would be a great addition to MIGS, we should hire him.";

            // Execute = Encode & Decode
            string encoded = DerivcoUtil.Encoding.Encode(test_string);
            string decoded = DerivcoUtil.Encoding.Decode(encoded);

            // Assert
            string result = (String.Equals(test_string, decoded)) ? "Pass" : "Fail";
            Assert.Pass(result, "Pass");
        }


        [Test]
        public void Test5()
        {
            // String for testing
            string test_string = "This is Jibberish: fak3hgrlie239232;';'3'4;hefoig 3oioirwoiiuaw39r28yt[";

            // Execute = Encode & Decode
            string encoded = DerivcoUtil.Encoding.Encode(test_string);
            string decoded = DerivcoUtil.Encoding.Decode(encoded);

            // Assert
            string result = (String.Equals(test_string, decoded)) ? "Pass" : "Fail";
            Assert.Pass(result, "Pass");
        }


    }
}
