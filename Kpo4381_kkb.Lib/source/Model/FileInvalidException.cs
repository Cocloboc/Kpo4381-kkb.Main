using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.kkb.Lib.source.Model
{
    internal class FileInvalidException : Exception 
    { 
        public FileInvalidException(string message = "Содержимое файла некорректно") : base(message) 
        {
        } 
    }
}
