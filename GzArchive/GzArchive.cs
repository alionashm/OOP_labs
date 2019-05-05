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

namespace GzArchive
{
    public class GzArchive : IZip
    {
        public string Zip(string source, string target)
        {
            using (Stream s = new GZipOutputStream(File.Create(target)))
            {
                using (FileStream fs = File.OpenRead(source))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, (int)fs.Length);
                    s.Write(buffer, 0, buffer.Length);
                }
            }
            return target;
        }
        public string UnZip(string source, string target)
        {
            using (Stream input = new GZipInputStream(File.OpenRead(source)))
            {
                using (FileStream output = File.Create(target))
                {
                    int buffSize = 2048;
                    byte[] outBuffer = new byte[2048];
                    while (true)
                    {
                        buffSize = input.Read(outBuffer, 0, buffSize);
                        if (buffSize > 0)
                        {
                            output.Write(outBuffer, 0, buffSize);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return target;
        }
    }
}
