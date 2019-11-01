using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMangerTest
{
    public abstract class FileSystem
    {
        protected string Name { get; set; }
        private DateTime CreationDateTime { get; set; }
        private DateTime LastModifiedDateTime { get; set; }
        private User CreatorUser { get; set; }
        public abstract int GetSize();
        public abstract void Rename(string newName);
        protected abstract bool IsValidName(string name);

        protected FileSystem(string name)
        {
            Name = name;
            CreationDateTime=DateTime.Now;
        }
        
     
    }
}
