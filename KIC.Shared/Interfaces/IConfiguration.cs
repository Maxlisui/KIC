using System;
using System.Collections.Generic;
using System.Text;

namespace KIC.Shared.Interfaces
{
    interface IConfiguration
    {
        string Name { get; set; }
        string Language { get; set; }
        string FileExtension { get; set; }
        string[] ExcluededFileNames { get; set; }
    }
}
