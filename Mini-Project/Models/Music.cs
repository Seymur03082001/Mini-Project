using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.Models
{
    internal class Music
    {
        public int _id;
        public string _name;
        public string _artistName;
        public int _time;

        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        
        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }
        
        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public Music()
        {
            Id = _id;
            Name= _name;
            ArtistName = _artistName;
            Time = _time;
        }
        public Music(int id, string name, string artistName, int time)
        {
            this.Id = id;
            this.Name = name;
            this.ArtistName = artistName;
            this.Time = time;
        }
    }
}
