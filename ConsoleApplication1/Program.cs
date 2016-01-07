using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNestNET;

namespace EchoNestDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect test = new Connect("API-KEY");
            Parser p = new Parser();
            Parameters parameters = new Parameters();
            parameters.songBucketParameters.songHotttnesssRank = true;
            String songTest = test.SongSearch("radiohead", parameters);
            IList<Song> songList = p.SongParse(songTest);
            foreach (Song song in songList)
            {
                Console.WriteLine(song.songHotttnesssRank);
            }
            Console.ReadLine();
        }
    }
}
