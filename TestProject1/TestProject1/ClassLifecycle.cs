using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    [TestFixture(Author = "unickq", Description = "Examples")]
    [AllureNUnit]
    [AllureLink("https://github.com/unickq/allure-nunit")]
    class ClassLifecycle
    {
        //[OneTimeSetUp]
        //public void ClearResultsDir()
        //{
        //    AllureLifecycle.Instance.CleanupResultDirectory();
        //}

        ////Allure.Steps required
        //[AllureStep("This method is just saying hello")]
        //private void SayHello()
        //{
        //    Console.WriteLine("Hello!");
        //}

        //[Test]
        //[AllureTag("NUnit", "Debug")]
        //[AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        //[AllureSeverity(SeverityLevel.critical)]
        //[AllureFeature("Core")]
        //public void EvenTest([Range(0, 5)] int value)
        //{
        //    SayHello();

        //    //Wrapping Step
        //    AllureLifecycle.Instance.WrapInStep(
        //        () => { Assert.IsTrue(value % 2 == 0, $"Oh no :( {value} % 2 = {value % 2}"); },
        //        "Validate calculations");
        //}

        //public static void MakeScreenshot(string screenshotName = "Скриншот")
        //{
        //    AllureLifecycle.AddAttachment("", "", "Attachment Title");
        //}
    }
}
