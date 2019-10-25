using System;
using System.Collections.Generic;

namespace FileMangerTest
{
    public class Folder : Base
    {
        public List<Folder> SubFolders { get; set; }
        public List<File> Files { get; set; }
        public Folder ParentFolder { get; set; }

        public void AddFile(File file)
        {
            if (Files != null)
                Files.Add(file);
            else

                Files = new List<File> { file };

        }
        public void RemoveFile(File file)
        {
            if (Files == null)
                throw new Exception();
            Files.Remove(file);

        }
        public void RemoveSubFolder(Folder folder)
        {
            if (SubFolders == null)
                throw new Exception();

            SubFolders.Remove(folder);

        }

        public int GetSizeOfFolder()
        {
            var totalSize = 0;
            if (SubFolders != null)
                foreach (var folder in SubFolders)
                {
                    totalSize += folder.GetSizeOfFolder();
                }
            if(Files!=null)
                foreach (var file in Files)
                {
                    totalSize += file.GetSizeOfFile();
                }
            return totalSize;
        }

    }
}
