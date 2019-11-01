using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMangerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var file = new File("f1", 100);

            var folder = new Folder("f2");
            folder.AddSubFileSystem(file);
            var parentFolder = new Folder("ParentFolder");
            parentFolder.AddSubFileSystem(folder);
            parentFolder.AddSubFileSystem(file);
            var folders = parentFolder.GetSubFolders();
            var second = new Folder("f3");
            folders.Add(second);
            var test = parentFolder.GetSubFolders();
            var sizeBeforeRemove = parentFolder.GetSize();
            Console.WriteLine(sizeBeforeRemove);
            parentFolder.RemoveSubFileSystem(file);
            var sizeAfterRemove = parentFolder.GetSize();
            Console.WriteLine(sizeAfterRemove);
            Console.ReadKey();
        }
    }
}
