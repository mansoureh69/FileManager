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
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            var user=new User();
            Console.WriteLine("Hello World!");
            var file = new File
            {
                CreationDateTime = DateTime.Now,
                LastModifiedDateTime = DateTime.Now,
                CreatorUser = user,
                Size = 100
            };
            var folder = new Folder
            {
                CreationDateTime = DateTime.Now,
                LastModifiedDateTime = DateTime.Now,
                CreatorUser = user
            };
            folder.AddSubFileSystem(file);
            var parentFolder = new Folder
            {
                CreationDateTime = DateTime.Now,
                LastModifiedDateTime = DateTime.Now,
                CreatorUser = user
            };
            parentFolder.AddSubFileSystem(folder);
            parentFolder.AddSubFileSystem(file);
            parentFolder.AddSubFileSystem(file);
            var sizeBeforeRemove = parentFolder.GetSize();
            Console.WriteLine(sizeBeforeRemove);
            parentFolder.RemoveSubFileSystem(file);
            var sizeAfterRemove = parentFolder.GetSize();
            Console.WriteLine(sizeAfterRemove);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
