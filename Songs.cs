using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Songs
    {
        public int song_id { get; set; }
        public string song_title { get; set; }
        public int song_duration { get; set; }
        public List<Songs> songs { get; set; }
    }
}
