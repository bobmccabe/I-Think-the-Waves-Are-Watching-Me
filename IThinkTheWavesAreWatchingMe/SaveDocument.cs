using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class SaveDocument
    {
        public static void AccessData()
        {
            string FilePath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "WatchingWaveResults.txt");
            StreamWriter sw = new StreamWriter(FilePath, true);
            sw.Close();
        }
    }
}
