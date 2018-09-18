using KIC.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KIC.Shared.VOs
{
    public class Configuration : IConfiguration
    {
        #region properties

        public string Name { get; set; }
        public string Language { get; set; }
        public string FileExtension { get; set; }
        public string[] ExcluededFileNames { get; set; }

        #endregion
    }
}
