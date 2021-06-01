using System;
namespace factory_pattern
{
    public abstract class Creator
    {
        public abstract IDrawingFile Create(FileTypes fileTypes);
    }

    public class FileCreator : Creator
    {
        public override IDrawingFile Create(FileTypes fileTypes)
        {
            switch (fileTypes)
            {
                case FileTypes.Cad:
                    return new CadFile();
                case FileTypes.Dxf:
                    return new DxfFile();
                default:
                    throw new Exception("type is not valid");
            }
        }
    }

    public enum FileTypes
    {
        Dxf = 1,
        Cad = 2
    }

}
