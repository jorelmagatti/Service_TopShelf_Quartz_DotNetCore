using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleServiceTopShelf
{
    public static class LogLocal
    {
        #region Params
        private static readonly object _lock = new object();
        public static string Value { get; set; }
        private static string ficheiro = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + @"\Degub\Log.txt";
        private static bool flGravaLogLocal = Convert.ToBoolean(ConfigurationManager.AppSettings["flGravaLogLocal"]);
        #endregion

        #region Public Method
        public static void Log(string message)
        {
            try
            {
                if (flGravaLogLocal)
                {
                    if (!Directory.Exists(Path.GetDirectoryName(ficheiro)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(ficheiro));

                        StreamWriter file = new StreamWriter(ficheiro, true, Encoding.Default);
                        file.WriteLine(DateTime.Now + " -> " + message);
                        file.Dispose();
                    }
                    else
                    {
                        StreamWriter file = new StreamWriter(ficheiro, true, Encoding.Default);
                        file.WriteLine(DateTime.Now + " -> " + message);
                        file.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public static void LogNoFlag(string message)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(ficheiro)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(ficheiro));

                    StreamWriter file = new StreamWriter(ficheiro, true, Encoding.Default);
                    file.WriteLine(DateTime.Now + " -> " + message);
                    file.Dispose();
                }
                else
                {
                    StreamWriter file = new StreamWriter(ficheiro, true, Encoding.Default);
                    file.WriteLine(DateTime.Now + " -> " + message);
                    file.Dispose();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

    }
}
