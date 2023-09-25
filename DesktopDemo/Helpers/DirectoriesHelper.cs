using System;
using System.IO;

namespace DesktopDemo.Helpers
{
    public class DirectoriesHelper : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DirectoryInfo[] GetDirectories(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            return directoryInfo.GetDirectories();
        }

        public string myTest(int a)
        {
            return (a > 0) ? "you are hero" : "you are zero";
        }
    }
}
