using System;
using System.Collections.Generic;

namespace FileMangerTest
{
    public class Folder : FileSystem
    {
        private List<FileSystem> SubFileSystems { get; set; }
        private Folder ParentFolder { get; set; }

        public void AddSubFileSystem(FileSystem fileSys)
        {
            if (SubFileSystems != null)
                SubFileSystems.Add(fileSys);
            else

                SubFileSystems = new List<FileSystem> { fileSys };

        }
        
        public void RemoveSubFileSystem(FileSystem fileSystem)
        {
            if (SubFileSystems == null)
                throw new Exception();
            SubFileSystems.Remove(fileSystem);

        }
       
        public override int GetSize()
        {
            var totalSize = 0;
            SubFileSystems?.ForEach(x => { totalSize += x.GetSize(); });
            return totalSize;
        }

        public override void Rename(string newName)
        {
            if (IsValidName(newName))
                Name = newName;
        }

        protected override bool IsValidName(string name)
        {
            throw new NotImplementedException();
        }

        public Folder(string name, List<FileSystem> subFileSystems=null) : base(name)
        {
            SubFileSystems = subFileSystems;
        }
    }
}
