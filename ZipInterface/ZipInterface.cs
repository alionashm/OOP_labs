using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipInterface
{
    public interface IZip
    {
        // При архивации
        // source - имя файла для архивации
        // target - имя полученного архива
        // Для распаковки - наоборот
        // Возвращают имя результирующего файла

        string Zip(string source, string target);
        string UnZip(string source, string target);
    }
}
