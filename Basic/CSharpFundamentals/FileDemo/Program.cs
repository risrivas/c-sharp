using System;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"C:\Users\rishi\Desktop\fb\IMG_0615.jpg", @"C:\Users\rishi\Desktop\IMG_0615.jpg", true);

            var path = @"C:\Users\rishi\Desktop\IMG_0615.jpg";
            File.Delete(path);
            if (File.Exists(path))
            {
                //...
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            // fileInfo.CopyTo("..");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            //fileInfo.IsReadOnly()

            /* Directory */

            Directory.CreateDirectory(@"C:\Temp");

            var files = Directory.GetFiles(@"C:\Users\rishi\workspace_scala", "*.scala", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                // Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\rishi\workspace_scala", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                // Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            /* Path */
            var path1 = @"C:\Users\rishi\workspace_scala\hello.scala";
            var dotIndex = path1.IndexOf('.');
            var extension = path1.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path1));
            Console.WriteLine("File Name: " + Path.GetFileName(path1));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path1));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path1));

        }
    }
}
