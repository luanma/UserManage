using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Chitu
{
    public class Game
    {
        public int GameId;
        public string GameName { get; set; }
        public string FileParseKeyString { get; set; }
        public BitmapImage image { get; set; }

        public string LocalPath { get; set; }

        public string GameType { get; set; }
    }

}
