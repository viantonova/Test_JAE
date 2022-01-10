using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Linq;

namespace TestProject1
{
    //[TestFixture]
    //[AllureNUnit]
    //[AllureSuite("CalculatorTests")]
    //[AllureSubSuite("Example")]
    ////[AllureSeverity(AllureSeverity.Critical)]
    //[AllureDisplayIgnored]
    //public class Tests
    //{
    //    [SetUp]
    //    public void Setup()
    //    {
    //    }

    //    [Test(Description = "Add two integers and returns the sum")]
    //    [AllureTag("CI")]
    //    [AllureSeverity(SeverityLevel.critical)]
    //    [AllureIssue("8911")]
    //    [AllureTms("532")]
    //    [AllureOwner("Anton")]
    //    [AllureSuite("PassedSuite")]
    //    [AllureSubSuite("Add")]
    //    public void Test1()
    //    {
    //        Assert.Pass();
    //    }
    //}

    [TestFixture]
    [AllureNUnit]
    [AllureSuite("CalculatorTests")]
    [AllureSubSuite("Example")]
    [AllureDisplayIgnored]
    class CalculatorAddTests
    {
        [Test(Description = "Add two integers and returns the sum")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("8911")]
        [AllureTms("532")]
        [AllureOwner("Anton")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("Add")]
        public void Return4_WhenAdd2And2()
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var aa = teams.OrderBy(i => i);
            var a = teams.All(x => x.Contains("М"));
            var b = teams.Any(x => x.Contains("М"));

            var calculator = new Calculator();
            int actualResult = calculator.Add(2, 2);
            Assert.AreEqual(4, actualResult);
        }

        [Test(Description = "Add two integers and returns the sum")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Add")]
        public void Return0_WhenAdd0And0()
        {
            var calculator = new Calculator();
            int actualResult = calculator.Add(0, 0);
            Assert.AreEqual(0, actualResult);
        }

        [Test(Description = "Add two integers and returns the sum")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Add")]
        public void ReturnMinus5_WhenAddMinus3AndMinus2()
        {
            var calculator = new Calculator();
            int actualResult = calculator.Add(0, 0);
            Assert.AreEqual(1, actualResult);
        }

        [Test(Description = "Multiply two integers and returns the mullll")]
        [AllureTag("CI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Mul")]
        public void Return0_WhenMultiply10And0()
        {
            var calculator = new Calculator();
            int actualResult = calculator.Multiply(10, 0);
            Assert.AreEqual(1, actualResult);
        }

        [Test(Description = "Square 123")]
        public void Return_Square()
        {
            var calculator = new Calculator();
            int actualResult = calculator.Square(8);
            Assert.AreEqual(64, actualResult);
        }

        [Test(Description = "Square 2")]
        [Ignore("not neadded now")]
        public void Return_Square2()
        {
            var calculator = new Calculator();
            int actualResult = calculator.Square(8);
            Assert.AreEqual(64, actualResult);
        }

        [Test]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureFeature("Core")]
        public void EvenTest([Range(0, 5)] int value)
        {
            Assert.IsTrue(value % 2 == 0, $"Oh no :( {value} % 2 = {value % 2}");
        }
    }
}