using System;
namespace BwData
{
    public class SongModel
    {
        public string FullName { get; set; }
        public string FullPath { get; set; }
        public SongModel(string FullName,string FullPath)
        {
            this.FullName = FullName;
            this.FullPath = FullPath;
        }//end con
    }//end Class
}//end name space