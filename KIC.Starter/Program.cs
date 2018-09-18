using KIC.Shared.Helpers;
using KIC.Shared.Logger;
using System;
using System.IO;
using System.Linq;

namespace KIC.Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            try
            {
                var config = JsonHelper.FromJson<Shared.VOs.Configuration>(Directory.GetCurrentDirectory() + "//C-Sharp.json");

                var test = FileSystemHelper.GetAllFilesFromDirectoryWithFileExtension(new DirectoryInfo(Directory.GetCurrentDirectory() + "//..//..//..//.."), config.FileExtension, config.ExcluededFileNames.ToList());
            }
            catch (Exception ex)
            {
                logger.Log(ex);
            }

            Console.ReadLine();
        }
    }
}
