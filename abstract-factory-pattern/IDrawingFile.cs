namespace abstract_factory_pattern
{
    public interface IDrawingFile
    {
        void Validate();
    }

    public class CadFile : IDrawingFile
    {
        public void Validate()
        {

        }
    }

    public class DxfFile : IDrawingFile
    {
        public void Validate()
        {

        }
    }
}
