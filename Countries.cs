using System;
using System.Collections.Generic;
using System.Text;

namespace Ado.net_exam.models
{
    public class Countries
    {
        public int country_id { get; set; }
        public string country_name { get; set; }
        public List<Countries> countries { get; set; }
    }
}
