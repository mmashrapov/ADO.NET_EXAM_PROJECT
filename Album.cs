using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Album
    {
        public int album_id { get; set; }
        public int artist_id { get; set; }
        public string album_title { get; set; }
        public DateTime album_year { get; set; }
        public string album_tracks { get; set; }
        public List<Album> albums { get; set; }
        public virtual ICollection<Album_song> AlbumsSongs { get; set; }
        public virtual Artist IdArtistNavigation { get; set; }
    }
}
