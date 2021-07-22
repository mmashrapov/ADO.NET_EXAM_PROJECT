using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Group
    {
        public int artist_id { get; set; }
        public string group_name { get; set; }
        public List<Group> groups { get; set; }
        public virtual Album IdArtistNavigation { get; set; }
    }
}
