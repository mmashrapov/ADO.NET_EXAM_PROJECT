using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Artist
    {
        public int artist_id { get; set; }
        public int genre_id { get; set; }
        public int country_id { get; set; }
        public List<Artist> artists { get; set; }
        public string Artist_Site_URL { get; set; }
        public virtual Album IdGenreNavigation { get; set; }
        public virtual Songs IdCountryNavigation { get; set; }
    }
}
