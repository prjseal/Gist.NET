using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gist.NET.Test
{
    [TestClass]
    public class GistHelperTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            GistHelper gistHelper = new GistHelper("sadsa");
            string actual = gistHelper.GetGistUrl("[gist id=x file=y.z]");
            string expected = "asdasda";
            Assert.AreEqual(expected, actual);
        }
    }
}
