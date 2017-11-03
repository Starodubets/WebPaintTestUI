using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;


namespace NUnitTestWeb
{
     [TestFixture(typeof(ChromeDriver))]
    //[TestFixture(typeof(InternetExplorerDriver))]
    //[TestFixture(typeof(FirefoxDriver))]
    //[TestFixture(typeof(OperaDriver))]

    public class TestWithMultipleBrowsers<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver = new TWebDriver();
        [SetUp]
        public void CreateDriver()
        {
            driver.Url = @"file:///C:/Users/Student/Desktop/STAR/3.11/index.html";
        }
        [OneTimeTearDown]

        public void Cleanup()
        {
            driver.Dispose();
        }
        [Test]
        [Category("IsElementExists")]
        [TestCase("mFile", TestName = "IsElementExists_1")]
        [TestCase("mEditFigure", TestName = "IsElementExists_2")]
        [TestCase("mEditText", TestName = "IsElementExists_3")]
        [TestCase("mEditTab", TestName = "IsElementExists_4")]
        [TestCase("mSwitchTab", TestName = "IsElementExists_5")]
        [TestCase("mPlugins", TestName = "IsElementExists_6")]
        [TestCase("mCloud", TestName = "IsElementExists_7")]
        [TestCase("mNetwork", TestName = "IsElementExists_8")]
        [TestCase("mSettings", TestName = "IsElementExists_9")]
        [TestCase("mHelp", TestName = "IsElementExists_10")]
        [TestCase("myToolBar", TestName = "IsElementExists_11")]
        [TestCase("tSave", TestName = "IsElementExists_12")]
        [TestCase("tLoad", TestName = "IsElementExists_13")]
        [TestCase("tSaveCloud", TestName = "IsElementExists_14")]
        [TestCase("tLoadCloud", TestName = "IsElementExists_15")]
        [TestCase("tNew", TestName = "IsElementExists_16")]
        [TestCase("tDel", TestName = "IsElementExists_17")]
        [TestCase("tReN", TestName = "IsElementExists_18")]
        [TestCase("leftToolBox", TestName = "IsElementExists_19")]
        [TestCase("rightToolBox", TestName = "IsElementExists_20")]
        [TestCase("simpleFigurePluginBtn", TestName = "IsElementExists_21")]
        [TestCase("FigureWithPluginBtn", TestName = "IsElementExists_22")]
        [TestCase("FigureWithPicturePluginBtn", TestName = "IsElementExists_23")]

        public void IsElementExists(string a)
        {
            Assert.AreEqual(driver.FindElement(By.Id(a)).Displayed, true);
            driver.Navigate().Refresh();
        }
        [Test]
        [Category("IsElementExists")]
        [TestCase("mFile", "mSave",TestName = "IsElementExists_24")]
        [TestCase("mFile", "mOpen", TestName = "IsElementExists_25")]
        [TestCase("mEditFigure", "editSubMenu", TestName = "IsElementExists_26")]
        [TestCase("mEditTab", "mAddTab", TestName = "IsElementExists_27")]
        [TestCase("mEditTab", "mDelTab", TestName = "IsElementExists_28")]
        [TestCase("mEditTab", "mRenTab", TestName = "IsElementExists_29")]
        [TestCase("mSwitchTab", "mSwitchBtn", TestName = "IsElementExists_30")]
        [TestCase("mCloud", "mCloudSave", TestName = "IsElementExists_31")]
        [TestCase("mCloud", "mCloudOpen", TestName = "IsElementExists_32")]
        [TestCase("mNetwork", "mOpenSes", TestName = "IsElementExists_33")]
        [TestCase("mHelp", "faqm", TestName = "IsElementExists_34")]
        [TestCase("mHelp", "aboutm",  TestName = "IsElementExists_35")]


        public void IsDropDownElementExists(string a, string b)
        {
            driver.FindElement(By.Id(a)).Click();
            Assert.AreEqual(driver.FindElement(By.Id(b)).Displayed, true);
            driver.Navigate().Refresh();
        }
        //[Test]
        //[Category("SimpleCheck")]
        //[TestCase("btnOne", "1", TestName = "SimpleCheck_1")]
        //[TestCase("btnTwo", "2", TestName = "SimpleCheck_2")]
        //[TestCase("btnThree", "3", TestName = "SimpleCheck_3")]
        //[TestCase("btnFour", "4", TestName = "SimpleCheck_4")]
        //[TestCase("btnFive", "5", TestName = "SimpleCheck_5")]
        //[TestCase("btnSix", "6", TestName = "SimpleCheck_6")]
        //[TestCase("btnSeven", "7", TestName = "SimpleCheck_7")]
        //[TestCase("btnEight", "8", TestName = "SimpleCheck_8")]
        //[TestCase("btnNine", "9", TestName = "SimpleCheck_9")]
        //[TestCase("btnZero", "0", TestName = "SimpleCheck_10")]
        //[TestCase("ReadOut", "0", TestName = "SimpleCheck_11")]

        //public void SimpleCheck(string a, string b)
        //{
        //    driver.FindElement(By.Name(a)).Click();
        //    Assert.AreEqual(driver.FindElement(By.Name("ReadOut")).GetAttribute("value"), b);
        //    driver.Navigate().Refresh();
        //}

        //[Test]
        //[Category("ComplexCheck")]
        //[TestCase(new string[] { "btnSeven", "btnSeven", "btnSeven" }, "777", TestName = "ComplexCheck_1")]
        //[TestCase(new string[] { "btnSeven", "btnEight", "btnEight" }, "788", TestName = "ComplexCheck_2")]
        //[TestCase(new string[] { "btnSeven", "btnSeven", "btnEight", "btnFive" }, "7785", TestName = "ComplexCheck_3")]
        //[TestCase(new string[] { "btnFive", "btnOne", "btnZero", "btnOne", "btnZero" }, "51010", TestName = "ComplexCheck_4")]

        //public void ComplexCheck(string[] a, string b)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        driver.FindElement(By.Name(a[i])).Click();
        //    }
        //    Assert.AreEqual(b, driver.FindElement(By.Name("ReadOut")).GetAttribute("value"));
        //    driver.Navigate().Refresh();
        //}

        //[Test]
        //[Category("RealJob")]
        //[TestCase(new string[] { "btnFive", "btnMultiply", "btnThree", "btnEquals" }, "15", TestName = "RealJob_1")]
        //[TestCase(new string[] { "btnSix", "btnDivide", "btnThree", "btnEquals" }, "2", TestName = "RealJob_2")]
        //[TestCase(new string[] { "btnFive", "btnPlus", "btnThree", "btnEquals" }, "8", TestName = "RealJob_3")]
        //[TestCase(new string[] { "btnFive", "btnMinus", "btnThree", "btnEquals" }, "2", TestName = "RealJob_4")]
        //public void RealJob(string[] a, string b)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        driver.FindElement(By.Name(a[i])).Click();
        //    }
        //    Assert.AreEqual(driver.FindElement(By.Name("ReadOut")).GetAttribute("value"), b);
        //    driver.Navigate().Refresh();
        //}
    }
}