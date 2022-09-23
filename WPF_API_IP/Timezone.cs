using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_API_IP
{
    internal class Timezone
    {
        public string id { get; set; }
        public string abbr { get; set; }
        public bool is_dst { get; set; }
        public int offset { get; set; }
        public string utc { get; set; }
        public DateTime current_time { get; set; }
    }
}
