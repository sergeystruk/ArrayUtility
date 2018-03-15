using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace ArrayUtil.Tests
{
    [TestClass]
    public class ArrayModifierTests
    {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        [DataSource(@"Provider=Microsoft.VisualStudio.TestTools.DataSource.XML;
            Data Source=D:\EPAM\ArrayUtil\ArrayUtil.Tests\TestData\Test.xml;",
            "parametres")]
        public void FilterDigitsTest()
        {
            DataRow[] datas = TestContext.DataRow.GetChildRows("parameteres_TestCase1");
            string stringArrayTest = Convert.ToString(TestContext.DataRow["array"]);
            string[] bufStrings = stringArrayTest.Split(',');
            int[] testArray = new int[bufStrings.Length];
            for (int i = 0; i < bufStrings.Length; i++)
            {
                testArray[i] = Convert.ToInt32(bufStrings[i]);
            }

            int testNumber = Convert.ToInt32(TestContext.DataRow["number"]);

            int[] actualArray = ArrayModifier.FilterDigits(testArray, testNumber);
            int[] expectedArray = {12, 12, 100};
            CollectionAssert.AreEqual(actualArray,expectedArray);
        }
    }
}
