using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KIC.Shared.Helpers
{
    public static class JsonHelper
    {
        /// <summary>
        /// Deserilazes from JSON.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Error while deserializing JSON</exception>
        public static T FromJson<T>(string path)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            }
            catch(Exception ex)
            {
                throw new Exception("Error while deserializing JSON", ex);
            }
        }

        /// <summary>
        /// Serilazes to JSON.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Error while serializing JSON</exception>
        public static string ToJson(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while serializing JSON", ex);
            }
        }
    }
}
