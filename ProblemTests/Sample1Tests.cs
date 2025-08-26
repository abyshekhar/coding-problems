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
        public  void Test_ReverseString()
        {
            Assert.That(Sample1.ReverseString("Sudhanshu Shekhar"), Is.EqualTo("rahkehS uhsnahduS"));
        }
    }
}
