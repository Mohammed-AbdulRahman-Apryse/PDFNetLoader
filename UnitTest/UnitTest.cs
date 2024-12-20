using Microsoft.VisualStudio.TestTools.UnitTesting;
using pdftron;
using System.IO;

namespace UnitTest
{
   [TestClass]
   public class UnitTest
   {
      PDFNetLoader Loader;

      public UnitTest()
      {
         Loader = PDFNetLoader.Instance();
      }

      [TestMethod]
      public void TestMethod1()
      {
         Assert.IsNotNull(Loader);
      }

      [TestMethod]
      public void TestMethod2()
      {
         string path = "C:\\Help\\Apryse\\PDFNetDotNet4\\Lib\\PDFNet";

         var bExists = Directory.Exists(path);
         if (bExists)
         {
            var dlls = Directory.GetFiles(path, "PDFNet.dll", SearchOption.AllDirectories);
            bExists = dlls.Length > 0;
            bExists = false;
            Assert.IsTrue(bExists);

            Loader.Path(path);
         }
      }
   }
}
