using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;

namespace HelixToolkit.Extended
{
    class ZipFileSystem : IFileSystem
    {
        ZipFile zipFile;

        public ZipFileSystem(ZipFile zipFile)
        {
            this.zipFile = zipFile;
        }

        public bool FileExists(string path)
        {
            return zipFile.GetEntry(ConvertPath(path)) != null;
        }

        public System.IO.Stream GetStream(string path)
        {
            var entry = zipFile.GetEntry(ConvertPath(path));
            if (entry == null)
                throw new Exception("Resource not found: " + path);

            return zipFile.GetInputStream(entry);
        }

        string ConvertPath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return path;

            return path.Replace('\\', '/');
        }
    }
}
