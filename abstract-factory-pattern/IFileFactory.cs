using System;

namespace abstract_factory_pattern
{
    public interface IFileFactory
    {
        IDrawingFile CreateFile(string name);
    }

    public class DxfFileFactory : IFileFactory
    {
        public IDrawingFile CreateFile(string name)
        {
            Console.WriteLine("Dxf file created");
            return new DxfFile();
        }
    }

    public class CadFileFactory : IFileFactory
    {
        public IDrawingFile CreateFile(string name)
        {
            Console.WriteLine("Cad file created");
            return new CadFile();
        }
    }

}
