using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Person
    {
        public int artist_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public DateTime birthday { get; set; }
        public string sex { get; set; }
        public List<Person> persons { get; set; }
        public virtual Album IdArtistNavigation { get; set; }
    }
}
