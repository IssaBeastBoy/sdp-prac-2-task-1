using NUnit.Framework;
using Problems;
using System.Collections;

namespace Tests
{
    public class MyTests
{
    [TestCaseSource(typeof(Tests), "TestCases")]
    public string DivideTest(string d)
    {
        return Program.Prefix(d);
    }
}
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }
        public static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData("hello").Returns("5,1:hello");
            yield return new TestCaseData("").Returns("0,0:");
            yield return new TestCaseData("what    ...  did you say?? ").Returns("27,5:what    ...  did you say?? ");
            yield return new TestCaseData(null).Returns(null);
            yield return new TestCaseData("Boy bye").Returns("7,2:Boy bye");
            yield return new TestCaseData("          ").Returns("10,0:          ");
        }
    }  
/*
        [Test]
        public void Test1()
        {
            //Program p = new Program();
            string results = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello", results);
        }

        [Test]
        public void Test2()
        {
           //Program p = new Program();
            string result =Program.Prefix("");
            Assert.AreEqual("0,0:", result);
        }

        [Test]
        public void Test3()
        {
           //Program p = new Program();
            string result =Program.Prefix("what    ...  did you say?? ");
            Assert.AreEqual("27,5:what    ...  did you say?? ", result);
        }
        */
    }
}