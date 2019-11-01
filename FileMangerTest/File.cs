using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FileMangerTest
{
    public class File : FileSystem
    {
        public Format FileFormat { get; set; }
        public int Size { get; set; }
        
        public override int GetSize()
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
