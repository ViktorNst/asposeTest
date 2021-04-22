using AsposeTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AsposeUnitTestProject
{
    [TestClass]
    public class StringToKeypadConverterTest
    {
        private StringToKeypadConverter stringToKeypadConverter;

        [TestInitialize]
        public void Setup()
        {
            stringToKeypadConverter = new StringToKeypadConverter();
        }

        [TestMethod]
        [DynamicData(nameof(testValuesProvider), DynamicDataSourceType.Method)]
        public void convertsString(string input, string result)
        {
            string s = stringToKeypadConverter.convertToKeyPad(input);
            Assert.AreEqual(result, s);
        }

        static IEnumerable<object[]> testValuesProvider()
        {
            yield return new object[] { "hello world", "4433555 555666096667775553" };
            yield return new object[] { "foo  bar", "333666 6660 022 2777" };
            yield return new object[] { "yes", "999337777" };
            yield return new object[] { "hi", "44 444" };
            yield return new object[] { " abc ", "02 22 2220" };
        }

        [TestMethod]
        public void skipsUnknownValues()
        {
            string s = stringToKeypadConverter.convertToKeyPad("Ay*e#s5");
            Assert.AreEqual("999337777", s);
        }
    }
}
