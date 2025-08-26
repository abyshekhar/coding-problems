using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTests
{
    [TestFixture]
    public class Sample1Tests
    {
        [Test]
        public void Test_ReverseString()
        {
            Assert.That(Sample1.ReverseString("Sudhanshu Shekhar"), Is.EqualTo("rahkehS uhsnahduS"));
        }
        [TestCase("nitin", ExpectedResult = "nitin")]
        [TestCase("Hello World!",ExpectedResult ="!dlroW olleH")]
        public string ReverseStringTests(string str)
        {
            return Sample1.ReverseString(str);
        }

        [TestCase("Hello World",ExpectedResult ="olleH dlroW")]
        [TestCase("Hello",ExpectedResult ="olleH")]
        public string ReverseIndividualWordsInASentenceTests(string str)
        {
            return Sample1.ReverseIndividualWordsInASentence(str);
        }
    }
}
