using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.Models
{
    internal class Playlist<T>
    {
        T[] _music;
        private int _count;
        public int Count { get { return _music.Length;} }
        
        public Playlist() 
        { 
            _count = 0;
            _music = new T[0];
        }
        public void Add(T item)
        {
            _music[0] = item;
            Array.Resize(ref _music,_music.Length +1);
            _music[_music.Length - 1] = item;
        }
        private bool Play(T item)
        {
            if (_music.Length != 0)
            {
                return false;
            }
            return true;
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }
    }
}
