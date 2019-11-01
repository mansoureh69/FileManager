namespace FileMangerTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    namespace FileManagerUnitTest
    {

        [TestClass]
        public class FileSystemTests
        {
            public User User { get; set; }
            [TestMethod]
            public void AddFileToFolder_Success()
            {
                var file = new File
                {
                    CreationDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now,
                    CreatorUser = User,
                    Size = 100
                };
                var folder = new Folder
                {
                    CreationDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now,
                    CreatorUser = User
                };
                folder.AddSubFileSystem(file);
                var parentFolder = new Folder
                {
                    CreationDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now,
                    CreatorUser = User
                };
                parentFolder.AddSubFileSystem(folder);
                parentFolder.AddSubFileSystem(file);
                var t = parentFolder.GetSize();
                Assert.AreEqual(t,200);
            }

        }
    }

}
