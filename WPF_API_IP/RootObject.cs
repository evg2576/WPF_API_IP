using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_API_IP
{
    internal class RootObject
    {
        public string ip { get; set; }
        public bool success { get; set; }
        public string type { get; set; }
        public string continent { get; set; }
        public string continent_code { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public string city { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public bool is_eu { get; set; }
        public string postal { get; set; }
        public string calling_code { get; set; }
        public string capital { get; set; }
        public string borders { get; set; }
        public Flag flag { get; set; }
        public Connection connection { get; set; }
        public Timezone timezone { get; set; }
    }
}
