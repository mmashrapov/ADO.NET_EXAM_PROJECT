using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Genre
    {
        public int genre_id { get; set; }
        public string genre_name { get; set; }
        public List<Genre> genres { get; set; }
        public virtual Album IdGenreNavigation { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
    }
}
