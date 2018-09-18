using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KIC.Shared.Helpers
{
    public static class FileSystemHelper
    {
        public static List<FileInfo> GetAllFilesFromDirectoryWithFileExtension(DirectoryInfo dir, string extension, List<string> excludedFileNames = null)
        {
            excludedFileNames = excludedFileNames ?? new List<string>();
            
            if (!dir.Exists)
            {
                throw new Exception("Cannont find directory " + dir.FullName);
            }

            var files = new List<FileInfo>();

            if(string.IsNullOrWhiteSpace(extension))
            {
                files = dir.GetFiles().ToList();
            }
            else
            {
                if (!extension.StartsWith("."))
                {
                    extension = "." + extension;
                }

                files = dir.GetFiles("*" + extension).Where(x => !excludedFileNames.Any(y => x.Name.Contains(y))).ToList();
            }

            dir.GetDirectories().ToList().ForEach(x =>
            {
                files.AddRange(GetAllFilesFromDirectoryWithFileExtension(x, extension, excludedFileNames));
            });

            return files.ToList();
        }
    }
}
