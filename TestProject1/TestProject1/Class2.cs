using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    [AllureNUnit]
    class Class2
    {
        [AllureStep]
        public void MethodExample()
        {
            //Step name = "MethodExample"
        }

        [Test]
        public void Test1()
        {
            StepSample("user", "pwd123");
        }

        [AllureStep("Login with user {0} and password {1}")]
        public void StepSample(string username, string password)
        { }
    }
}
