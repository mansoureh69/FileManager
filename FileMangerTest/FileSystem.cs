using System;

namespace FileMangerTest
{
    public abstract class FileSystem:ICloneable
    {
        protected string Name { get; set; }
        protected DateTime CreationDateTime { get; set; }
        protected DateTime LastModifiedDateTime { get; set; }
        protected User CreatorUser { get; set; }
        public abstract int GetSize();
        public abstract void Rename(string newName);
        protected abstract bool IsValidName(string name);
        protected abstract bool IsDuplicateName(string name);

        protected FileSystem(string name)
        {
            Name = name;
            CreationDateTime=DateTime.Now;
        }


        public object Clone()
        {
            return (FileSystem)MemberwiseClone();
        }

    }
}
