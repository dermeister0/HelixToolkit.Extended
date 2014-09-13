HelixToolkit.Extended
=====================

Loading models from ZIP file
----------------------------

    using ICSharpCode.SharpZipLib.Zip;
    using System.Windows.Threading;

---
    
    using (var zipFile = new ZipFile("Resources.zip"))
    {
        var reader = new ObjReaderZip(zipFile, Dispatcher.CurrentDispatcher);
        
        var model1 = reader.Read("models\\body.obj");
        var model2 = reader.Read("models/head.obj");
    }
