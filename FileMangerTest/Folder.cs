using System;
using System.Collections.Generic;
using System.Linq;

namespace FileMangerTest
{
    public class Folder : FileSystem
    {
        private List<FileSystem> _subFileSystems;

        public void AddSubFileSystem(FileSystem fileSys)
        {
            if (_subFileSystems != null)
                _subFileSystems.Add(fileSys);
            else

                _subFileSystems = new List<FileSystem> { fileSys };

        }
        
        public void RemoveSubFileSystem(FileSystem fileSystem)
        {
            if (_subFileSystems == null)
                throw new Exception();
            _subFileSystems.Remove(fileSystem);

        }

        //public List<FileSystem> GetSubFolders()
        //{
        //    return SubFileSystems;
        //}
       
        public override int GetSize()
        {
            var totalSize = 0;
            _subFileSystems?.ForEach(x => { totalSize += x.GetSize(); });
            return totalSize;
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

       
        public Folder(string name, List<FileSystem> subFileSystems=null) : base(name)
        {
            _subFileSystems = subFileSystems;
        }

        public List<FileSystem> GetFileSystems()
        {
            return  Clone(_subFileSystems);
        }

       private  static  List<T> Clone<T>( List<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}
