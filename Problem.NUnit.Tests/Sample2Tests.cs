using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.NUnit.Tests
{
    [TestFixture]
    public class Sample2Tests
    {
        [Test]
        public void Test_IsPalindrome()
        {
            Assert.That(Sample2.IsPalindrome("racecar"), Is.True);
            Assert.That(Sample2.IsPalindrome("madam"), Is.True);
        }
    }
}
