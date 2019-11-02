using System;

namespace FileMangerTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            var file = new File("f1", 100);

            var folder = new Folder("f2");
            folder.AddSubFileSystem(file);
            var parentFolder = new Folder("ParentFolder");
            parentFolder.AddSubFileSystem(folder);
            parentFolder.AddSubFileSystem(file);
            var folders = parentFolder.GetFileSystems();
            var second = new Folder("f3");
            folders.Add(second);
            var test = parentFolder.GetFileSystems();
            var sizeBeforeRemove = parentFolder.GetSize();
            Console.WriteLine(sizeBeforeRemove);
            parentFolder.RemoveSubFileSystem(file);
            var sizeAfterRemove = parentFolder.GetSize();
            Console.WriteLine(sizeAfterRemove);
            Console.ReadKey();
        }
    }
}
