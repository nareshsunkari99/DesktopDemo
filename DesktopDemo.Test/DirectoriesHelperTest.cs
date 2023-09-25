using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DesktopDemo.Helpers;

namespace DesktopDemo.Test
{
    [TestClass]
    public class DirectoriesHelperTest
    {
        [TestMethod]
        public void myTest_PassZero_returnsInvalidMessge()
        {
            DirectoriesHelper directoriesHelper = new DirectoriesHelper();
           var result= directoriesHelper.myTest(0);
            Assert.AreEqual("you are zero", result);
        }


        [TestMethod]
        public void myTest_PassGreaterThanZero_returnsvalidMessge()
        {
            DirectoriesHelper directoriesHelper = new DirectoriesHelper();
            var result = directoriesHelper.myTest(1);
            Assert.AreEqual("you are hero", result);
        }
    }
}
