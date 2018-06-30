using System;
using System.IO;

namespace Worky.Extensions
{
    public static class FileLogging
    {
        public static string GetMonthlyLogFilename(string applicationName, string extension)
        {
            if (string.IsNullOrWhiteSpace(applicationName))
                throw new ArgumentException(nameof(applicationName));

            string filetitle = DateTime.Now.ToString("yyyy_MM") + extension;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return Path.Combine(path, applicationName, filetitle);
        }
    }
}
