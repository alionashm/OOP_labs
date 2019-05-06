using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipInterface
{
    public interface IZip
    {
        /* При архивации
           source - архивируемый файл
           target - полученный архив
           При распаковке наоборот
           Возвращают имя результирующего файла*/

        string Zip(string source, string target);
        string UnZip(string source, string target);
    }
}
