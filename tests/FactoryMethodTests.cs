using System;
using abstract_factory_pattern;
using factory_pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tests
{
    [TestClass]
    public class FactoryMethodTests
    {
        [TestMethod]
        public void FileManager_CreateFactory_Successfully()
        {
            FileCreator fileCreator = new FileCreator();
            var cadFile = fileCreator.Create(FileTypes.Cad);

            cadFile.Validate();


            Assert.IsTrue(cadFile is factory_pattern.CadFile);

        }
    }
}
