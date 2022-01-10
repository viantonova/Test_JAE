using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    class Class2
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, "да".Length);     
        }


        [Test]
        public void Test2()
        {
            Assert.AreEqual(2, "нет".Length);
        }
    }
}
