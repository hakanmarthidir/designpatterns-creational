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

            var fileManager = new FileManager(new DxfFileFactory());
            fileManager.CreateFile("abcd/efg.dxf");

            fileManager = new FileManager(new CadFileFactory());
            fileManager.CreateFile("defg/abcd.cad");

        }
    }
}
