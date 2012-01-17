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
            var s = new Screenshot("asdfasdfasdfasdfasdfasdfasdfasdfadsf", null);
            Assert.AreEqual(".", actual: s.SaveDirectory);
        }

        [Test]
        public void ShouldCreateAFileNameThatEndsWithTheCorrectImageFormatExtension()
        {
            var s = new Screenshot(".", ImageFormat.Png);
            Assert.IsTrue(s.FileName.EndsWith(".png"));
        }

        [Test]
        public void ShouldNotHaveAFileNameWithDirectoryInformation()
        {
            var s = new Screenshot(Path.GetTempPath(), ImageFormat.Png);
            Assert.IsFalse(s.FileName.StartsWith(Path.GetTempPath()));
        }

        [Test]
        public void ShouldBuildAValidFilePathToSaveScreenshot()
        {
            var s = new Screenshot(Path.GetTempPath(), ImageFormat.Png);
            Assert.IsTrue(s.FilePath.StartsWith(Path.GetTempPath()));
        }
    }
}
