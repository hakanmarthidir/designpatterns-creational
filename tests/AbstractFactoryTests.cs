using System;
using abstract_factory_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class AbstractFactoryTests
    {
        [TestMethod]
        public void FileManager_CreateFactory_Successfully()
        {

            var platform = "dxf";
            IFileFactory factory = null;

            if (platform == "dxf")
            {
                factory = new DxfFileFactory();
            }
            else if (platform == "cad")
            {
                factory = new CadFileFactory();
            }

            var fileManager = new FileManager(factory);
            fileManager.CreateFile("sample");

            Assert.IsTrue(factory is DxfFileFactory);

        }
    }
}
