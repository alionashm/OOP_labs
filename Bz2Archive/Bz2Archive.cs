using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZipInterface;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.GZip;

namespace Bz2Archive
{
    public class Bz2Archive : IZip
    {
        public string Zip(string source, string target)
        {
            BZip2.Compress(File.OpenRead(source), File.Create(target), true, 1);
            return target;
        }
        public string UnZip(string source, string target)
        {
            BZip2.Decompress(File.OpenRead(source), File.Create(target), true);
            return target;
        }
    }
}
