using System.IO;

namespace HelixToolkit.Extended
{
    class BasicFileSystem : IFileSystem
    {
        public virtual bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public Stream GetStream(string path)
        {
            return File.OpenRead(path);
        }
    }
}
