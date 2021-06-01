using System;

namespace factory_pattern
{
    public interface IDrawingFile
    {
        void Validate();
    }

    public class CadFile : IDrawingFile
    {
        public void Validate()
        {
            Console.WriteLine("cad file validated");
        }
    }

    public class DxfFile : IDrawingFile
    {
        public void Validate()
        {
            Console.WriteLine("dxf file validated");
        }
    }
}
