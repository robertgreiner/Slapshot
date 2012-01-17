using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Slapshot.Tests
{
    [TestFixture]
    class ScreenshotTest
    {
        [Test]
        public void ShouldUseDefaultDirectoryIfInvalidDirectoryIsGiven()
        {
            var s = new Screenshot();
            Assert.AreEqual(expected: ".", actual: s.SaveDirectory);
        }

        [Test]
        public void ShouldCreateAnImageFileWithSomethingInIt()
        {
            //var s = new Screenshot(".", ImageFormat.Png);
            //s.CaptureEntireScreen();
            //Assert.IsTrue(File.Exists(@".\screenshot.png"));
        }
    }
}
