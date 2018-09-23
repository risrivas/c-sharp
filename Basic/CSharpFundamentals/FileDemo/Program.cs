using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\somefile.jpg";

            File.Copy(@"C:\Users\rishi\Desktop\fb\IMG_0615.jpg", @"C:\Users\rishi\Desktop\IMG_0615.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                // 
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            //fileInfo.IsReadOnly()
        }
    }
}
