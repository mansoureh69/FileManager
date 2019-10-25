using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FileMangerTest
{
    public class File : Base
    {
        public Format FileFormat { get; set; }
        public int GetSizeOfFile()
        {
            return Size;
        }

    }

    public enum Format
    {
        Pdf = 1,
        Doc,
        Txt,

    }
}
