using System;
using System.IO;
using System.Security.Permissions;

namespace FileWatcher
{
  class Program
  {
    static void Main(string[] args)
    {
      //Watching thư mục
      RunWatcher();

      Console.Read();
    }

    //[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public static void RunWatcher()
    {
      //Get đường dẫn
      string path = @"D:\watcher\";

      //Check đường dẫn
      if (path.Length < 2)
      {
        Console.WriteLine("Directory is not correct");
        return;
      }

      //Tạo FileSystemWatcher
      FileSystemWatcher watcher = new FileSystemWatcher();
      watcher.Path = path;

      //Chỉ watch cho các file txt
      //watcher.Filter = "*.txt";
      //Chỉ watch cho all file
      watcher.Filter = "*.*";

      //Đăng ký event
      watcher.Changed += new FileSystemEventHandler(OnChanged);
      watcher.Created += new FileSystemEventHandler(OnChanged);
      watcher.Deleted += new FileSystemEventHandler(OnChanged);
      watcher.Renamed += new RenamedEventHandler(OnRenamed);

      //Begin watching.
      watcher.EnableRaisingEvents = true;
      Console.WriteLine("Directory is {0}", path);
    }

    //Define event
    private static void OnChanged(object source, FileSystemEventArgs e)
    {
      Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
    }

    private static void OnRenamed(object source, RenamedEventArgs e)
    {
      Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
    }
  }
}
