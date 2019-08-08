using Algorithms;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringReversal_Reverse()
        {
            var logic = new StringReversal();
            Assert.Pass("olleH",logic.Reverse("Hello"));
        }
    }
}