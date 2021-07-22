using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Album_song
    {
        public int album_id { get; set; }
        public int song_id { get; set; }
        public int track_number { get; set; }
        public List<Album_song> album_songs { get; set; }
        public virtual Album IdAlbumNavigation { get; set; }
        public virtual Songs IdSongNavigation { get; set; }
    }
}
