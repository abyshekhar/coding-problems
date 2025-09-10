using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.xUnit.Tests
{
    public class Sample1Tests
    {
        [Theory]
        [InlineData("cbaebabacd", "abc", new int[]{0, 6})]
        public void Test_FindAnagrams(string str, string pattern, IList<int> startIndexes)
        {
            IList<int> result = Sample1.FindAnagrams(str, pattern);
            Assert.Equal(startIndexes,result);
        }

        [Theory]
        [InlineData("cbaebabacd", "abc", new int[] { 0, 6 })]
        public void Test_IndexesAnagramInAString(string str, string pattern, IList<int> startIndexes)
        {
            IList<int> result = Sample1.FindAnagrams(str, pattern);
            Assert.Equal(startIndexes, result);
        }
        [Theory]
        [InlineData(new int[] {1,2,3,4,6},6)]
        public void Test_MissingNumber(int[] numbers,int n)
        {
            int result = Sample1.MissingNumber(numbers, n);
            Assert.Equal(5, result);
        }
    }
}
