using NUnit.Framework;
using lib;
namespace lib.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           Assert.AreEqual("BONJOUR", Uppercase.ToUpper("bonjour"));
        }
    }
}