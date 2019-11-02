using System;

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

        public override void Rename(string newName)
        {
            if (IsValidName(newName))
                Name = newName;
        }

        protected override bool IsValidName(string name)
        {
            return !IsDuplicateName(name);
        }

        protected override bool IsDuplicateName(string name)
        {
            throw new NotImplementedException();
        }
        
        public File(string name, int size) : base(name)
        {
            Size = size;
        }
    }

    public enum Format
    {
        Pdf = 1,
        Doc,
        Txt

    }
}
