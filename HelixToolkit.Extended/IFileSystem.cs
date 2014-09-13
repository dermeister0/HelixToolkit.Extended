using System.IO;

namespace HelixToolkit.Extended
{
    public interface IFileSystem
    {
        bool FileExists(string path);

        Stream GetStream(string path);
    }
}
