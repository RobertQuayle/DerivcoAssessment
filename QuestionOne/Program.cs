using System;

namespace QuestionOne
{
    class Program
    {


        static void Main(string[] args)
        {

            string test_string = "This is a test string";

            string encoded = DerivcoUtil.Encoding.Encode(test_string);
            string decoded = DerivcoUtil.Encoding.Decode(encoded);

            if (String.Equals(test_string, decoded))
            {
                Console.WriteLine("Test succeeded");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

        }

    }
}