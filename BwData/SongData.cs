using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BwData
{
    public static partial class Song
    {
        //define         your Properties
        public static List<string> MusicData = new List<string>();
        public static int GetSongCount { get { return MusicData.Count; } }
        public static void Add(string[] Names)
        {
            if (Names.Length != 0)
            {
                foreach(var Temp in Names)
                    {
                    if (!MusicData.Contains(Temp))
                    {
                        MusicData.Add(Temp);
                    }//end if
                }//end for.each
                Array.Clear(Names, 0, Names.Length);
            }//end if
        }//end Method.Add
        public static string GetSongById(int Id)
        {
            if (Id > -1 && Id <= MusicData.Count)
            {
                var query = MusicData.ElementAtOrDefault(Id);
                if (!string.IsNullOrEmpty(query))
                {
                    return query;
                }//end if
            }//end if
            return "";
            }//end method.GetSongById
    }//end class
}//end namespace