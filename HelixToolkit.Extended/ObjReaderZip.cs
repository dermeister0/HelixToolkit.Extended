using System.Windows.Threading;
using ICSharpCode.SharpZipLib.Zip;

namespace HelixToolkit.Extended
{
    public class ObjReaderZip : ObjReader
    {
        ZipFile zipFile;

        public ObjReaderZip(ZipFile zipFile, Dispatcher dispatcher)
            : base(dispatcher)
        {            
            this.zipFile = zipFile;
        }

        protected override IFileSystem GetFileSystem()
        {
            return new ZipFileSystem(zipFile);
        }
    }
}
