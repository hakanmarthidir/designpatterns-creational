namespace abstract_factory_pattern
{
    public class FileManager
    {
        private readonly IFileFactory _fileFactory;
        public FileManager(IFileFactory fileFactory)
        {
            this._fileFactory = fileFactory;
        }

        public void CreateFile(string name)
        {
            var file = this._fileFactory.CreateFile(name);
        }
    }

}
