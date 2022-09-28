using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PracticeExceptionandIgnore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            int a = 25, b = 65;
            int c = a + b;
            Console.WriteLine(c);
        }

        [TestMethod]
        [Ignore("This method is skipped")]
        public void TestSub()
            {
            int a = 30, b = 10, c;
             c = a-b;
             Console.WriteLine(c);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDiv()
        {
            int i = 10, j = 0, x;
            x = i / j;
            Console.WriteLine(x);
        }

    }
}
